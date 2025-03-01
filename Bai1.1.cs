using System;

namespace TinhTienDien
{
    class Program
    {
        // Khai báo các hằng 
        const int Muc1=100, Muc2=150, Muc3=300;
        const int Gia1=2000, Gia2=2500, Gia3=3000;

        static void Main()
        {
            int sokWh=0;
            double sotien=0;

            int sokWh=0;
            double sotien=0;
            sokWh=int.Parse(Console.ReadLine());
            if (sokWh <= Muc1){
                sotien=sokWh*Gia1;
            }
            else if (sokWh>Muc1 && sokWh<=Muc2){
                sotien = sokWh*Gia2;
            }
            else if (sokWh>Muc2 && sokWh<=Muc3){
                sotien=sokWh*Gia3;
            }
            else{
                sotien=(sokWh*Gia3)+((sokWh*Gia3)*(10.0/100));
            }
            Console.WriteLine("So tien: {0}",sotien);
        }
    }
}