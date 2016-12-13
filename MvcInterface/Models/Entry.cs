namespace MvcInterface.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entry")]
    public partial class Entry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }
    }
}
