using NguyenDuongTanDung_Tuan3.Models;
using Microsoft.EntityFrameworkCore;

namespace NguyenDuongTanDung_Tuan3.Repository
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public EFCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            var product = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(product);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Category>> GetAllAsync()
        {
           return await _context.Categories.ToListAsync();
        }

        public Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public Task UpdateAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
