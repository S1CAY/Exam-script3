using System;

public class Product
{
    public static int ProductCount { get; private set; } = 0;
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        ProductCount++;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Total Products Created: {ProductCount}");
    }
}

public class ElectronicProduct : Product
{
    public int WarrantyPeriod { get; set; }

    public ElectronicProduct(string name, decimal price, int warrantyPeriod)
        : base(name, price)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Warranty Period: {WarrantyPeriod} months");
    }
}

public class ClothingProduct : Product
{
    public string Size { get; set; }

    public ClothingProduct(string name, decimal price, string size)
        : base(name, price)
    {
        Size = size;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Size: {Size}");
    }
}


public class Program
{
    public static void Main()
    {
        Product prod1 = new Product("Generic Product", 19.99m);
        prod1.DisplayInfo();
        Console.WriteLine();

        ElectronicProduct eProd1 = new ElectronicProduct("Smartphone", 499.99m, 24);
        eProd1.DisplayInfo();
        Console.WriteLine();

        ClothingProduct cProd1 = new ClothingProduct("T-Shirt", 29.99m, "L");
        cProd1.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine($"Total Products Created: {Product.ProductCount}");
    }
}
