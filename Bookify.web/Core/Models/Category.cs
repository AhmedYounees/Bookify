namespace Bookify.web.Core.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(30)]
        public string Name { get; set; } =null!;

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime? LastUpdateOn { get; set; }
    }
}
