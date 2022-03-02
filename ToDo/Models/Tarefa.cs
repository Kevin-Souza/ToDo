using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public DateTime EndDate { get; set; }

        public bool Status { get; set; }
    }
}
