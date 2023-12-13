using BlazorApp2.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("kaydet")]
        [HttpPost]
        public void kaydet(kullanici k)
        {
            StreamWriter sw = new StreamWriter("kayit.txt", true);
            sw.WriteLine(k.adsoyad);
            sw.WriteLine(k.numara);
            sw.Close();
        }
    }     
}
