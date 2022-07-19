﻿using App.Domain.Service;
using App.Infrastructure.Base;
using App.Infrastructure.Database;
using App.Infrastructure.Database.Entities;
using App.Infrastructure.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Config.Dependecias
{
    public class Container
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            #region BaseRepository
            services.AddScoped<IBaseRepository<LogsGeneral>, LogsGeneralRepository>();
            #endregion

            #region Repositories
            services.AddScoped<IFacturaRepository, FacturaRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<IinventarioRepository, InventarioRepository>();
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
            services.AddScoped<IDetalleRepository, DetalleRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ILogsGeneralRepository, LogsGeneralRepository>();
            #endregion

            #region Services
            services.AddScoped<IFacturaService, FacturaService>();
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<IinventarioService, InventarioService>();
            services.AddScoped<IEmpleadoService, EmpleadoService>();
            services.AddScoped<IDetalleService, DetalleService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ILogsGeneralServices, LogsGeneralServices>();
            services.AddScoped<ILogsGeneralConBaseServices, LogsGeneralConBaseServices>();
            #endregion

            #region Mapper

            var configMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
            var mapper = configMapper.CreateMapper();

            services.AddSingleton(mapper);

            #endregion

            #region Conection

            services.AddDbContext<DataContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("facturacionTienda"))
            );

            #endregion
        }
    }
}
