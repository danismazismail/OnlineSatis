﻿using AutoMapper;
using DataTransfer.Concrete;
using Entities.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.AutoMapper
{
    public class UserBusinessMapping : Profile
    {
        public UserBusinessMapping()
        {
            CreateMap<LoginDto, User>()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.DeletedDate, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore()).ReverseMap();

            CreateMap<UserForRegisterDto, User>()
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash))
            .ForMember(dest => dest.PasswordSalt, opt => opt.MapFrom(src => src.PasswordSalt))
            .ForMember(dest => dest.MobilePhone, opt => opt.MapFrom(src => src.MobilePhone))
            .ForMember(dest => dest.UserRoleCode, opt => opt.MapFrom(src => src.UserRoleCode))
            .ReverseMap();

            CreateMap<UserForRegisterDto, UserDetail>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.IdentityNumber, opt => opt.MapFrom(src => src.IdentityNumber))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(dest => dest.MobilePhone, opt => opt.MapFrom(src => src.MobilePhone))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.UserCode, opt => opt.MapFrom(src => src.UserCode))
                .ReverseMap();

            CreateMap<UserForGetUserCodeDto, User>().ReverseMap();
            CreateMap<GetUserDto, User>().ReverseMap();

            CreateMap<UserDetail, UserDetailDto>().ReverseMap();


            CreateMap<Product, GetAllProductDto>().ReverseMap();

            CreateMap<Shipper, GetAllShipperDto>().ReverseMap();
            
            CreateMap<Order, CreateOrderDto>()
                .ForMember(dest => dest.OrderDate, opt=> opt.MapFrom(src =>src.OrderDate))
                .ForMember(dest => dest.UserCode, opt=> opt.MapFrom(src =>src.UserCode))
                .ForMember(dest => dest.ShipperCode, opt=> opt.MapFrom(src =>src.ShipperCode))
                .ReverseMap();
            
            
            
            CreateMap<OrderDetail, CreateOrderDetailDto>().ReverseMap();
            CreateMap<Order, GetOrderDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, GetAllProductDto>().ReverseMap();
            
            CreateMap<Category, GetAllCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Product, GetProductsDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, DeleteProductDto>().ReverseMap();
        }
    }
}
