using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

namespace AspnetRun.Web.ViewModels
{
    public class ProductionParameterViewModel : BaseViewModel
    {
        public DateTime date { get; set; }
        public int squares { get; set; }
        public int triangles { get; set; }
        public int rectangles { get; set; }
        public int circles { get; set; }
    }
}
