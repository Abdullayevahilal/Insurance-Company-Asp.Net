using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Castle.MicroKernel.SubSystems.Conversion;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
   public class Product : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        public int? LabelId { get; set; }
        public Label Label  { get; set; }
        public ICollection<Agent> Agents { get; set; }
        public ICollection<ProductSpec> ProductSpecs { get; set; }
    }
}
