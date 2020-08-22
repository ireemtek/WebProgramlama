using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogg.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Text { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        public string UserName { get; set; }
        [Required]
        public string CatName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime TimeStamp { get; set; } = DateTime.Now;


        public List<MainComment> MainComments { get; set; }


    }
}
