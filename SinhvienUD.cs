using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongpvPH54797
{
    internal class SinhvienUD : Sinhvien
    {
        private int kiHoc; // Thêm thuộc tính
        public SinhvienUD() // constructor không tham số
        {
            
        }
        public SinhvienUD(string maSinhVien, string ten, int namSinh, double diem, int kiHoc) : base(maSinhVien, ten, namSinh, diem)
        {
            this.KiHoc = kiHoc;
        }

        public int KiHoc { get => kiHoc; set => kiHoc = value; }
        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine($"Kì học thứ {kiHoc}");
        }
        
    }
}
