using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Task8_dotNET.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Gif> gifs { get; set; }
    }
}
