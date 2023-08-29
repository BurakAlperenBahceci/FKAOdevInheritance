class Hayvan
{
    public string Isim { get; set; }
    public int Yas { get; set; }
    public string Tur { get; set; }

    public Hayvan(string isim, int yas, string tur)
    {
        this.Isim = isim;
        this.Yas = yas;
        this.Tur = tur;
    }

    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan sesi.");
    }
}

class Kopek : Hayvan
{
    public Kopek(string isim, int yas)
        : base(isim, yas, "Köpek")
    {
    }

    public override void SesCikar()
    {
        Console.WriteLine("Haauuuuwwwwww !");
    }
}

class Kus : Hayvan
{
    public Kus(string isim, int yas)
        : base(isim, yas, "Kuş")
    {
    }

    public override void SesCikar()
    {
        Console.WriteLine("pırrr pırrrrr!");
    }
}

class Kedi : Hayvan
{
    public Kedi(string isim, int yas)
        : base(isim, yas, "Kedi")
    {
    }

    public override void SesCikar()
    {
        Console.WriteLine("ddoooooouuudddd!!! ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hayvan[] hayvanlar = {
            new Kopek("Doberman", 2),
            new Kus("Maşukkkk", 1),
            new Kedi("Müezzzaaaa", 6)
        };

        foreach (var hayvan in hayvanlar)
        {
            Console.WriteLine($"{hayvan.Isim} ({hayvan.Tur}, {hayvan.Yas} yaş) diye ses çıkarır: ");
            hayvan.SesCikar();
        }
    }
}