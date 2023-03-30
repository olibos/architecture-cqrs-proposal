// <copyright file="UserMapper.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Mappers;

using NewArchi.Domain.Models;
using NewArchi.Domain.ResponseModels;

using Riok.Mapperly.Abstractions;

[Mapper]
public partial class UserMapper
{
    public partial UserDto GetUserDto(User user);
}
