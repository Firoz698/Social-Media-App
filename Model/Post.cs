using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Post
    {
        public Post()
        {
            Id = 0;
            UserId = 0;
            Image = null;
            Title = "";
            Description = "";
        }

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public byte[]? Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
