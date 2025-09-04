using Microsoft.EntityFrameworkCore;
using QuanLyDaiLyHD.Data;
using QuanLyDaiLyHD.Interfaces;

namespace QuanLyDaiLyHD.Repositories;

public class ThamSoRepository : IThamSoRepository
{
    private readonly DataContext dataContext;

    public ThamSoRepository(DataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    public Task<string> GetThamSo(string key)
    {
        return dataContext.ThamSos
            .Where(ts => ts.TenThamSo == key)
            .Select(ts => ts.GiaTri)
            .FirstOrDefaultAsync()!;
    }
}