using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }


        [Required(ErrorMessage = "Informe o id do tipo do usuario !")]
        public int IdTipoUsuario { get; set; }


        [Required(ErrorMessage = "Informe o email !")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Informe a senha !")]
        public string? Senha { get; set; }
    }
}
