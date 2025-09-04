namespace QuanLyDaiLyHD.Interfaces;

public interface IThamSoRepository
{
    Task<string> GetThamSo(string key);
}