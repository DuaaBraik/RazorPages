using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectWithRazorPages.Data;
using ProjectWithRazorPages.Models;

namespace ProjectWithRazorPages.Pages.Categories
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Category> Categories { get; set; }

        private readonly ProjectDbContext context;

        public IndexModel(ProjectDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Categories = context.Category;
        }
    }
}
