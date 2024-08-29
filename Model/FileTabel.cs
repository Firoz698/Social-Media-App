using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FileTabel
    {
        public FileTabel()
        {
            Id = 0;
            Image = null;
        }
        [Key]
        public int Id { get; set; }
        public byte[]? Image { get; set; }

    }
}
