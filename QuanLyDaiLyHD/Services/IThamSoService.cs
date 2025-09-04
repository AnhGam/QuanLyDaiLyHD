namespace QuanLyDaiLyHD.Services;

public interface IThamSoService
{
    Task<string> GetThamSo(string key);
}