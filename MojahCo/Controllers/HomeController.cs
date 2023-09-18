using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MojahCo.Data;
using MojahCo.Models;
using MojahCo.ViewModels;
using System.Diagnostics;
using System.IO;
namespace MojahCo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger , ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var menu = _context.Menus.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> _ShowMenu()
        {
            var menu = await _context.Menus.ToListAsync();
            return PartialView("_ShowMenu",menu);
        }

        public async Task<IActionResult> ShowSliders()
        {
            var sliders = _context.Sliders.OrderBy(slider=>slider.Order).ToList();
            return PartialView(sliders);
        }


        [HttpGet]
        [Route("DownloadPdf")]
        public async Task<IActionResult> DownloadPdf(int serviceId)
        {
            var servicePdf = _context.Services.FirstOrDefault(s => s.ServiceId == serviceId);
            var path = @"D:\Mojah";
            var pdf = servicePdf.PdfPath;

            var fullPath = Path.Combine(path, pdf);
            var file = System.IO.File.ReadAllBytes(fullPath);
           
            var fileStream = new FileStream(fullPath, FileMode.OpenOrCreate, FileAccess.Read);
            
            return File(fileStream, "application/pdf");
        }

        public async Task<IActionResult> About()    
        {
            return View();
        }

        public async Task<IActionResult> Shop()
        {
            return View();
        }

        public async Task<IActionResult> Services() 
        {
            var services = await _context
                .ServiceImages
                .Include(s=>s.Service)
                .ToListAsync();

            return View(services);
        }

        public async Task<IActionResult> ServicesDtl(int serviceId)
        {
            var service = await _context.Services.FirstOrDefaultAsync(i => i.ServiceId == serviceId);
           
            if(service == null)
            {
                return RedirectToAction("Error");
            }

            var serviceDtl = await _context.ServiceImages.Where(s => s.ServiceId == service.ServiceId).ToListAsync();

            var serviceViewModel = new ServiceViewModel
            {
                Service = service,
                ServiceImages = serviceDtl
            };

            return View(serviceViewModel);
        }

    }
}