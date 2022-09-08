using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MihailTest.Models
{
    public class Category : IBaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        public string Description { get; set; }


        public virtual List<Product> Products { get; set; }
    }
}
