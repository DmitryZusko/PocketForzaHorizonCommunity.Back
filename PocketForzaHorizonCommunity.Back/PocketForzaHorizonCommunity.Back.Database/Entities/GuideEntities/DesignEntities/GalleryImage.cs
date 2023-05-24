﻿using Microsoft.EntityFrameworkCore;

namespace PocketForzaHorizonCommunity.Back.Database.Entities.GuideEntities.DesignEntities;

[PrimaryKey(nameof(DesignOptionsId), nameof(ImagePath))]
public class GalleryImage
{
    public Guid DesignOptionsId { get; set; }
    public DesignOptions DesignOptions { get; set; } = null!;
    public string ImagePath { get; set; } = null!;
}