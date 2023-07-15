using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using Yildirim.TodoAppNTier.Business.Interfaces;
using Yildirim.TodoAppNTier.Business.Mappings.AutoMapper;
using Yildirim.TodoAppNTier.Business.Services;
using Yildirim.TodoAppNTier.Business.ValidationRules;
using Yildirim.TodoAppNTier.DataAccess.Contexts;
using Yildirim.TodoAppNTier.DataAccess.UnitOfWork;
using Yildirim.TodoAppNTier.Dtos.WorkDtos;

namespace Yildirim.TodoAppNTier.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt =>
            {
                opt.UseSqlServer("database=TodODb; integrated security=true;");
                opt.LogTo(Console.WriteLine, LogLevel.Information);
            });

            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new WorkProfile());
            });
            var mapper = configuration.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IUow, Uow>();
            services.AddScoped<IWorkService, WorkService>();
            services.AddTransient<IValidator<WorkCreateDto>, WorkCreateDtoValidatior>();
            services.AddTransient<IValidator<WorkUpdateDto>, WorkUpdateDtoValidator>();

                }
    }
}
