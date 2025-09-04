using QuanLyDaiLyHD.Models;

namespace QuanLyDaiLyHD.Interfaces;

public interface IQuanRepository
{
    Task<IEnumerable<Quan>> GetAllQuansAsync();
}