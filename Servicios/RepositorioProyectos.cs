using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO
                {
                    Titulo = "Finanzas",
                    Descripcion = "Administrador de presupuesto en ASP.NET Core",
                    Link =  "https://github.com/DavidMerchanMartinez/ManejoPresupuesto",
                    ImagenURL = "/imagenes/Transacciones_Dia.png"
                },
                new ProyectoDTO
                {
                    Titulo = "Portafolio",
                    Descripcion = "Descripcion general del programador",
                    Link =  "https://github.com/DavidMerchanMartinez/Portafolio",
                    ImagenURL = "/imagenes/Portafolio.png"
                },
                //new ProyectoDTO
                //{
                //    Titulo = "Reddit",
                //    Descripcion = "Red social para compartir en comunidades",
                //    Link =  "https://reddit.com",
                //    ImagenURL = "/imagenes/prueba.png"
                //},
                //new ProyectoDTO
                //{
                //    Titulo = "steam",
                //    Descripcion = "tienda en linea para comprar videojuegos",
                //    Link =  "https://store.steampowered.com",
                //    ImagenURL = "/imagenes/prueba.png"
                //},
            };
        }
    }
}
