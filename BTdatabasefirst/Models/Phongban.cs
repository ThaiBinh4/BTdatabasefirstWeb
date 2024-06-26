﻿using System;
using System.Collections.Generic;

namespace BTdatabasefirst.Models;

public partial class Phongban
{
    public string Idpb { get; set; } = null!;

    public string? Tenphongban { get; set; }

    public string? Mota { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
