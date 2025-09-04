using QuanLyDaiLyHD.Models;

namespace QuanLyDaiLyHD.Services;

public interface IQuanService
{
    Task<IEnumerable<Quan>> GetAlllQuansAsync();
}