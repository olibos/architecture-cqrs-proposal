// <copyright file="LoginCommand.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Application.Commands.Login;

using MediatR;

using NewArchi.Domain.Responses;

public record LoginCommand(string Username, string Password) : IRequest<LoginResponse>;