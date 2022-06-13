namespace LocadoraVipFilmes.API.DTOs.AtorDTO
{
    public class UpdateAtorDTO
    {
        public UpdateAtorDTO()
        {

        }

        public int Id { get; set; }
        public string NomeAtor { get; set; }
        public string SobreNome { get; set; }
        public DateTime DtNascimento { get; set; }

        public List<object> FilmeAtors { get; set; }

    }
}
