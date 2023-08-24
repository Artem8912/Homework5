Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
void Bee_line(double b, double k,double b3, double k3)
{
    double x = (b3 -b)/(k-k3);
    double y = k* x + b;
    
    Console.WriteLine($"({x};{y})");
}
Bee_line(b1,k1,b2,k2);