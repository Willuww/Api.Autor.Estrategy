using Api.Autor.Estrategy.Persistencia;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Autor.Estrategy.Aplicacion
{
    public class NuevoStrategy //: IAutor
    {
        private readonly ContextoAutor contexto;
        public void insertarAutor()
        {
             async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
            {
                return await contexto.(data);
            }
        }
    }
}
