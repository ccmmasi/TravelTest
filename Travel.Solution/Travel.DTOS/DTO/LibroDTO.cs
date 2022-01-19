namespace Travel.DTOS.DTO
{
    public class LibroDTO
    {
        public double ISBN { get; set; }
        public double Editorial_Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string NPaginas { get; set; }
        public EditorialDTO Editorial { get; set; }
    }
}
