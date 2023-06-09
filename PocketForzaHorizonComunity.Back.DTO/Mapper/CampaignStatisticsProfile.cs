﻿using AutoMapper;
using PocketForzaHorizonCommunity.Back.Database.Entities.UserStatisticsEntitites;
using PocketForzaHorizonCommunity.Back.DTO.DTOs.StatisticsDtos;

namespace PocketForzaHorizonCommunity.Back.DTO.Mapper;

public class CampaignStatisticsProfile : Profile
{
    public CampaignStatisticsProfile()
    {
        CreateMap<CampaignStatistics, CampaignStatisticsDto>();
    }
}
