using Microsoft.EntityFrameworkCore;

namespace RazorPages.Service
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext( DbContextOptions options):base(options) 
        
        {
            
        }
    }
}
