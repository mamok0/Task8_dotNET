using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task8_dotNET.Models
{
    public class GifTag
    {
        [Key]
        public int GifId { get; set; }
        [Key]
        public int TagId { get; set; }

        [ForeignKey("GifId")]
        public Gif gif { get; set; }
        [ForeignKey("TagId")]
        public Tag tag { get; set; }
    }
}
