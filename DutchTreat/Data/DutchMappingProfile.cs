using System;
using AutoMapper;
using DutchTreat.Data.Entities;
using DutchTreat.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DutchTreat.Data
{
    public class DutchMappingProfile : Profile
    {
        public DutchMappingProfile()
        {
            CreateMap<Order, OrderViewModel>()
                .ForMember(o => o.OrderId, ex => ex.MapFrom(o => o.Id))
                .ReverseMap();

            CreateMap<OrderItem, OrderItemViewModel>()
                .ReverseMap();
        }
        
    }
}