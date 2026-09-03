using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("Stock")]
    public class Stock : EntityBase
    {
        public int ProductID { get; set; }
        public decimal Qty { get; set; }
    }
}
