int [] sayılar= new int[20];
int [] buyukler=new int[3];
int [] kucukler=new int[3];
Console.Write("Sayı Giriniz");
int counter = 0;
while(counter<20)
{
	int input = Convert.ToInt32(Console.ReadLine());
	sayılar[counter] = input;
}

Array.Sort(sayılar);

for (int i = 0; i < 3; i++) 
{
	buyukler[i] = sayılar[i];
}
for (int j = 0; j < 3; j++)
{
	int y= 20;
	buyukler[j] = sayılar[y];
	y--;
}
int ort1 = (buyukler[0] + buyukler[1] + buyukler[2])/3;
int ort2 = (kucukler[0] + kucukler[1] + kucukler[2]) / 3;
int toplanm = ort1 + ort2;
Console.WriteLine("Ortalamalar Toplamı= " + toplanm);
