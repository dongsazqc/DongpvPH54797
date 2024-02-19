using System.Text;

namespace DongpvPH54797
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
        }
        static void Menu()
        {
            SinhVienService sinhVienService = new SinhVienService();
            
            do
            {
                int n;
                Console.WriteLine("Quản lí sinh viên tham gia HappyBee");
                Console.WriteLine("1.Nhập 1 danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Xuất các danh sách được tặng vé HappyBee");
                Console.WriteLine("4.Xóa những sinh viên không được tham gia HappyBee");
                Console.WriteLine("5.Kế thừa");
                Console.WriteLine("0.Thoát");
                Console.Write("Mời bạn chọn 1 trong số chức năng: ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        sinhVienService.Nhap();

                        break;
                    case 2:
                        sinhVienService.Xuat();

                        break;
                    case 3:
                        sinhVienService.Vefree();

                        break;
                    case 4:
                        sinhVienService.Xoa();

                        break;
                    case 5:
                        Console.Write("Nhập MSV: ");
                        string a = Console.ReadLine();
                        Console.Write("Nhập Tên: ");
                        string b = Console.ReadLine();
                        Console.Write("Nhập năm sinh: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhập điểm: ");
                        float d = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Nhập kì học hiện tại: ");
                        int e = Convert.ToInt32(Console.ReadLine());
                        SinhvienUD sinhvienUD = new SinhvienUD(a,b,c,d,e);
                        Console.WriteLine("Thông tin sinh viên là");
                        sinhvienUD.inThongTin();
                        break;
                    case 0:
                        Console.WriteLine("Bạn đã thoát khỏi chương trình");
                        Console.WriteLine("Nhấn phím bất kì để thoát");
                        Environment.Exit(0);
                        break;
                }

            }while (true);
        }
    }
}
