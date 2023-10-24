using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        public int Id { get; internal set; }

        [Required(ErrorMessage = "O preenchimento é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O preenchimento é no máximo de 50 caracteres.")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "O preenchimento é obrigatório.")]
        [MaxLength(40, ErrorMessage = "O preenchimento é no máximo de 40 caracteres.")]
        public string Genero { get; set; }
        
        [Required(ErrorMessage = "O preenchimento é obrigatório.")]
        [Range(70, 600, ErrorMessage ="A duração do filme deve ser entre 70 e 600 minutos.")]
        public int Duracao { get; set; }
    }
}
