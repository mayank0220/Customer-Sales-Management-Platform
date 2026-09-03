using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaleSystemCore.Models
{
    [Table("Permissions")]
    public class Permission : EntityBase
    {
        [DataType(DataType.Text), MaxLength(150)]
        public string PermKey { get; set; }     
    }
}
