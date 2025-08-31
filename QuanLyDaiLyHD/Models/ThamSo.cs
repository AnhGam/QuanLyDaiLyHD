using System.ComponentModel.DataAnnotations;

namespace QuanLyDaiLyHD.Models;

public class ThamSo
{
    [Key]
    public string TenThamSo { get; set; } = "";
    public string GiaTri { get; set; } = "";
}
