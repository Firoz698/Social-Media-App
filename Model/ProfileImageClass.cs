using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Model
{
    public class ProfileImageClass
    {

        public ProfileImageClass()
        {
            Id =0;
            Image = null;
        }
        [Key]
        public int Id { get; set; }
        public byte[]? Image { get; set; }
    }
}
