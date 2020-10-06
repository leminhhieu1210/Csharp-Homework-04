using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class DSMonHoc
    {
        string ten;
        int tinChi;
        double diem;

        public DSMonHoc()
        {
            ten = "";
            tinChi = 0;
            diem = 0;
        }

        public DSMonHoc(string ten, int tinChi, double diem)
        {
            this.ten = ten;
            this.tinChi = tinChi;
            this.diem = diem;
        }

        public string Ten { get => ten; set => ten = value; }
        public int TinChi { get => tinChi; set => tinChi = value; }
        public double Diem { get => diem; set => diem = value; }
    }
}
