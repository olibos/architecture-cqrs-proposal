// <copyright file="User.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Domain.Entities;

public class User
{
    required public string Username { get; set; }

    required public string Fullname { get; set; }

    required public int Id { get; set; }

    required public string PasswordHash { get; set; }
}