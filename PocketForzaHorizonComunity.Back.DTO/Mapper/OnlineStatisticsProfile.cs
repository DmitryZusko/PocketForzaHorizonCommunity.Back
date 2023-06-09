﻿using AutoMapper;
using PocketForzaHorizonCommunity.Back.Database.Entities.UserStatisticsEntitites;
using PocketForzaHorizonCommunity.Back.DTO.DTOs.StatisticsDtos;

namespace PocketForzaHorizonCommunity.Back.DTO.Mapper;

public class OnlineStatisticsProfile : Profile
{
    public OnlineStatisticsProfile()
    {
        CreateMap<OnlineStatistics, OnlineStatisticsDto>();
    }
}
