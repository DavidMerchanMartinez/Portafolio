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
                    Titulo = "Amazon",
                    Descripcion = "E-commerce realizado en ASP.NET Core",
                    Link =  "https://amazon.com",
                    ImagenURL = "/imagenes/prueba.png"
                },
                new ProyectoDTO
                {
                    Titulo = "New York Times",
                    Descripcion = "Pagina de noticias en react",
                    Link =  "https://nytimes.com",
                    ImagenURL = "/imagenes/prueba.png"
                },
                new ProyectoDTO
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link =  "https://reddit.com",
                    ImagenURL = "/imagenes/prueba.png"
                },
                new ProyectoDTO
                {
                    Titulo = "steam",
                    Descripcion = "tienda en linea para comprar videojuegos",
                    Link =  "https://store.steampowered.com",
                    ImagenURL = "/imagenes/prueba.png"
                },
            };
        }
    }
}
