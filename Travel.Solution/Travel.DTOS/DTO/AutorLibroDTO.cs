namespace Travel.DTOS.DTO
{
    public class AutorLibroDTO
    {
        public double Autor_Id { get; set; }
        public double Libro_ISBN { get; set; }
        public AutorDTO Autor { get; set; }
        public LibroDTO Libro { get; set; }
    }
}
