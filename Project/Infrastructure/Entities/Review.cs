using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    [Table("Reviews")]
    public class Review:BaseEntity
    {
        [MaxLength(1000)]
        public string ReviewerName { get; set; }
        [MaxLength(1000)]
        public string email { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        
        public int rating { get; set; }
        [ForeignKey("Product-reviews")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }



    }
}
