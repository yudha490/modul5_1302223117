// See https://aka.ms/new-console-template for more information
public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic angka1 = a;
        dynamic angka2 = b;
        dynamic angka3 = c;

        dynamic hasil = angka1 + angka2 + angka3;

        Console.WriteLine(hasil);
    }
}

public class SimpleDataBase<T, Date>
{ 
    public T storedData { get; set; }
    public Date inputDates { get; set; }
    public SimpleDataBase(T data) 
    {
        storedData = data;
    }

    public void AddNewData<T>(T data)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        penjumlahan.JumlahTigaAngka<int>(13, 02, 22);
    }
}
