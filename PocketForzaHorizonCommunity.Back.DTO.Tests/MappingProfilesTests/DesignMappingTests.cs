﻿using AutoMapper;
using NUnit.Framework;
using PocketForzaHorizonCommunity.Back.Database.Entities.GuideEntities.DesignEntities;
using PocketForzaHorizonCommunity.Back.DTO.DTOs.GuidesDtos;
using PocketForzaHorizonCommunity.Back.DTO.Mapper;
using PocketForzaHorizonCommunity.Back.DTO.Requests.Guides.Design;

namespace PocketForzaHorizonCommunity.Back.DTO.Tests.MappingProfilesTests;

[TestFixture]
public class DesignMappingTests
{
    [Test]
    public void Design_To_DesginDto_Should_Map()
    {
        var design = Boilerplate.GetDesignSample();
        var expected = MapDesignToDto(design);
        var mapper = new MapperConfiguration(cfg => cfg.AddProfile<DesignProfile>()).CreateMapper();

        var actual = mapper.Map<Design, DesignDto>(design);

        Assert.IsTrue(CompareDesigns(expected, actual));
    }

    [Test]
    public void Design_To_DesignFullInfoDto_Should_Map()
    {
        var design = Boilerplate.GetDesignSample();
        var expected = MapToDesignFullInfoDto(design);
        var mapper = new MapperConfiguration(cfg => cfg.AddProfile<DesignProfile>()).CreateMapper();

        var actual = mapper.Map<Design, DesignFullInfoDto>(design);

        Assert.IsTrue(CompareDesigns(expected, actual));
    }

    [Test]
    public void CreateDesignRequest_To_Design_Should_Map()
    {
        var expected = Boilerplate.GetDesignSample();

        var request = Boilerplate.GetCreateDesignRequestSample();

        var mapper = new MapperConfiguration(cfg => cfg.AddProfile<DesignProfile>()).CreateMapper();

        var actual = mapper.Map<CreateDesignRequest, Design>(request);

        Assert.IsTrue(CompareDesigns(expected, actual));
    }

    private DesignDto MapDesignToDto(Design design)
    {
        return new DesignDto
        {
            Id = design.Id.ToString(),
            Title = design.Title,
            ThumbnailUrl = design.DesignOptions.ThumbnailUrl,
            Description = design.DesignOptions.Description,
            ForzaShareCode = design.ForzaShareCode,
            Rating = design.Ratings.Average(r => r.Rating),
            CreationDate = design.CreationDate,
            AuthorUsername = design.User.UserName,
            CarModel = $"{design.Car.Manufacture.Name} {design.Car.Model} {design.Car.Year}",
        };
    }

    private DesignFullInfoDto MapToDesignFullInfoDto(Design design)
    {
        var desginDto = MapDesignToDto(design);

        return new DesignFullInfoDto
        {
            Id = desginDto.Id.ToString(),
            Title = desginDto.Title,
            Description = design.DesignOptions.Description,
            ForzaShareCode = desginDto.ForzaShareCode,
            Rating = desginDto.Rating,
            CreationDate = desginDto.CreationDate,
            AuthorUsername = desginDto.AuthorUsername,
            CarModel = desginDto.CarModel,
            ThumbnailUrl = desginDto.ThumbnailUrl,
            Gallery = design.DesignOptions.Gallery.Select(x => x.ImageUrl).ToList(),
        };
    }

    private bool CompareDesigns(DesignDto expected, DesignDto actual)
    {
        foreach (var property in actual.GetType().GetProperties())
        {
            if (!property.GetValue(actual).Equals(property.GetValue(expected))) return false;

        }
        return true;
    }

    private bool CompareDesigns(DesignFullInfoDto expected, DesignFullInfoDto actual)
    {
        foreach (var property in actual.GetType().GetProperties())
        {
            if (property.Name == nameof(actual.Gallery)) continue;
            if (!property.GetValue(actual).Equals(property.GetValue(expected))) return false;
        }

        for (var i = 0; i < actual.Gallery.Count; i++)
        {
            if (!Enumerable.SequenceEqual(actual.Gallery[i], expected.Gallery[i])) return false;
        }

        return true;
    }

    private bool CompareDesigns(Design expected, Design actual)
    {
        foreach (var property in actual.GetType().GetProperties())
        {
            if (property.Name == nameof(actual.Car)) continue;
            if (property.Name == nameof(actual.User)) continue;
            if (property.Name == nameof(actual.DesignOptions)) continue;
            if (property.Name == nameof(actual.CreationDate)) continue;
            if (property.Name == nameof(actual.Ratings)) continue;
            if (!property.GetValue(actual).Equals(property.GetValue(expected))) return false;
        }

        foreach (var property in actual.DesignOptions.GetType().GetProperties())
        {
            if (property.Name == nameof(actual.DesignOptions.Design)) continue;
            if (property.Name == nameof(actual.DesignOptions.ThumbnailUrl)) continue;
            if (property.Name == nameof(actual.DesignOptions.Gallery)) continue;
            if (!property.GetValue(actual.DesignOptions).Equals(property.GetValue(expected.DesignOptions))) return false;
        }

        return true;
    }
}
