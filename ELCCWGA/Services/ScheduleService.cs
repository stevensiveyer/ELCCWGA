using ELCCWGA.Models;
using Microsoft.EntityFrameworkCore;

namespace ELCCWGA.Services
{
    public class ScheduleService
    {
        ScheduleDbContext dbContext = new ScheduleDbContext();

        public ScheduleService() { }
        public async Task<List<ScheduleItem>> GetScheduleItems()
        {
            return await dbContext.ScheduleItems.AsNoTracking().ToListAsync();
        }
    }
}