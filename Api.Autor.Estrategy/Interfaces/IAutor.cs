namespace Api.Autor.Estrategy.Servicios
{
    public interface IAutor
    {
        void insertarAutor();
    }

    public interface IConsulta
    {
        void Consultar();
    }

    public interface IConsultarFiltro {
        void ConsultarFiltro();
    }
}
