using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RMPQAapi.Data.Entities;
using RMPQAapi.Data.Entities.Interfaces;
using RMPQAapi.Data.Infrastructure;
using RMPQAapi.Domain.Dto;
using RMPQAapi.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductEntity = RMPQAapi.Data.Entities.Product;

namespace RMPQAapi.Domain.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepository<ProductEntity> productRepository;
        private readonly IImageService imageService;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ProductService(IRepository<ProductEntity> productRepository, IImageService imageService)
        {//, IMapper mapper, IHttpContextAccessor httpContextAccessor
            this.productRepository = productRepository;
            this.imageService = imageService;
            //this.mapper = mapper;
            //this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<object> GetProducts()
        {
            //var carEntity = mapper.Map<CreateCarDto, CarEntity>(productDto);
            //int userId = httpContextAccessor.HttpContext!.User.GetCurrentUserId();
            //carEntity.OwnerId = userId;
            //await imageService.UploadImageAsync(carEntity, productDto.Image);

            //var newCar = await carRepository.AddAsync(carEntity);
            //await carRepository.SaveChangesAsync();

            //return mapper.Map<CarEntity, CreateCarDto>(newCar);
            object newProduct = productRepository.Query();
            //await carRepository.SaveChangesAsync();
            return newProduct;
        }
    }
}
