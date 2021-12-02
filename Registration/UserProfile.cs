﻿using AutoMapper;
using Registration.Entities;
using Registration.Models;

namespace Registration
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, User>()
                .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dst => dst.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dst => dst.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dst => dst.Id, opt => opt.Ignore())
                ;

            CreateMap<User, AuthenticateResponse>()
                .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Login, opt => opt.MapFrom(src => src.Login))
                .ForMember(dst => dst.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Token, opt => opt.Ignore())
                ;
        }
    }
}
