﻿using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using CockyEntertainment.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   .AddNegotiate();

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy.
    options.FallbackPolicy = options.DefaultPolicy;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapProgramEndpoints();

app.Run();


public static class ProgramEndpoints
{
	public static void MapProgramEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Program").WithTags(nameof(Program));

        group.MapGet("/", () =>
        {
            return new [] { new Program() };
        })
        .WithName("GetAllPrograms")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new Program { ID = id };
        })
        .WithName("GetProgramById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, Program input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateProgram")
        .WithOpenApi();

        group.MapPost("/", (Program model) =>
        {
            //return TypedResults.Created($"/api/Programs/{model.ID}", model);
        })
        .WithName("CreateProgram")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new Program { ID = id });
        })
        .WithName("DeleteProgram")
        .WithOpenApi();
    }
}