using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Currency.Proxy.Models;

namespace Currency.Proxy.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private CurrenciesDBContext _context = new CurrenciesDBContext();

        [Produces("application/json")]
        [HttpGet]
        public ActionResult<CurrenciesResult> GetAreas()
        {
            return new CurrenciesResult() { currencies = _context.Currencies.ToArray() };
        }
        private bool CurrenciesExists(string id)
        {
            return _context.Currencies.Any(e => e.Id == id);
        }
    }
}