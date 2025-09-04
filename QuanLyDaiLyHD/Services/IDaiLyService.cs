using QuanLyDaiLyHD.Models;

namespace QuanLyDaiLyHD.Services;

public interface IDaiLyService
{
    Task<IEnumerable<DaiLy>> GetAllDaiLiesAsync();
    Task<int> AddDaiLyAsync(DaiLy newDaiLy);
    Task<int> GetNextAvailableIdAsync();
}