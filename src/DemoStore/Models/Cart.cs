using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStore.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }

        public decimal Price { get; set; }
        public string Name { get; set; }
        public bool Complete { get; set; }
        public bool delivery { get; set; }
        public decimal Tax { get; set; }
    }
}
