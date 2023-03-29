/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется: Создать класс, представляющий учебный класс ClassRoom. Создайте класс ученик
Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void Relax(). Создайте 3
производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и
переопределите каждый из методов, в зависимости от успеваемости ученика. Конструктор
класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. Выведите
информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать,
отдыхать.
*/

ExcelentPupil excelentPupil = new();
GoodPupil goodPupil = new();
BadPupil badPupil = new();

ClassRoom classRoom = new(excelentPupil, goodPupil, badPupil);
classRoom.ShowInfo();
class ClassRoom
{
    Pupil[] pupils;
    public ClassRoom(Pupil p1)
    {
        pupils = new Pupil[] { p1 };
    }
    public ClassRoom(Pupil p1, Pupil p2)
    {
        pupils = new Pupil[] { p1, p2 };
    }
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
    {
        pupils = new Pupil[] { p1, p2, p3 };
    }
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
    {
        pupils = new Pupil[] { p1, p2, p3, p4 };
    }
    public void InfoStudy()
    {
        Console.WriteLine("Как учатся наши ученики: ");
        foreach (Pupil item in pupils)
            item.Study();
    }
    public void InfoRead()
    {
        Console.WriteLine("Как читают наши ученики: ");
        foreach (Pupil item in pupils)
            item.Read();
    }
    public void InfoWrite()
    {
        Console.WriteLine("Как пишут наши ученики: ");
        foreach (Pupil item in pupils)
            item.Write();
    }
    public void InfoRelax()
    {
        Console.WriteLine("Как отдыхают наши ученики: ");
        foreach (Pupil item in pupils)
            item.Relax();
    }
    public void ShowInfo()
    {
        InfoStudy();
        InfoRead();
        InfoWrite();
        InfoRelax();
    }
}
class Pupil
{
    public virtual void Study()
    {
        //Console.WriteLine("Я учусь");
    }
    public virtual void Read()
    {
       // Console.WriteLine("Я читаю");
    }
    public virtual void Write()
    {
        //Console.WriteLine("Я пишу");
    }
    public virtual void Relax()
    {
        //Console.WriteLine("Я отдыхаю");
    }
}
class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Я отлично учусь!");
    }
    public override void Read()
    {
        Console.WriteLine("Я отлично читаю!");
    }
    public override void Write()
    {
        Console.WriteLine("Я отлично пишу!");
    }
    public override void Relax()
    {
        Console.WriteLine("Я отлично отдыхаю!");
    }
}
class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Я хорошо учусь");
    }
    public override void Read()
    {
        Console.WriteLine("Я хорошо читаю");
    }
    public override void Write()
    {
        Console.WriteLine("Я хорошо пишу");
    }
    public override void Relax()
    {
        Console.WriteLine("Я хорошо отдыхаю");
    }
}
class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Я плохо учусь...");
    }
    public override void Read()
    {
        Console.WriteLine("Я плохо читаю...");
    }
    public override void Write()
    {
        Console.WriteLine("Я плохо пишу...");
    }
    public override void Relax()
    {
        Console.WriteLine("Я плохо отдыхаю...");
    }
}