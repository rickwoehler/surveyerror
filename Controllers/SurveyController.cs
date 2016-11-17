using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Survey.Controllers
{
 public class SurveyController : Controller
 {
  [HttpGet]
  [Route("")]
  public IActionResult Index()
  {
   return View();
  }
 }
}