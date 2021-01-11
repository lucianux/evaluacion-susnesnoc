using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspnetRun.Web.ViewModels;
using AspnetRun.Web.Interfaces;

namespace TodoApp.Controllers
{
    [ApiController]
    public class ProductionController : ControllerBase
    {
        private const int _TOTAL_FIGURES = 1000000;

        private readonly IProductionAPIService _productionAPIService;
        private readonly ILogger<ProductionController> _logger;

        public ProductionController(ILogger<ProductionController> logger,
            IProductionAPIService productionAPIService)
        {
            _productionAPIService = productionAPIService;
            _logger = logger;
        }

        [HttpPost]
        [Route("/getProduction")]
        public ActionResult GetProduction(
            [FromBody] ProductionParameterViewModel prodParameter
        )
        {
            // object result = "c" + prodParameter.date;
            // if (prodParameter.squares + prodParameter.triangles +
            // prodParameter.rectangles + prodParameter.circles < _TOTAL_FIGURES) {
            //     return StatusCode(500, "dd");
            // }
            // return Ok(result);

            var result = _productionAPIService.GetProduction(prodParameter);

            if (result == null)
                return new NotFoundResult();

            return new ObjectResult(result);
        }

        [HttpGet]
        [Route("/prueba")]
        public string Prueba()
        {
            return "Test ok!";
        }
    }
}

