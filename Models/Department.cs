using System.ComponentModel.DataAnnotations;

namespace ScamStore.Models
{
    public class Department
    {
        [Key]// data annotation (specifies this is a primary key)
        public int Id { get; set;} = 0;

        [Required, StringLength(300)]
        public string Name { get; set;} = string.Empty;
        
        [StringLength(1000)]
        public String? Description { get; set;} = string.Empty;

        // Relationship with Products and place to store products in the Department instance
        public virtual ICollection<Product>? Products { get; set; }
    }
}