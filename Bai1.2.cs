/*
Viết chương trình nhập từ bàn phím hai số nguyên a, b và một ký tự ch.
Nếu:
- ch là "+" thì thực hiện phép tính a + b và in kết quả lên màn hình.
- ch là "–" thì thực hiện phép tính a - b và in kết quả lên màn hình.
- ch là "*" thì thực hiện phép tính a * b và in kết quả lên màn hình.
- ch là "/" thì thực hiện phép tính a / b và in kết quả lên màn hình. 
Lưu ý kiểm tra điều kiện của phép chia. Nếu b == 0 thì in ra thông báo "Error!"
*/

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            char phepToan;
            double ketQua=0;
            
            // Input: Không thay đổi phần này
            Console.Write("Nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap phep toan (+,-,*,/): ");
            phepToan = char.Parse(Console.ReadLine());

         switch(ch){
             case '+':
             Console.WriteLine($"ket qua cua {a} + {b} la {a + b});
             break;
             case '-':
             Console.WriteLine($"ket qua cua {a} - {b} la {a - b});
             break;
             case '*':
             Console.WriteLine($"ket qua cua {a} * {b} la {a * b});
             break;
             case '/':
             if(b!=0){
                 Console.WriteLine($"ket qua cua {a} / {b} la ((double)a / b));
             }
            else{
                Console.WriteLine("Khong chia het cho 0");
                break;
            }
            default:
            Console.WriteLine("Phep tinh khong hop le ");
            break;
         }
         Console.WriteLine();

            

        }
    }
}
