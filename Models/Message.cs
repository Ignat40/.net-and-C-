using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Message
    {

        public int Id { get; set; }
        [Required] 
        public string UserName { get; set; }
        public string Text { get; set; }
        [Required]
        public DateTime When { get; set; }

        public string UserID { get; set; }
        public virtual AppUser Sender { get; set; }

    }
}
