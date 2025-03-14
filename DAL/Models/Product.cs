using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(Supplier))]
        public int SupplierId { get; set; }


        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }

        public virtual List<Stock> Stocks { get; set; } = new List<Stock>();
        public virtual List<SalesDetails> SalesDetails { get; set; } = new List<SalesDetails>();

        public override string ToString()
        {
            return $"{ Name}";
        }
    }
}
