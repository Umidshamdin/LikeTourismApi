﻿using DomainLayer.Entities;
using ServiceLayer.DTOs.AppUser;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccountService
    {
        Task Register(RegisterDto registerDto);
        Task<string> Login(LoginDto loginDto);
        Task ConfirmEmail(string userId, string token);
        Task<UserDto> GetUserByEmailAsync(string email);

        Task UpdatePassword(AppUser appUser, UpdatePasswordDto updatePasswordDto);

    }
}
