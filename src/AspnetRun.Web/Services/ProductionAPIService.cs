using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspnetRun.Web.Interfaces;
using AspnetRun.Web.ViewModels;

namespace AspnetRun.Web.Services
{
    public class ProductionAPIService : IProductionAPIService
    {
        public List<ProductionViewModel> GetProduction(ProductionParameterViewModel par)
        {
            List<ProductionViewModel> list;
            list = new List<ProductionViewModel>();
            return list;
        }
    }
}