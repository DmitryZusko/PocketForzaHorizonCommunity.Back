﻿using System.ComponentModel.DataAnnotations;

namespace PocketForzaHorizonCommunity.Back.Database.Entities.UserStatisticsEntitites;

public class UserStatisticsBase
{
    [Key]
    public Guid UserId { get; set; }
    public ApplicationUser User { get; set; } = null!;
}
