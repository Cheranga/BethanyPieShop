using System.Collections.Generic;

namespace BethanyPieShop.Web.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}