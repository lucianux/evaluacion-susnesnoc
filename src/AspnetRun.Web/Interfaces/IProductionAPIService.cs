using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetRun.Web.ViewModels;

namespace AspnetRun.Web.Interfaces
{
    public interface IProductionAPIService
    {
        List<ProductionViewModel> GetProduction(
            ProductionParameterViewModel par);
    }
}