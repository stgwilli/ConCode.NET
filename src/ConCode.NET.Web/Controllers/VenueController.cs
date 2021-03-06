using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ConCode.NET.Web.Models.VenueViewModels;
using ConCode.NET.Core.Domain;

namespace ConCode.NET.Web.Controllers
{
    public class VenueController : Controller
    {

        private IVenueService _venueService;

        public VenueController(IVenueService venueService)
        {
            this._venueService = venueService;
        }       

        public IActionResult Index()
        {
            var venueModel = new VenueListViewModel { VenueList = _venueService.GetVenues().ToList() };
            return View(venueModel);
        }

        public IActionResult Add()
        {
            return View(new AddVenueViewModel());
        }

        [HttpPost]
        public IActionResult Add(AddVenueViewModel model)
        {
            var venue = new Venue
            {
                Description = model.Description
            };

            _venueService.AddVenue(venue);

            return View(_venueService);

           // return View("Index", new VenueListViewModel { VenueList = _venueService.GetVenues().ToList() });
        }

    }
}