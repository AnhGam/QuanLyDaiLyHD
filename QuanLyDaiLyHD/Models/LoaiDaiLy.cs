using System.ComponentModel.DataAnnotations;

namespace QuanLyDaiLyHD.Models;

public class LoaiDaiLy
{
    [Key]
    public int MaLoaiDaiLy { get; set; }
    public string TenLoaiDaiLy { get; set; } = "";
    public long NoToiDa { get; set; }

    public virtual List<DaiLy> DaiLies { get; set; } = [];
}
