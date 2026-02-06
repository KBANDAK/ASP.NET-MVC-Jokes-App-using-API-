using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using khaderbandak_202311342.Models;

namespace khaderbandak_202311342.Controllers
{
    public class HomeController : Controller
    {
        private readonly jokeservices _jokeservices = new jokeservices();

       
        
        public async Task<ActionResult> Index()
        {
           
            
                var joke = await _jokeservices.GetJokeAcasyc();
                return View(joke);
            
        }
    }
}