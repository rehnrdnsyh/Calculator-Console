using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            string input;
            while (true) 
            {
                Console.Clear();
                Console.Title = "Kalkulator Aplikasi";
                Console.WriteLine("Pilihlah Salah Satu");
                Console.WriteLine("[1] Penjumlahan");
                Console.WriteLine("[2] Pengurangan");
                Console.WriteLine("[3] Perkalian");
                Console.WriteLine("[4] Pembagian");
                Console.WriteLine("[5] Keluar");

                Console.Write("Masukan Pilihan: ");
                input = Console.ReadLine();
                int pilihan;
                if (int.TryParse(input, out pilihan) && pilihan >= 1 && pilihan <= 5)
                {
                    Console.WriteLine("Pilihan Valid");
                }
                else
                {
                    Console.WriteLine("Pilihan Tidak Valid");
                    Console.ReadKey();
                    continue;
                }
                switch (input[0])
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.Write("Mark a: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Mark b: ");
                            int b = int.Parse(Console.ReadLine());
                            int hasil = a + b;
                            Console.WriteLine("Hasil Dari " + a + " + " + b + " = " + hasil);
                            Console.ReadKey();
                            break;

                        }              
                    case '2':
                        {
                            Console.Clear();
                            Console.Write(" Mark a: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write(" Mark b: ");
                            int b = int.Parse(Console.ReadLine());
                            int hasil = a - b;
                            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, hasil);
                            Console.ReadKey();
                            break;
                        }
                        
                    case '3':
                        { 
                            Console.Clear();
                            Console.Write(" Nilai a: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write(" Nilai b: ");
                            int b = int.Parse(Console.ReadLine());
                            int hasil = a * b;
                            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, hasil);
                            Console.ReadKey(); 
                            break;
                        }
                        
                    case '4':
                        {
                            Console.Clear();
                            Console.Write("Nilai a: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Nilai b: ");
                            int b = int.Parse(Console.ReadLine());
                            int hasil = a / b;
                            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, hasil);
                            Console.ReadKey();
                            break;
                        }
                       
                    case '5':
                        return;
                    default:
                        Console.WriteLine("Pilihan Tidak Ada");
                        Console.ReadKey();
                        break;
                }
            
            
            }
        }
    }
}