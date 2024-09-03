using ELCCWGA.Models;
using Microsoft.EntityFrameworkCore;

namespace ELCCWGA.Services
{
    public class ScoresService
    {
        AppDbContext dbContext = new AppDbContext();

        public ScoresService() { }
        public async Task<List<GolfScore>> GetAllScores()
        {
            return await dbContext.Scores.AsNoTracking().ToListAsync();
        }
    }
}
