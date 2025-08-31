﻿using System.ComponentModel.DataAnnotations;

namespace QuanLyDaiLyHD.Models;

public class Quan
{
    [Key]
    public int MaQuan { get; set; }
    public string TenQuan { get; set; } = "";

    public virtual List<DaiLy> DaiLies { get; set; } = [];
}
