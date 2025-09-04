using Microsoft.EntityFrameworkCore;
using QuanLyDaiLyHD.Data;
using QuanLyDaiLyHD.Interfaces;
using QuanLyDaiLyHD.Models;

namespace QuanLyDaiLyHD.Repositories;

public class LoaiDaiLyRepository : ILoaiDaiLyRepository
{
    private readonly DataContext _dataContext;

    public LoaiDaiLyRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<IEnumerable<LoaiDaiLy>> GetAllLoaiDaiLiesAsync()
    {
        return await _dataContext.LoaiDaiLies.ToListAsync();
    }
}