using System.Collections.Generic;
using BethanyPieShop.Web.Models;

namespace BethanyPieShop.Web.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string Title { get; set; }
    }
}