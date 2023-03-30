// <copyright file="User.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Domain.Models;

public record User(int Id, string Fullname, string PasswordHash);
