using System.ComponentModel.DataAnnotations;

namespace WebLearn.Models
{
    public class Cadastro
    {
        public int Id { get; set; }

        [Display(Name ="Nome")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
