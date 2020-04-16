using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Platform_Services_Portal.Models;

namespace Platform_Services_Portal.Controllers
{
    public class PortalMetricsController : Controller
    {
        private PortalMetricsContext _context;

        private readonly ILogger<PortalMetricsController> _logger;
        public PortalMetricsController(ILogger<PortalMetricsController> logger, PortalMetricsContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            try
            {
                PortalMetrics metric = new PortalMetrics();
                metric.MSG = "Teste2";
                _context.Metric.Add(metric);
                _context.SaveChanges();
            }
            catch (System.Exception ex)
            { }
           
            return View(_context.Metric);
        }
      

        public IActionResult Create(PortalMetrics metric)
        {
           

            return View(metric);
        }
    }
}