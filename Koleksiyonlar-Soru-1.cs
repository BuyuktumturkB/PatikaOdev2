Collection asallar=new Collection();
Collection asaldegil=new Collection();
int input = 0,sayi,sayac=0,a=1,b=1;
while (input < 20) 
{
	Console.Write("Sayı Giriniz");
	sayi=Convert.ToInt32(Console.ReadLine());
	for (int i = 2; i < sayi; i++)
	{
		if (sayi % i == 0)
		{
			sayac++;
		}
	}
	if (sayac == 0)
	{
		asallar.Add(sayi);
	}
	else
	{
		asaldegil.Add(sayi);
	}
	input++;

}
Console.WriteLine("Asallar");
for (a = 1; a < asallar.Count; a++) { Console.Write(asallar[a]); }
Console.WriteLine("Asal Olmayanlar:");
for (b = 1; b < asaldegil.Count; b++) { Console.Write( asaldegil[b]); }
