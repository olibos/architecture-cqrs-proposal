// <copyright file="LoginResponse.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Domain.Responses;

using NewArchi.Domain.Errors;
using NewArchi.Domain.ResponseModels;

using OneOf;

[GenerateOneOf]
public partial class LoginResponse : OneOfBase<UserDto, BadCredentials>
{
    public static LoginResponse BadCredentials { get; } = new BadCredentials();
}