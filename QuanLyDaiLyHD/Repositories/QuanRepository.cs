using Microsoft.EntityFrameworkCore;
using QuanLyDaiLyHD.Data;
using QuanLyDaiLyHD.Interfaces;
using QuanLyDaiLyHD.Models;

namespace QuanLyDaiLyHD.Repositories;

public class QuanRepository : IQuanRepository
{
    private readonly DataContext _dataContext;

    public QuanRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<IEnumerable<Quan>> GetAllQuansAsync()
    {
        return await _dataContext.Quans.ToListAsync();
    }
}