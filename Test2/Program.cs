// See https://aka.ms/new-console-template for more information



int a;
int i = 0;
string x = "a";


Değer:
try
{
    if (i < 100)
    {
        int y = int.Parse(x);
    }
   
    else
    {
        a = 1; 
    }
       


}
catch
{
   
    Console.WriteLine("For kullanmadım.");
    i++;

    goto Değer;
}