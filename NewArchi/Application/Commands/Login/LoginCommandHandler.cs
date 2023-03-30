// <copyright file="LoginCommandHandler.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Application.Commands.Login;

using Isopoh.Cryptography.Argon2;

using MediatR;

using Microsoft.EntityFrameworkCore;

using NewArchi.Domain.Entities;
using NewArchi.Services;

using Riok.Mapperly.Abstractions;

[Mapper]
public partial class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResponse>
{
    private readonly AppDbContext _appDbContext;

    public LoginCommandHandler(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _appDbContext.Users.SingleOrDefaultAsync(u => u.Username == request.Username);
        if (user == null || !Argon2.Verify(user.PasswordHash, request.Password)) return LoginCommandResponse.BadCredentials;

        return Success(user);
    }

    private partial SuccessResponse Success(User user);
}