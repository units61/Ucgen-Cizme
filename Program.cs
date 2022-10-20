
Console.WriteLine("Üçgeni oluşturmak için boyu bilgisi giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());

for(int a=0;a<sayi;a++)
{				
    for(int b=0;b<=a;b++)
    {
	    Console.Write("*");		
	}
		Console.Write("\n");
}
				