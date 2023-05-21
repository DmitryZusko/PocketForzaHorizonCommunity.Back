﻿using PocketForzaHorizonCommunity.Back.Database.Entities;
using PocketForzaHorizonCommunity.Back.DTO.Requests.Authentication;

namespace PocketForzaHorizonCommunity.Back.Services.Services.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> SignUpUserAsync(SignUpRequest request);
        Task<ApplicationUser> SignUpWithSpecificRoleAsync(SignUpRequest request, string role);
        Task<ApplicationUser> SingInUserAsync(SignInRequest request);
        Task<ApplicationUser> VerifyGoogleSingInAsync(GoogleSignInRequest request);
        Task<ApplicationUser> GetCurrentUser(string userId);
        Task<List<string>> GetUserRoles(ApplicationUser user);
    }
}