using System;

namespace QLsinhVien.Models
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public DateTime? NgaySinh { get; set; }
        public byte? GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
    }
}