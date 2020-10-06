using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th02_1
{
    class KhachHang
    {
        string HoTen, DiaChi, Loai, NgayGui;
        int MaKH, ThoiGianGui;
        long SoTienGui;
        float SoTienLai;

        public KhachHang()
        {
            HoTen = DiaChi = Loai = NgayGui = "";
            MaKH = ThoiGianGui = 0;
            SoTienGui = 0;
            SoTienLai = 0;
        }

        public KhachHang(string hoTen, string diaChi, string loai, string ngayGui, int maKH, int thoiGianGui, long soTienGui, float soTienLai)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
            Loai = loai;
            NgayGui = ngayGui;
            MaKH = maKH;
            ThoiGianGui = thoiGianGui;
            SoTienGui = soTienGui;
            SoTienLai = soTienLai;
        }

        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string NgayGui1 { get => NgayGui; set => NgayGui = value; }
        public int MaKH1 { get => MaKH; set => MaKH = value; }
        public int ThoiGianGui1 { get => ThoiGianGui; set => ThoiGianGui = value; }
        public long SoTienGui1 { get => SoTienGui; set => SoTienGui = value; }
        public string Loai1 { get => Loai; set => Loai = value; }
        public float SoTienLai1 { get => SoTienLai; set => SoTienLai = value; }
    }
}
