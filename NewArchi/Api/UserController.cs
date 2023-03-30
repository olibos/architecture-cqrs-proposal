// <copyright file="UserController.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Api;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using NewArchi.Application.Commands.Login;
using NewArchi.Domain.ResponseModels;

using Swashbuckle.AspNetCore.Annotations;

[Route("/api/user")]
public class UserController : BaseApiController
{
    private readonly ISender _sender;

    public UserController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [SwaggerOperation(Description = "Test user: olibos Password: Bos")]
    public async Task<ActionResult<UserDto>> Login([FromBody] LoginCommand request)
    {
        var response = await _sender.Send(request);
        return response.Match(
            user => new ActionResult<UserDto>(user),
            invalid => this.Unauthorized());
    }
}