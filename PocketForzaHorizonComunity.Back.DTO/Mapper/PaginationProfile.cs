﻿using AutoMapper;
using PocketForzaHorizonCommunity.Back.Database.Models;
using PocketForzaHorizonCommunity.Back.DTO.Responses;

namespace PocketForzaHorizonCommunity.Back.DTO.Mapper;

public class PaginationProfile : Profile
{
    public PaginationProfile()
    {
        CreateMap(typeof(PaginationModel<>), typeof(PaginatedResponse<>));
    }
}
