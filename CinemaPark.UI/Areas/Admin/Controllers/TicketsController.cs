using BusinessLogic.Abstract;
using DAL.Concrete.EfCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaPark.UI.Areas.Admin.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

     
        public  async Task<IActionResult> Index()
        {
            var tickets = await _ticketService.GetTicketListAsync();
            return View(tickets);
        }
    }
}
