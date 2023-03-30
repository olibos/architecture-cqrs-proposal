// <copyright file="LoginCommandHandler.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Application.Commands.Login;

using Isopoh.Cryptography.Argon2;

using MediatR;

using NewArchi.Application;
using NewArchi.Domain.Interfaces;
using NewArchi.Domain.Models;
using NewArchi.Domain.Responses;
using NewArchi.Mappers;

public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly UserMapper _userMapper;

    public LoginCommandHandler(IUserRepository userRepository, UserMapper userMapper)
    {
        _userRepository = userRepository;
        _userMapper = userMapper;
    }

    public async Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserAsync(request.Username);
        if (user == null || !Argon2.Verify(user.PasswordHash, request.Password)) return LoginResponse.BadCredentials;

        return _userMapper.GetUserDto(user);
    }
}