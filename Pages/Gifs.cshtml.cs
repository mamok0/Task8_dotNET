using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Task8_dotNET.Data;
using Task8_dotNET.Models;

namespace Task8_dotNET.Pages
{
    public class GifsModel : PageModel
    {
        private readonly Task8_dotNET.Data.GifContext _context;

        public GifsModel(Task8_dotNET.Data.GifContext context)
        {
            _context = context;
        }

        public IList<Gif> Gif { get;set; }

        public async Task OnGetAsync()
        {
            Gif = await _context.Gifs.Include(g => g.user).ToListAsync();

        }
    }
}
