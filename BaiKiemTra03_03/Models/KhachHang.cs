using System;
using System.Collections.Generic;

namespace BaiKiemTra03_03_x_.Models;

public partial class KhachHang
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<HopDong> HopDongs { get; set; } = new List<HopDong>();
}
