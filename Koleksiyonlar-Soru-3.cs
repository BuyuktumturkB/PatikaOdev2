using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
string cümle=""; 
ArrayList sesliharf=new ArrayList();
Console.WriteLine("Cümle Giriniz");
 while (cümle!="Ğ") 
{
	cümle = Console.ReadLine();
	if ((cümle == "A") || (cümle == "E") || (cümle == "I") || (cümle == "O") || (cümle == "U") || (cümle == "İ") || (cümle == "Ö") || (cümle == "Ü"))
	{
		sesliharf.Add(cümle);
	}
	else if (cümle == "Ğ")
		break;
}

Console.WriteLine("Sesli Harfler: ");
for (int i = 0; i < sesliharf.Count; i++) 
{
	Console.Write(sesliharf[i]);
}
