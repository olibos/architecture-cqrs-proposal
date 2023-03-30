// <copyright file="BaseApiController.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace NewArchi.Api;

using FluentValidation;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;

[ApiController]
public abstract class BaseApiController : Controller
{
    public override void OnActionExecuted(ActionExecutedContext context)
    {
        HandleValidationException(context);
        base.OnActionExecuted(context);
    }

    /// <summary>
    /// Handles the validation exception by sending a 400 Bad Request if .
    /// </summary>
    /// <param name="context">The context.</param>
    private void HandleValidationException(ActionExecutedContext context)
    {
        if (context.Exception is not ValidationException validation) return;
        var problemDetailsFactory = this.HttpContext.RequestServices.GetService<ProblemDetailsFactory>();
        if (problemDetailsFactory is null) return;

        context.Exception = null;
        var problemDetails = problemDetailsFactory.CreateValidationProblemDetails(
            httpContext: this.HttpContext,
            modelStateDictionary: new ModelStateDictionary(),
            statusCode: StatusCodes.Status400BadRequest,
            title: "One or more validation errors occurred.");
        foreach (var error in validation.Errors)
        {
            problemDetails.Errors.Add(error.PropertyName, new[] { error.ErrorMessage });
        }

        context.Result = new BadRequestObjectResult(problemDetails);
    }
}