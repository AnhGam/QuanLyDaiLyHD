using QuanLyDaiLyHD.Interfaces;
using QuanLyDaiLyHD.Models;
using QuanLyDaiLyHD.Services;

namespace QuanLyDaiLyHD.ServiceImpls;

public class QuanServiceImpl : IQuanService
{
    private readonly IQuanRepository quanRepository;

    public QuanServiceImpl(IQuanRepository quanRepository)
    {
        this.quanRepository = quanRepository;
    }

    public Task<IEnumerable<Quan>> GetAlllQuansAsync()
    {
        return quanRepository.GetAllQuansAsync();
    }
}