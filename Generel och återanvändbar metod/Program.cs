
int tal;
while(!int.TryParse(Console.ReadLine(),out tal))
{
    Console.WriteLine("Ange ett tal");
}
return tal;
Console.ReadLine();