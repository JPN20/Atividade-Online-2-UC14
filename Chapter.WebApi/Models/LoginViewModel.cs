using System.ComponentModel.DataAnnotations;

namespace ChapterTF.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail Requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Senha Requirida")]
        public string Senha { get; set; }
    }
}
