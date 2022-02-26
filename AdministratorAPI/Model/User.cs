using System.ComponentModel.DataAnnotations;

namespace AdministratorAPI.Data
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string senha { get; set; }
        
        
    }
}