// See https://aka.ms/new-console-template for more information
//Car adında bir class oluşturunuz. Marka, model, motor gücü, renk, vitestipi

//Car car = new Car();
//car.Marka = "Mercedes";
//car.Renk = "Lacivert";
//car.Model = "2023";
//car.MotorGucu = 180;
//car.VitesTipi = "Otomatik";

//Console.WriteLine(car.Marka);
//car.EkranaYaz();
//class Car
//{
//    public string Marka;
//    public string Renk;
//    public string Model;
//    public int MotorGucu;
//    public string VitesTipi;

//    public void EkranaYaz()
//    {
//        Console.WriteLine(Marka);
//        Console.WriteLine(Renk);
//        Console.WriteLine(Model);
//        Console.WriteLine(MotorGucu);
//        Console.WriteLine(VitesTipi);

//    }
//}

Console.WriteLine("---------------House Class---------------------------");


//House house = new House();
//house.Kat = 13;
//house.ApartmanAdi = "Lacivert";
//house.Ucret = 25000;
//house.OdaSayisi = 3;
//house.SalonSayisi = 1;

//house.EkranaYaz();
//class House
//{
//    public int Kat;
//    public string ApartmanAdi;
//    public int Ucret;
//    public int OdaSayisi;
//    public int SalonSayisi;

//    public void EkranaYaz()
//    {
//        Console.WriteLine($"Kat: {Kat}");
//        Console.WriteLine($"Apartman Adı: {ApartmanAdi}");
//        Console.WriteLine($"Ücret: {Ucret}");
//        Console.WriteLine($"Oda Sayısı: {OdaSayisi}");
//        Console.WriteLine($"Salon sayısı: {SalonSayisi}");

//    }
//}

//İkinci Yöntem

//Car car1 = new();
//car1.Marka = "Mercedes";
//car1.Renk = "Lacivert";
//car1.Model = "2023";
//car1.MotorGucu = 180;
//car1.VitesTipi = "Otomatik";

//Console.WriteLine(car1.Marka);
//car1.EkranaYaz();
//class Car
//{
//    public string Marka;
//    public string Renk;
//    public string Model;
//    public int MotorGucu;
//    public string VitesTipi;

//    public void EkranaYaz()
//    {
//        Console.WriteLine(Marka);
//        Console.WriteLine(Renk);
//        Console.WriteLine(Model);
//        Console.WriteLine(MotorGucu);
//        Console.WriteLine(VitesTipi);

//    }
//}

//Üçüncü Yöntem

//Car car1 = new();
//Marka = "Mercedes";
//Renk = "Lacivert";
//Model = "2023";
//MotorGucu = 180;
//VitesTipi = "Otomatik";

//Console.WriteLine(car1.Marka);
//car1.EkranaYaz();
//class Car
//{
//    public string Marka;
//    public string Renk;
//    public string Model;
//    public int MotorGucu;
//    public string VitesTipi;

//    public void EkranaYaz()
//    {
//        Console.WriteLine(Marka);
//        Console.WriteLine(Renk);
//        Console.WriteLine(Model);
//        Console.WriteLine(MotorGucu);
//        Console.WriteLine(VitesTipi);

//    }
//}

Car car = new Car("Mercedes", "Kırmızı", 2024, 200, "Otomatik");
car.EkranaYaz();
Console.WriteLine("---------------------------------------------");
CarManager manager = new CarManager();
manager.Update(car);
Console.WriteLine("------------------------------------------");

class Car
{
    public string Marka;
    public string Renk;
    public int Model;
    public int MotorGucu;
    public string VitesTipi;
    public Car()
    {
        Console.WriteLine("Yapıcı blok çalıştı.");
    }
    public Car(string marka, string renk, int model, int motorGucu, string vitesTipi)
    {
        Marka = marka;
        Renk = renk;
        Model = model;
        MotorGucu = motorGucu;
        VitesTipi = vitesTipi;
    }
    public void EkranaYaz()
    {
        Console.WriteLine(Marka);
        Console.WriteLine(Renk);
        Console.WriteLine(Model);
        Console.WriteLine(MotorGucu);
        Console.WriteLine(VitesTipi);

    }
}

//public override string Tostring()
//{

//}

class CarManager
{
    public void Add(Car car)
    {
        if (car.Model<1980)
        {
            Console.WriteLine("Araç min 1900 model olmalıdır.");
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Araç eklendi.");
        car.EkranaYaz();
    }
    public void Update(Car car)
    {
        car.Marka = "BMW";
        car.Renk = "Lacivert";
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Araç Güncellendi.");
        car.EkranaYaz();
    }
    public void Delete(Car car)
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Araç Silindi.");
        car.EkranaYaz();

    }
}

