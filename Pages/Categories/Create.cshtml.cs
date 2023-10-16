using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectWithRazorPages.Data;
using ProjectWithRazorPages.Models;

namespace ProjectWithRazorPages.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        public Category Category { get; set; }

        private readonly ProjectDbContext context;
        public CreateModel(ProjectDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                context.Category.Add(Category);
                await context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
