/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте базовый класс Shape (фигура), который содержит в себе
поле типа double c именем Volume и метод типа double GetVolume() который должен вернуть
объём фигуры. Далее создайте классы: Pyramid (пирамида), Cylinder (цилиндр), Ball (шар),
которые будут наследоваться от класса Shape, реализуйте в каждом из них метод для
нахождения объёма. Создайте класс Box (ящик) – он является контейнером, может содержать в
себе другие фигуры. В классе Box создайте поле типа double с именем DrawerVolume (Объем
ящика), поле должно хранить в себе объём ящика. Далее в классе Box создайте метод Аdd(),
который принимает на вход объекты типа Shape, и возвращает значение типа boll. В классе Box
реализуйте логику для добавления новых фигуры до тех пор, пока для них хватает места в Box
(будем считать только объём, игнорируя форму, например, мы переливаем жидкость). Если
места для добавления новой фигуры не хватает, то метод должен вернуть false.
*/

Pyramid pyramid = new() { H = 10, A = 5 };
Cylinder cylinder = new() { H = 10, R = 5 };
Ball ball = new() { R = 10 };

double pyramidVolume = pyramid.GetVolume();
double cylinderVolume = cylinder.GetVolume();
double ballVolume = ball.GetVolume();

Box box = new() { DrawerVolume = 1000 };
bool result = box.Add(pyramidVolume, cylinderVolume, ballVolume);

switch (result)
{
    case true:
        Console.WriteLine("Фигуры успешно добавлены!");
        break;
    case false:
        Console.WriteLine("Для новой фигуры нет места");
        break;
}
Console.ReadKey();
class Shape
{
    public double Volume { get; set; }
    public virtual double GetVolume()
    {
        return Volume;
    }
}
class Pyramid : Shape
{
    public int H { get; set; }
    public int A { get; set; }
    private double volume;
    public override double GetVolume()
    {
        volume = 1/3 * (H*Math.Pow(A,2));
        return volume;
    }
}
class Cylinder : Shape
{
    public int H { get; set; }
    public int R { get; set; }
    private const double PI = Math.PI;
    private double volume;
    public override double GetVolume()
    {
        volume = PI*Math.Pow(R,2)*H;
        return volume;
    }
}
class Ball : Shape
{
    public int R { get; set; }
    private const double PI = Math.PI;
    private double volume;
    public override double GetVolume()
    {
        volume = 4/3 *(PI*Math.Pow(R,3));
        return volume;
    }
}
class Box
{
    public double DrawerVolume { get; set; }
    public bool Add(double pyramidVolume, double cylinderVolume, double ballVolume)
    {
        double[] shapes = { pyramidVolume, cylinderVolume, ballVolume };
        double totalVolume = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                totalVolume += shapes[i];
                if (totalVolume >= DrawerVolume)
                    return false;
            }
        return true;
    }
}