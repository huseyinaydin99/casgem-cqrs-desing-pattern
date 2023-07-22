using Casgem.CQRS.CQRSPattern.Handlers;
using Casgem.CQRS.CQRSPattern.Results;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            //List<GetProductQueryResult> values2 = _getProductQueryHandler.Handle();

            return View(values);
        }
    }
}
