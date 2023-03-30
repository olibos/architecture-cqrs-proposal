// <copyright file="IUserRepository.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Domain.Interfaces;

using NewArchi.Domain.Entities;

[Obsolete("Accès direct dans le handler au DbContext - Attention Moq")]
public interface IUserRepository
{
    Task<User?> GetUserAsync(string username);
}
