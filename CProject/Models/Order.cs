using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProject.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("FK_User_123")]
        public int UserId { get; set; }

        [ForeignKey("FK_Phone_123")]
        public int PhoneId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime SoldAt { get; set; }

    }
}
