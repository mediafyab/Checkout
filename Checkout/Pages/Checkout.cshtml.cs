using Checkout.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Checkout.Pages
{
    public class CheckoutModel : PageModel
    {
    }

    public class CheckoutDto
    {
        public Country Country { get; set; }
        public string ImageUrl { get; set; }
    }
}
