using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN2_talitazakiyatulm_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("=== PROGRAM MENGHITUNG INDEKS MASSA TUBUH (IMT) ===");

          // Input data
          Console.Write("Masukkan berat badan (kg): ");
          double berat = Convert.ToDouble(Console.ReadLine());

          Console.Write("Masukkan tinggi badan (meter): ");
          double tinggi = Convert.ToDouble(Console.ReadLine());

          // Rumus IMT
          double imt = berat / (tinggi * tinggi);

          // Menentukan kategori
          string kategori;
          if (imt < 18.5)
          {
            kategori = "Kurus";
          }
          else if (imt >= 18.5 && imt <= 24.9)
          {
            kategori = "Normal";
          }
          else if (imt >= 25 && imt <= 29.9)
          {
             kategori = "Kelebihan berat badan";
          }
          else
          {
              kategori = "Obesitas";
          }

           // Output hasil
           Console.WriteLine($"\nIndeks Massa Tubuh (IMT) Anda = {imt:F2}");
           Console.WriteLine($"Kategori: Berat badan {kategori}");
           Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
            
        
         }
    }
}
