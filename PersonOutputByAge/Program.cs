/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте базовый класс Person (человек), в классе создайте поле
типа int с именем BirthYear (год рождения), поле типа string с именем Name и поле типа
string с именем Surname. Далее создайте классы Student (студент), Teacher (преподаватель). В
классе Student добавьте поле типа string[] с именем Study Courses (изучаемые курсы), свойство
(не авто свойство) для добавления (set) и получения (get) изучаемых курсов и метод
DisplayStudyСourses() с возвращаемым значением void который будет выводить на консоль все
предметы, максимальное количество изучаемых курсов = 3. В классе преподаватель создать поле
типа Student[] с именем StudentsArray, и свойство (не авто свойство) для добавления (set) и
получения (get) студентов. Создайте 5 экземпляров класса типа Student и инициализируйте их
произвольными значениями, и 2 экземпляра класса типа Teacher, инициализируйте их
произвольными значениями (для инициализации поля StudentsArray используйте уже созданные
экземпляры Student). Далее создайте класс PeopleInfo, в нем создайте поле типа Person[] с
именем PeopleArray и свойство (не авто свойство) для добавления (set) и получения (get) людей и
метод который будет выводить всех людей который есть в поле PeopleInfo в порядке возрастания
возраста.
*/

Student student1 = new("Роман", "Мазур", 1995);
Student student2 = new("Кирилл", "Москаленко", 1993);
Student student3 = new("Илона", "Авраменко", 1997);
Student student4 = new("Елена", "Ивченко", 1999);
Student student5 = new("Дмитрий", "Корсун", 1994);

Teacher teacher1 = new("Мария", "Яковлева", 1980);
Teacher teacher2 = new("Виктор", "Радченко", 1975);

student1.StudyCourses = new[] { "C#", "Unity" };
student2.StudyCourses = new[] { "JavaScript", "C#" };
student3.StudyCourses = new[] { "C++", "Kotlin", "Java" };
student4.StudyCourses = new[] { "Python", "React" };
student5.StudyCourses = new[] { "CSS", "SQL", "HTML" };

teacher1.StudentsArray = new[] {student1, student2};
teacher2.StudentsArray = new[] {student3, student4, student5};

PeopleInfo peopleInfo = new();
peopleInfo.PeopleArray = new[] 
{
    teacher1, 
    teacher2, 
    (Person)student1, 
    (Person)student2, 
    (Person)student3,
    (Person)student4,
    (Person)student5
};

peopleInfo.ShowPeopleInfo();

student1.DisplayStudyСourses();
student2.DisplayStudyСourses();
student3.DisplayStudyСourses();
student4.DisplayStudyСourses();
student5.DisplayStudyСourses();

Console.ReadKey();
class Person
{
    public int BirthYear { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}
class Student : Person
{
    private string[] studyCourses;
    public string[] StudyCourses
    {
        get { return studyCourses; }
        set { studyCourses = value; }
    }
    public Student(string name, string surname, int birthYear)
    {
        Name = name;
        Surname = surname;
        BirthYear = birthYear;
    }
    public void DisplayStudyСourses()
    {
        string str = string.Join(", ", studyCourses);
        Console.WriteLine($"Изучаемые курсы студента {Name} {Surname}: {str}");
    }
}
class Teacher : Person
{
    private Student[] studentsArray;
    public Student[] StudentsArray
    {
        get { return studentsArray; }
        set { studentsArray = value; }
    }
    public Teacher(string name, string surname, int birthYear)
    {
        Name = name;
        Surname = surname;
        BirthYear = birthYear;
    }
}
class PeopleInfo
{
    private Person[] peopleArray;
    public Person[] PeopleArray
    {
        get { return peopleArray; }
        set { peopleArray = value; }
    }
    public void ShowPeopleInfo()
    {   
        //Определение возраста каждого человека
        int currentYear = DateTime.Now.Year;
        foreach (var item in peopleArray)
            item.Age = currentYear - item.BirthYear; 
        
        var sortedPeople = peopleArray.OrderBy(p => p.Age);
        foreach (var p in sortedPeople)
            Console.WriteLine($"Имя:\t {p.Name} \nФамилия: {p.Surname} \nВозраст: {p.Age}\n");
    }
}