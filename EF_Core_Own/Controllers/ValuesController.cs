using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_Own.Model;
using Microsoft.AspNetCore.Mvc;

namespace EF_Core_Own.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly SchoolContext _schoolContext;

        public ValuesController(SchoolContext context)
        {
            _schoolContext = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Class> Get()
        {
            return _schoolContext.Classes.ToList();
          
        }

    }
}
