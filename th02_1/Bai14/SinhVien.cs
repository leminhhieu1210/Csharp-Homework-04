using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class SinhVien
    {
        string hoten, khoa;
        List<string> GiaoTrinh = new List<string>();
        int k, id;

        public SinhVien()
        {
            hoten = khoa = "";
            k = id = 0;
            GiaoTrinh = new List<string>();
        }

        public SinhVien(int id, string hoten, string khoa, int k, List<string> giaoTrinh)
        {
            this.hoten = hoten;
            this.khoa = khoa;
            GiaoTrinh = giaoTrinh;
            this.k = k;
            this.id = id;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public List<string> GiaoTrinh1 { get => GiaoTrinh; set => GiaoTrinh = value; }
        public int K { get => k; set => k = value; }
        public int ID { get => id; set => id = value; }
    }
}
