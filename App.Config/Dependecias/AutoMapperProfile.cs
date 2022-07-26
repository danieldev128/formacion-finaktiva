using App.Common.DTO;
using App.Infrastructure.Database.Entities;
using AutoMapper;



namespace App.Config.Dependecias
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LogsGeneral, LogsGeneralDTO>().ReverseMap();
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Detalle, DetalleDTO>().ReverseMap();
            CreateMap<Empleado, EmpleadoDTO>().ReverseMap();
            CreateMap<Inventario, InventarioDTO>().ReverseMap();
            CreateMap<Producto, ProductoDTO>().ReverseMap();
            CreateMap<Factura, FacturaDTO>().ReverseMap();
            CreateMap<vw_productos, ProductoDTO>().ReverseMap();


        }
    }
}
