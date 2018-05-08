using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BethanyPieShop.Web.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _context;

        public PieRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _context.Pies.AsNoTracking();
        }

        public Pie GetPieById(int pieId)
        {
            return _context.Pies.FirstOrDefault(x => x.Id == pieId);
        }
    }
}