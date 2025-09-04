using QuanLyDaiLyHD.Models;

namespace QuanLyDaiLyHD.Services;

public interface ILoaiDaiLyService
{
    Task<IEnumerable<LoaiDaiLy>> GetAllLoaiDaiLiesAsync();
}