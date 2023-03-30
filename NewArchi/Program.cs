// <copyright file="Program.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

#pragma warning disable SA1200 // Using directives should be placed correctly

using MediatR.Extensions.FluentValidation.AspNetCore;

using Microsoft.AspNetCore.Mvc.Controllers;

using NewArchi.Domain.Interfaces;
using NewArchi.Mappers;
using NewArchi.Services;

#pragma warning restore SA1200 // Using directives should be placed correctly

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblyContaining<Program>();
});

builder.Services.AddFluentValidation(new[] { typeof(Program).Assembly });
builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
    options.CustomOperationIds(api =>
    {
        if (api.ActionDescriptor is not ControllerActionDescriptor actionDescriptor) return null;
        return $"{actionDescriptor.ControllerName}_{actionDescriptor.ActionName}";
    });
});
builder.Services
       .AddSingleton<UserMapper>()
       .AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();