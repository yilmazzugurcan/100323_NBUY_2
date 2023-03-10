using System;

namespace _100323_NBUY_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ticari t1 = new ticari();
            t1.marka = "volvo";
            t1.model = "b450";
            t1.yakit = "dizel";
            t1.renk = "beyaz";
            t1.motorGucu = 3.5;
            t1.dorse1 = "havuz";

            binek b1 = new binek();
            b1.marka = "mercedes";
            b1.model = "e220";
            b1.renk = "siyah";
            b1.motorGucu = 2.2;
            b1.yakit = "benzin";

            Console.WriteLine("Ticari Arac Bilgileri:" + "\n" + t1.marka + "\n" + t1.model + "\n" + t1.yakit + "\n" + t1.renk + "\n" + t1.motorGucu + "\n" + t1.dorse1 + " kasa");
            Console.WriteLine();
            Console.WriteLine("Binek Arac Bilgileri:" + "\n" + b1.marka + "\n" + b1.model + "\n" + b1.yakit + "\n" + b1.renk + "\n" + b1.motorGucu + "\n" + b1.sz1() + "\n");

            #region araba miras alma farklı çözüm
            /*  static void Main(string[] args)
     {

         Bus bus = new Bus();            
         bus.Plaka = "34ZM4850";
         bus.Brand = "Mercedes";
         bus.Model = "CLK";
         bus.GearType = "Manuel";
         bus.Color = "White";
         bus.DateOfProduction = new DateTime(2020, 08, 03);
         bus.FuelType = "Diesel";
         bus.Capasity = "17";
         Console.WriteLine("Bus information\n");
         bus.ShowInfo();
         Console.WriteLine("-------------------------------");
         Track track = new Track();
         track.Plaka = "34KS4890";
         track.Brand = "Mercedes";
         track.Model = "CLM";
         track.GearType = "Automatic";
         track.Color = "Black";
         track.DateOfProduction = Convert.ToDateTime(new DateTime(2019, 03, 03));
         track.FuelType = "Diesel";
         track.Capasity = "10T";
         Console.WriteLine("Track information\n");
         track.ShowInfo();
         Console.WriteLine("------------------------------");

         Console.ReadLine();
     }
}

 public class Car
 {
     public string Plaka { get; set; }
     public string Color { get; set; }
     public string GearType { get; set; }
     public string FuelType { get; set; }
     public string Brand { get; set; }
     public string Model { get; set; }
     public DateTime DateOfProduction { get; set; }

     public void ShowInfo()
     {
         Console.WriteLine("Brand : "+Brand+"\nModel : "+Model+"\nColor : "+Color+"\nGear Type : "+GearType+"\nFuel Type : "+FuelType+"\nDate of production : "+DateOfProduction+"\nPlaka : "+Plaka);
     }
 }
 public class Track :Car
 {
     public string Capasity { get; set; }

     public void ShowInfo()
     {
         Console.WriteLine("Brand : " + Brand + "\nModel : " + Model + "\nColor : " + Color + "\nGear Type : " + GearType + "\nFuel Type : " + FuelType + "\nDate of production : " + DateOfProduction + "\nPlaka : " + Plaka+ "\nCapasity : " + Capasity);
     }
 }
 public class Bus : Car
 {
     public string Capasity { get; set; }
     public void ShowInfo()
     {
         Console.WriteLine("Brand : " + Brand + "\nModel : " + Model + "\nColor : " + Color + "\nGear Type : " + GearType + "\nFuel Type : " + FuelType + "\nDate of production : " + DateOfProduction + "\nPlaka : " + Plaka + "\nCapasity : " + Capasity);
     }
 }     */
            #endregion

            #region access modifiers
            /* Access Modifiers- Erişim belirleyiciler
                 * private : kişisel sadece bulunduğu yapı içerisinde erişilebilir başka yerden erişilemez
                 * 
                 *Internal : Bulunduğu projede içerisinden her yerden erişim sağlar farklı projeden erişime izin vermez
                 *
                 *Protected : Miras alınan sınıflardan erişime izin verir
                 *
                 *Protected Internal hem miras alına sınıflar içerisinden hem de proje içerisinden her yerden ulaşılabilir.
                 *
                 *Public Umumi kamu malı genel. her şekilde her yerden erişime izin verir

                 */ 
            #endregion





        }
    }
}
