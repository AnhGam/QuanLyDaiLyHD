using QuanLyDaiLyHD.Models;

namespace QuanLyDaiLyHD.Interfaces;

public interface ILoaiDaiLyRepository
{
    Task<IEnumerable<LoaiDaiLy>> GetAllLoaiDaiLiesAsync();
}