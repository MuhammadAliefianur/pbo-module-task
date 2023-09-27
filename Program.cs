using System;

class Processor
{
    public string Merk;
    public string Tipe;

}

class Intel : Processor
{
    public Intel(string Merk)
    {
        this.Merk = "Intel";
    }
}
class Amd : Processor
{
    public Amd(string Merk)
    {
        this.Merk = "Amd";
    }
}

class Corei3 : Intel
{
    public Corei3() : base("Intel")
    {
        
        Tipe = "Core I3";
    }
}

class Corei5 : Intel
{
    public Corei5() : base("Intel")
    {
        
        Tipe = "Core I5";
    }
}
class Corei7 : Intel
{
    public Corei7() : base("Intel")
    {
        Tipe = "Core I7";
    }
}

class Ryzen : Amd
{
    public Ryzen() : base ("AMD")
    {
        Tipe = "Ryzen";
    }
}

class Athlon : Amd
{
    public Athlon() : base("AMD")
    {
        Tipe = "Athlon";
    }
}



class Laptop
{
    public string Merk;
    public string Tipe;
    public Vga Vga;
    public Processor Processor;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        Merk = merk;
        Tipe = tipe;
        Vga = vga;
        Processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Asus : Laptop
{
    public Asus(string tipe, Vga vga, Processor processor) : base("Asus", tipe, vga, processor)
    {
        Merk = "Asus";
    }
}

class Acer : Laptop
{
    public Acer(string tipe, Vga vga, Processor processor) : base("Acer", tipe, vga, processor)
    {
        Merk = "Acer";
    }
}


class Lenovo : Laptop
{
    public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
    {
        Merk = "Lenovo";
    }
}

class Rog : Asus
{
    public Rog() : base ("ROG", new Nvidia(), new Corei7())
    {
        Tipe = "Rog";
    }
}

class Vivobook : Asus
{
    public Vivobook() : base("Vivobook", new Nvidia(), new Corei5())
    {
        Tipe = "Vivobook";
    }
}

class Swift : Acer
{
    public Swift() : base ("Swift", new Nvidia(), new Corei5())
    {
        Tipe = "Swift";
    }
}

class Predator : Acer
{
    public Predator() : base("Predator", new Amdv(), new Corei7())
    {
        Tipe = "Predator";
    }
}

class Ideapad : Lenovo
{
    public Ideapad() : base("Ideapad", new Amdv(), new Corei5())
    {
        Tipe = "Ideapad";
    }
}

class Legion : Lenovo
{
    public Legion() : base("Legion", new Nvidia(), new Corei7())
    {
        Tipe = "Legion";
    }
}


class Vga
{
    public string Merk;

    public Vga(string Merk)
    {
        this.Merk = Merk;
    }
}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia")
    {
        
    }
}

class Amdv : Vga
{
    public Amdv() : base("Amd")
    {
        
    }
}





class Program
{


    public static void Main()
    {

        //No1
        Laptop Laptop2 = new Ideapad();
        Laptop2.LaptopDinyalakan();
        Laptop2.LaptopDimatikan();

        Console.WriteLine();

        //No2
        Laptop Laptop1 = new Vivobook();
        Laptop1.Ngoding();

        Console.WriteLine();

        //No3
        Console.WriteLine($"Spesifikasi laptop1 ");
        Console.WriteLine($"Merk VGA: {Laptop1.Vga.Merk}");
        Console.WriteLine($"Merk Processor: {Laptop1.Processor.Merk}");
        Console.WriteLine($"Tipe Processor: {Laptop1.Processor.Tipe}");
       
        Console.WriteLine();

        //No4
        Predator Predator = new Predator();
        Predator.BermainGame();

        Console.WriteLine();

        //No5
        Acer acer = new Predator();
        acer.BermainGame();



    }


}