using System;
using System.Collections.Generic;
using System.Text;

namespace ArabaSon
{
    class ArabaSon
    {
        
            string carmodel;
            string carSpeed;
            string carPrice;
            string carGear;
            string model1;
            string colour1;
            string gear1;
            bool sunroof;
            int maxspeed1;
            int price1;
            string sunroofOzelligi;




            public void getdata()
            {
                Console.WriteLine("Lütfen arabanizin modelini giriniz: ");
                string carmodel = Console.ReadLine();
                string dizi = carmodel;
                model1 = dizi;

                Console.WriteLine("Lütfen arabanizin rengini giriniz: ");
                string carColour = Console.ReadLine();
                string dizi1 = carColour;
                colour1 = (dizi1);

                Console.WriteLine("Lütfen arabanizin vites ozelligini giriniz: ");
                string carGear = Console.ReadLine();
                string dizi2 = carGear;
                gear1 = (dizi2);
               
                Console.WriteLine("Lütfen arabanizin maksimum hızını giriniz(km/h): ");
                string carSpeed = Console.ReadLine();              
                maxspeed1 = int.Parse(carSpeed);

                Console.WriteLine("Lütfen arabanizin fiyatini giriniz($): ");
                string carPrice = Console.ReadLine();
                string dizi4 = carPrice;
                price1 = int.Parse(dizi4);

                Console.WriteLine("Lütfen arabanizin sunroof özelligini giriniz v(var) & y(yok): ");
                string sunroofOzelligi= Console.ReadLine();
            if (sunroofOzelligi.ToLower().Equals("v"))
            {
                sunroof = true;
            }
            else
            {
                sunroof = false;
            }
               
        }


        public void yaz()
        {

            Console.WriteLine("\n--- Arabanizin ozellikleri asagıdaki gibidir. ---\n");
            if (sunroof){
                Console.WriteLine("Arabanizin modeli: " + model1 + ", " + "Arabanizin rengi: " + colour1 + ", " + "Arabanizin vites durumu: " + gear1 + ", " + "Arabanizin maksimum hizi: " + maxspeed1 + "km/h" + ", " + "Arabanizin fiyati: " + price1 + "$" + ", " + "Sunroof: Var " );
            }
            else
            {
                Console.WriteLine("Arabanizin modeli: " + model1 + ", " + "Arabanizin rengi: " + colour1 + ", " + "Arabanizin vites durumu: " + gear1 + ", " + "Arabanizin maksimum hizi: " + maxspeed1 + "km/h" + ", " + "Arabanizin fiyati: " + price1 + "$" + ", " + "Sunroof: Yok ");
            }
                       
        }
    }
    }


