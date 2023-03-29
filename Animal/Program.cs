/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте класс хвост, который содержит в себе поля длину хвоста
типа int и вид хвоста типа string, создать свойства доступа и конструктор пользовательский
класса. Создать класс хвостатое животное, содержащий хвост, цвет(строка), возраст. Определить
public - производный класс собака, имеющий дополнительный параметр-кличку (строка).
В классе собака создать метод для отображения полной информации о собаке.
*/

Dog dog = new("Jack", 2, "серый", "длинный", 10);
dog.ShowDogInfo();

Console.ReadKey();
public class Tail
{
    public int TailLength { get; set; }
    public string TailType { get; set; }
    public Tail(int tailLength, string tailType)
    {
        TailLength = tailLength;
        TailType = tailType;
    }
}
public class TailedAnimal : Tail
{
    public int Age { get; set; }
    public string Color { get; set; }
    public TailedAnimal(int tailLength, string tailType, int age, string color) : base(tailLength, tailType)
    {
        Age = age;
        Color = color;
    }
    
}

public class Dog : TailedAnimal
{
    public string Name { get; set; }
    public Dog(string name, int age, string color, string tailType, int tailLength) : base(tailLength, tailType, age, color)
    {
        Name = name;
    }
    public void ShowDogInfo()
    {
        Console.WriteLine("Информация о собаке:");
        Console.WriteLine($"Кличка: {Name}");
        Console.WriteLine($"Возраст: {Age} года");
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Вид хвоста - {TailType}");
        Console.WriteLine($"Длина хвоста - {TailLength} см.");
    }
}

