using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VKT1.Pages
{
    public class ContactModel : PageModel
    {
        public bool sadrziPoruku = false;
        public string kupacImePrezime = "";
        public string kupacEmail = "";
        public string kupacTelefon = "";
        public string kupacPoruka = "";


        public void OnGet()
        {
        }

        public void OnPost() 
        {
            sadrziPoruku = true;
            kupacImePrezime = Request.Form["kupacImePrezime"];
            kupacEmail = Request.Form["kupacEmail"];
            kupacTelefon = Request.Form["kupacTelefon"];
            kupacPoruka = Request.Form["kupacPoruka"];
        }

    }
}
