using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;


namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage, IFormFile file)
        {
            var result = BusinessRules.Run(CheckCarImageCount(carImage.CarId));

            if (result != null)
            {
                return result;
            }

            FileHelperForLocalStorage.Add(file, CreateNewPath(file, out var pathForDb));

            carImage.ImagePath = pathForDb;
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);

            return new SuccessResult(Messages.ImagesAddedSuccessfully);
        }

        public IResult Update(CarImage carImage, IFormFile file)
        {
            var result = BusinessRules.Run(CheckCarImageCount(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            var carImageForUpdate = _carImageDal.Get(c => c.Id == carImage.Id);
            carImage.CarId = carImageForUpdate.CarId;
            carImage.Date = DateTime.Now;
            FileHelperForLocalStorage.Update(carImageForUpdate.ImagePath, file, CreateNewPath(file, out var pathForDb));
            carImage.ImagePath = pathForDb;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImagesUpdated);
        }

        public IResult Delete(CarImage carImage)
        {
            FileHelperForLocalStorage.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImagesDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }


        public IDataResult<List<CarImage>> GetImageListByCarId(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (result.Count == 0)
            {
                return new SuccessDataResult<List<CarImage>>(IfCarHasNoPhotoGetDefaultPhotoInTheList());
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(i => i.CarId == carId));
        }

        private IResult CheckCarImageCount(int carId)
        {
            var result = _carImageDal.GetAll(i => i.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.FailedCarImageAdd);
            }
            return new SuccessResult();
        }

        private string CreateNewPath(IFormFile file, out string pathForDb)
        {

            var fileInfo = new FileInfo(file.FileName);
            pathForDb = $@"{Guid.NewGuid()}_{DateTime.Now.Month}_{DateTime.Now.Day}_{DateTime.Now.Year}_{DateTime.Now.Millisecond}{fileInfo.Extension}";
            var createdPathForHdd = $@"{Environment.CurrentDirectory}\wwwroot\images\" + pathForDb;

            return createdPathForHdd;
        }

        private List<CarImage> IfCarHasNoPhotoGetDefaultPhotoInTheList()
        {
            //var realpath = ImagePath = $@"{Environment.CurrentDirectory}\wwwroot\images\CarRentalDefault.jpg"
            var defaultImageInImageList = new List<CarImage>();
            var carImage = new CarImage
            {
                ImagePath = "CarRentalDefault.jpg"
            };
            defaultImageInImageList.Add(carImage);
            return defaultImageInImageList;
        }
    }
}
