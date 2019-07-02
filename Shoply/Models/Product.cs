using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shoply.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        
        
        [Required]
        public string Name { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal StockValue { get; set; }

        //public string NameSort { get; set; }
        //public string DescriptionSort { get; set; }
        //public IList<Product> product { get; set; }
        //public async Task OnGetAsync (string sortOrder)
        //{
        //    product = await _context.Students.ToListAsync();
        //}

    }
}
