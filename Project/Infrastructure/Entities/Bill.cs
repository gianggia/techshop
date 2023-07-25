using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Enums;

namespace Infrastructure.Entities
{
    [Table("Bills")]
    public class Bill:BaseEntity
    {
        [MaxLength(1000)]
        public string FirstName { get; set; }
        [MaxLength(1000)]
        public string LastName { get; set; }
        [MaxLength(1000)]
        public string Email { get; set; }
        [MaxLength(1000)]
        public string Address { get; set; }

        [MaxLength(1000)]
        public string Telephone { get; set; }

        [Column(TypeName = "decimal(18,2")]
        public decimal TotalAmount { get; set; }

        public PaymentMethod PaymentMethod;

        public ICollection<BillDetail> BillDetails { get; set; }




    }
}
