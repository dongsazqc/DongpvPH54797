using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongpvPH54797
{
    internal class SinhVienService
    {
        List<Sinhvien> sinhviens = new List<Sinhvien>();



        public string Input(string input)
        {
            Console.Write($"{input}");
            input = Console.ReadLine();
            return input;
        }

        internal void Nhap()
        {
            string n;
            do
            {
                
                Console.WriteLine("Mời bạn nhập danh sách các đối tượng");
                Sinhvien sinhvien = new Sinhvien();
                sinhvien.MaSinhVien = Input("Mời bạn nhập MSV: ");
                sinhvien.Ten = Input("Mời bạn nhập tên: ");
                sinhvien.NamSinh = int.Parse(Input("Mời bạn nhập năm sinh: "));
                sinhvien.Diem = int.Parse(Input("Mời bạn nhập điểm: "));
                sinhviens.Add(sinhvien);
                Console.WriteLine("Bạn có muốn nhập thêm 1 đối tượng sinh viên không: ");
                Console.WriteLine("1. Có");
                Console.WriteLine("2. Không");
                 n = Console.ReadLine();
            } while (n == "1" || n == "Có" || n == "có");
        }

        internal void Xuat()
        {
            foreach(var sinhvien in sinhviens) 
            {
                sinhvien.inThongTin();

            }
        }
        internal void Vefree()
        {
            foreach(var sinhvien in sinhviens)
            {
                if(sinhvien.Diem >= 8)
                {
                    sinhvien.inThongTin();
                }
                else
                {
                    Console.WriteLine("Không có sinh viên nào có điểm lớn hơn 8");
                }
            }
        }


        //internal void Xoa() // Cách 1 dùng for
        //{


        //   for(int i = 0; i < sinhviens.Count; i++) 
        //    {
        //        var sinhvien = sinhviens[i];
        //        if (2024 - sinhvien.NamSinh >= 25)
        //        {

        //            sinhviens.Remove(sinhvien);
        //            Console.WriteLine($"có {sinhviens.Count} lớn hơn 25 tuổi");
        //            sinhvien.inThongTin();
        //            i--; // mỗi sau khi xóa 1 phần tử thì các phần tử sau đó sẽ chèn lên phần tử xóa nên cần giảm i đi 1 để không bị bỏ qua 1 số phần tử
        //        }


        //    }


        //}
        internal void Xoa() // Cách 2 dùng foreach
        {
            List<Sinhvien> sinhviencanxoa = new List<Sinhvien>(); // tạo 1 danh sách để lưu sinh viên cần xóa
            foreach(var sinhvien in sinhviens)
            {
                if(2024 - sinhvien.NamSinh >= 25)
                {
                    sinhviencanxoa.Add(sinhvien);    
                }
            }
            foreach(var sinhvien in sinhviencanxoa)
            {
                Console.WriteLine($"Có {sinhviencanxoa.Count} sinh viên lớn hơn 25");
                Console.WriteLine("Danh sách những sinh viên cần xóa ");
                sinhvien.inThongTin();
                sinhviens.Remove(sinhvien); 
            }
        }

        
    }
}
