using QuanLyDaiLyHD.Interfaces;
using QuanLyDaiLyHD.Models;
using QuanLyDaiLyHD.Services;

namespace QuanLyDaiLyHD.ServiceImpls;

public class LoaiDaiLyServiceImpl : ILoaiDaiLyService
{
    private readonly ILoaiDaiLyRepository loaiDaiLyRepository;

    public LoaiDaiLyServiceImpl(ILoaiDaiLyRepository loaiDaiLyRepository)
    {
        this.loaiDaiLyRepository = loaiDaiLyRepository;
    }

    public Task<IEnumerable<LoaiDaiLy>> GetAllLoaiDaiLiesAsync()
    {
        return loaiDaiLyRepository.GetAllLoaiDaiLiesAsync();
    }
}