using Microsoft.AspNetCore.Mvc;

namespace AP204_Pronia.Areas.ProniaAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("ProniaAdmin")]

        public IActionResult Views()
        {
            return RedirectToActionPermanentPreserveMethod();
        }
    }
}
