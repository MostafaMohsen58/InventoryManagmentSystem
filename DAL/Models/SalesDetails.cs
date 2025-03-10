using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SalesDetails
    {
        //public int Id { get; set; }
        [ForeignKey(nameof(Sale))]
        public int SaleId { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal unitPrice { get; set; }
        public  decimal Price { get; set; }

        public virtual Sale Sale { get; set; }

    }
}
