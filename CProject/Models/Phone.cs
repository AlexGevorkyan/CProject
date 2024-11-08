using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProject.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        [ForeignKey("FK_Brand_123")]
        public int BrandId { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public int Count { get; set; }

    }
}
