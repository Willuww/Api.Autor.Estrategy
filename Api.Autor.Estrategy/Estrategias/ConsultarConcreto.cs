using Api.Autor.Estrategy.Servicios;
using MediatR;

namespace Api.Autor.Estrategy.Abtractas
{
    public abstract class ConsultarConcreto : IAutor 
    {

        public void insertarAutor()
        {
            //codigo de insertar autor

            throw new NotImplementedException();
        }

        public class ejecuta : IRequest
        { 

        }
    }
}
