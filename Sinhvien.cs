using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongpvPH54797
{
    internal class Sinhvien
    {
        private string maSinhVien;
        string ten;
        int namSinh;
        double diem;

        public Sinhvien()
        {
            
        }

        public Sinhvien(string maSinhVien, string ten, int namSinh, double diem)
        {
            this.MaSinhVien = maSinhVien;
            this.Ten = ten;
            this.NamSinh = namSinh;
            this.Diem = diem;
        }

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }

        public virtual void inThongTin()
        {
            
            Console.Write($"MSV: {MaSinhVien}\n" +
                $"Tên: {ten}\n" +
                $"Năm sinh: {NamSinh} \n" +
                $"Điểm: {diem}\n");
        }
    }
}
