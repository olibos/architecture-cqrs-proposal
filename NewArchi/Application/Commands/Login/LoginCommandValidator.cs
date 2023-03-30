// <copyright file="LoginCommandValidator.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Application.Commands.Login;

using FluentValidation;

public class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(login => login.Username).NotEmpty();
        RuleFor(login => login.Password).NotEmpty();
    }
}