using System;
using System.Collections.Generic;

namespace BaiKiemTra03_03_x_.Models;

public partial class HopDong
{
    public int ContracId { get; set; }

    public string? ContracName { get; set; }

    public DateTime? SigningDate { get; set; }

    public int? Customer { get; set; }

    public decimal? ContractValue { get; set; }

    public virtual KhachHang? CustomerNavigation { get; set; }
}
