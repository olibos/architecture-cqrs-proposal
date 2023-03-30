// <copyright file="IUserRepository.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Domain.Interfaces;

using NewArchi.Domain.Models;

public interface IUserRepository
{
    Task<User?> GetUserAsync(string username);
}
