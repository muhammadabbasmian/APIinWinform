using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIinWinform.Models
{
    
    public class student
    {
        
        public int Id { get; set; }
        
        public string StudentName { get; set; }

        public string Email { get; set; }

        public string Dob { get; set; }

        public string Notes { get; set; }

    }
}
