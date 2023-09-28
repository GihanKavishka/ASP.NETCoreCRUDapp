using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDapp.Data;
using CRUDapp.Models;

namespace CRUDapp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CRUDapp.Data.CRUDappContext _context;

        public IndexModel(CRUDapp.Data.CRUDappContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Person != null)
            {
                Person = await _context.Person.ToListAsync();
            }
        }
    }
}
