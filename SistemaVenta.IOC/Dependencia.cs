﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Internal;
using SistemaVenta.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.Implementacion;
using SistemaVenta.DAL.Interfaces;
using SistemaVenta.BLL.Implementacion;
using SistemaVenta.BLL.Interfaces;

namespace SistemaVenta.IOC
{
    public static class Dependencia
    {

        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration) { 
        
            services.AddDbContext<DbventaContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("CadenaSQL")); 
                });

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IVentaRepository, VentaRepository>();
            services.AddScoped<IEntradaRepository, EntradaRepository>();


            services.AddScoped<ICorreoService, CorreoService>(); 
            services.AddScoped<IFireBaseService, FireBaseService>();


            services.AddScoped<IUtilidadesService, UtilidadesService>();
            services.AddScoped<IRolService, RolService>();

            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<INegocioService, NegocioService>();

            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProductoService, ProductoService>();

            services.AddScoped<ITipoDocumentoVentaService, TipoDocumentoVentaService>();
            services.AddScoped<IVentaService, VentaService>();

            services.AddScoped<IEntradaService, EntradaService>();


            services.AddScoped<IDashBoardService, DashBoardService>();

            services.AddScoped<IMenuService, MenuService>();

            
        }

    }
}
