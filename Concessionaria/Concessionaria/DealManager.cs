using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    class DealManager
    {
        internal static void ShowVehicles()
        {
            List<Vehicles> veichles = vehiclesRepository.Fetch();
             
        }

        internal static void ShowMoto()
        {
            List<Bike> bike = bikeRepository.Fetch();
            foreach (var bike in bike)
            {
                Console.WriteLine(Cars.Print());
            }
        }

        internal static void ShowAuto()
        {
            static List<Cars> Fetch();
        }

        internal static void ShowBus()
        {
            List<Bus> Fetch();
        }

        internal static void AddVehicles()
        {

            Console.WriteLine("Inserisci Nuovo Veicolo: Auto, Moto o Pulmino");

            string sceltaveicolo = Console.ReadLine();

            switch (sceltaveicolo)
            {
                case "Auto":
                    Console.WriteLine("Inserisci Modello Auto");

                    string NewCar = Console.ReadLine();

                    bool ExistModCars = cars.Any(car => car.Modello == NewCar);
                    if (ExistModCars)
                    {
                        Console.WriteLine("Il modello esiste già");

                    }
                    Console.WriteLine("Inserisci la Marca");
                    string NewCarBrand = Console.ReadLine();

                    Console.WriteLine("Inserisci le Porte");
                    string NewCarSeats = Console.ReadLine();

                    break;
           

                case "Moto":
                    Console.WriteLine("Inserisci Modello Moto");

                    string NewBike = Console.ReadLine();

                    bool ExistModBike = bike.Any(bike => bike.Modello == NewBike);
                    if (ExistModBike)
                    {
                        Console.WriteLine("Il modello esiste già");

                    }
                    Console.WriteLine("Inserisci la Marca");
                    string NewBikeBrand = Console.ReadLine();

                    Console.WriteLine("Inserisci Anno di Produzione");
                    string NewCarYear = Console.ReadLine();

                    break;

                case "Pulmino":
                    Console.WriteLine("Inserisci Modello Pulmino");

                    string NewBus = Console.ReadLine();

                    bool ExistModBus = bus.Any(bus => bus.Modello == NewBus);
                    if (ExistModBus)
                    {
                        Console.WriteLine("Il modello esiste già");

                    }
                    Console.WriteLine("Inserisci la Marca");
                    string NewBusBrand = Console.ReadLine();

                    Console.WriteLine("Inserisci Numero di Posti");
                    string NewBusSeats = Console.ReadLine();

                    break;
 

            }

        }

        internal static void SellVehicles()
        {
            throw new NotImplementedException();
        }
    }
}
