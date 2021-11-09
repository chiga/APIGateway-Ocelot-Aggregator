using Microsoft.AspNetCore.Mvc;
using price.Helpers;
using price.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace price.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksPricesController : ControllerBase
    {
        private readonly IEnumerable<BookPrice> BookPrices;

        public BooksPricesController()
        {
            BookPrices = BookPriceFactoryHelper.GenerateBookPrices();
        }

        [HttpGet]
        public IEnumerable<BookPrice> Get()
        {
            return BookPrices;
        }

        [HttpGet("{code:guid}")]
        public BookPrice Get(Guid code)
        {
            return BookPrices.Where(bp => bp.Code == code).SingleOrDefault();
        }
    }
}
