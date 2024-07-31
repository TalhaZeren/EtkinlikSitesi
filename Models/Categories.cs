using System.ComponentModel.DataAnnotations;

namespace EtkinlikProjesi.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }

    }
}
