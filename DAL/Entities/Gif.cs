using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task8_dotNET.Models
{
    public class Gif
    {

        [Key] 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public User user { get; set; }
    }
}
