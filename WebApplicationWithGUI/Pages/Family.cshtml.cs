using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationWithGUI.Classes;

namespace WebApplicationWithGUI.Pages
{
    public class FamilyModel : PageModel
    {
        public bool hasData = true;

        public List<Family> family_list = new List<Family>();

        public void OnGet()
        {
            
        }
        public void OnPost()
        {
            hasData = true;
            int id = family_list.Count + 1;
            string full_name = Request.Form["full_name"];
            string gender = Request.Form["gender"];
            int age = Convert.ToInt32(Request.Form["age"]);
            Relation relation = (Relation)Convert.ToInt32(Request.Form["relation"]);
            family_list.Add(new Family(id, full_name, gender, age, relation));
        }
    }
}
