// <copyright file="UserRepository.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Services;

using NewArchi.Domain.Interfaces;
using NewArchi.Domain.Models;

public class UserRepository : IUserRepository
{
    public Task<User?> GetUserAsync(string username)
    {
        var result = "olibos".Equals(username) ?
            new User(1, "Olivier Bossaer", "$argon2id$v=19$m=65536,t=3,p=1$xG554Pvqw8WXHTpLgDXVgw$bcHssJYmVT4vj+K4dr9iq+nYxGhcQ4VNPDnejVrtjw4") :
            default;

        return Task.FromResult(result);
    }
}
