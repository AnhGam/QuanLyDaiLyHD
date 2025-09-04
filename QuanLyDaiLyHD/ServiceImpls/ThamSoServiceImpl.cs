using QuanLyDaiLyHD.Interfaces;
using QuanLyDaiLyHD.Services;

namespace QuanLyDaiLyHD.ServiceImpls;

public class ThamSoServiceImpl : IThamSoService
{
    private readonly IThamSoRepository thamSoRepository;

    public ThamSoServiceImpl(IThamSoRepository thamSoRepository)
    {
        this.thamSoRepository = thamSoRepository;
    }

    public Task<string> GetThamSo(string key)
    {
        return thamSoRepository.GetThamSo(key);
    }
}