﻿using AutoMapper;
using NUnit.Framework;
using PocketForzaHorizonCommunity.Back.Database.Entities.Guides;
using PocketForzaHorizonCommunity.Back.DTO.DTOs.GuidesDtos;
using PocketForzaHorizonCommunity.Back.DTO.Mapper;
using PocketForzaHorizonCommunity.Back.DTO.Requests.Guides;

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
        var request = Boilerplate.GetCreateDesignRequestSample();
        var expected = Boilerplate.GetDesignSample();

        // for just created designs rating should be 0
        expected.Rating = 0;

        var mapper = new MapperConfiguration(cfg => cfg.AddProfile<DesignProfile>()).CreateMapper();

        var actual = mapper.Map<CreateDesignRequest, Design>(request);

        Assert.IsTrue(CompareDesigns(expected, actual));
    }

    private DesignDto MapDesignToDto(Design design)
    {
        var designDto = new DesignDto();

        using (var stream = new FileStream(design.DesignOptions.ThumbnailPath, FileMode.Open))
        {
            var thumbnail = new byte[stream.Length];
            stream.Read(thumbnail);
            designDto.Thumbnail = thumbnail;
        }

        designDto.Id = design.Id.ToString();
        designDto.Title = design.Title;
        designDto.ForzaShareCode = design.ForzaShareCode;
        designDto.Rating = design.Rating;
        designDto.AuthorUsername = design.User.UserName;
        designDto.CarModel = $"{design.Car.Manufacture.Name} {design.Car.Model} {design.Car.Year}";

        return designDto;
    }

    private DesignFullInfoDto MapToDesignFullInfoDto(Design design)
    {
        var desginDto = MapDesignToDto(design);
        var imageList = new List<byte[]>();

        foreach (var image in design.DesignOptions.Gallery)
        {
            using (var stream = new FileStream(image.ImagePath, FileMode.Open))
            {
                var nextImage = new byte[stream.Length];
                stream.Read(nextImage);
                imageList.Add(nextImage);
            }
        }


        return new DesignFullInfoDto
        {
            Id = desginDto.Id.ToString(),
            Title = desginDto.Title,
            ForzaShareCode = desginDto.ForzaShareCode,
            Rating = desginDto.Rating,
            AuthorUsername = desginDto.AuthorUsername,
            CarModel = desginDto.CarModel,
            Thumbnail = desginDto.Thumbnail,
            Description = design.DesignOptions.Description,
            Gallery = imageList,
        };
    }

    private bool CompareDesigns(DesignDto expected, DesignDto actual)
    {
        foreach (var property in actual.GetType().GetProperties())
        {
            if (property.Name == nameof(actual.Thumbnail))
            {
                if (Enumerable.SequenceEqual(actual.Thumbnail, expected.Thumbnail) == true) continue;
            }
            if (!property.GetValue(actual).Equals(property.GetValue(expected))) return false;

        }
        return true;
    }

    private bool CompareDesigns(DesignFullInfoDto expected, DesignFullInfoDto actual)
    {
        foreach (var property in actual.GetType().GetProperties())
        {
            if (property.Name == nameof(actual.Gallery)) continue;
            if (property.Name == nameof(actual.Thumbnail))
            {
                if (Enumerable.SequenceEqual(actual.Thumbnail, expected.Thumbnail) == true) continue;
            }
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
            if (!property.GetValue(actual).Equals(property.GetValue(expected))) return false;
        }

        foreach (var property in actual.DesignOptions.GetType().GetProperties())
        {
            if (property.Name == nameof(actual.DesignOptions.Design)) continue;
            if (property.Name == nameof(actual.DesignOptions.ThumbnailPath)) continue;
            if (property.Name == nameof(actual.DesignOptions.Gallery)) continue;
            if (!property.GetValue(actual.DesignOptions).Equals(property.GetValue(expected.DesignOptions))) return false;
        }

        return true;
    }
}
