//1
//public static class Program
//{
//    public static void Main(string[] args)
//    {
//        Animal animal1 = new Animal("Spark", "male", "black-white", 2);
//        animal1.GetDetails();
//    }
//}
//public class Animal
//{
//    public string name;
//    public string breed;
//    public string color;
//    public int age;
//    public Animal(string name, string breed, string color, int age)
//    {
//        this.name = name;
//        this.breed = breed;
//        this.color = color;
//        this.age = age;
//    }
//    public void GetDetails()
//    {
//        Console.WriteLine($"{name} {breed} {color} {age}");
//    }
//}

//2
//public static class Program
//{
//    public static void Main(string[] args)
//    {
//        Building building1 = new Building("Eiffel", 300, 125, "Paris");
//        building1.GetDetails();
//    }
//}
//public class Building
//{
//    public string name;
//    public int height;
//    public int area;
//    public string adress;
//    public Building(string name, int height, int area, string adress)
//    {
//        this.name = name;
//        this.height = height;
//        this.area = area;
//        this.adress = adress;
//    }
//    public int FindCapacity()
//    {
//        return height * area;
//    }

//    public void GetDetails()
//    {
//        int capacity = FindCapacity();
//        Console.WriteLine($"{name} {height} {area} {adress} {capacity}");
//    }
//}

//3
//public static class Program
//{
//    public static void Main(string[] args)
//    {
//        Student student1 = new Student("Musa", "Musayev", 19, [89, 74, 90, 78, 89], [89,79,94,100], [98, 95, 89, 100], 96, [true,true,false,true,true,true,true,true,false]);
//        student1.GetDetails();
//    }
//}
//public class Student
//{
//    public string name;
//    public string surname;
//    public int age;
//    public int[] homeworkGrades;
//    public int[] projectGrades;
//    public int[] quizGrades;
//    public int finalGrade;
//    public bool[] continuity;
//    public Student(string name, string surname, int age, int[] homeworkGrades, int[] projectGrades, int[] quizGrades, int finalGrade, bool[] continuity)
//    {
//        this.name = name;
//        this.surname = surname;
//        this.age = age;
//        this.homeworkGrades = homeworkGrades;
//        this.projectGrades = projectGrades;
//        this.quizGrades = quizGrades;
//        this.finalGrade = finalGrade;
//        this.continuity = continuity;
//    }
//    public int GetAverage(int[] Grades)
//    {
//        int count = 0;
//        foreach (int Grade in Grades)
//        {
//            count += Grade;
//        }
//        return count / Grades.Length;
//    }
//    public int GetContinuityGrade(bool[] continuity)
//    {
//        int count = 0;
//        if (true)
//            count++;
//        return count / continuity.Length * 100;
//    }
//    public int FinalResult()
//    {
//        return (20 * GetAverage(homeworkGrades)) / 100 +
//               (20 * GetAverage(projectGrades)) / 100 +
//               (20 * GetAverage(quizGrades)) / 100 +
//               (10 * GetContinuityGrade(continuity)) / 100 +
//               (30 * finalGrade) / 100;
//    }
//    public void GetDetails()
//    {
//        int result = FinalResult();
//        if (FinalResult() >= 95)
//        {
//            Console.WriteLine($"{name} {surname} - {result} - High honour");
//        }
//        else if (FinalResult() >= 85)
//        {
//            Console.WriteLine($"{name} {surname} - {result} - Honour");
//        }
//        else if (FinalResult() >= 65)
//        {
//            Console.WriteLine($"{name} {surname} - {result} - Normal");
//        }
//        else
//        {
//            Console.WriteLine($"{name} {surname} - {result} - Fail");
//        }
//    }
//}

//4
//public static class Program
//{
//    public static void Main(string[] args)
//    {
//        Gun gun1 = new Gun("JNG-90", 20, 15, 100, "sniper");
//        gun1.Fire();
//        gun1.Reload();
//        gun1.Current();
//    }
//}
//public class Gun
//{
//    public string name;
//    public int maxCapacity;
//    public int currentBullet;
//    public int totalBullet;
//    public string type;
//    public Gun(string name, int maxCapacity, int currentBullet, int totalBullet, string type)
//    {
//        this.name = name;
//        this.maxCapacity = maxCapacity;
//        this.currentBullet = currentBullet;
//        this.totalBullet = totalBullet;
//        this.type = type;
//        if (currentBullet>maxCapacity)
//            Console.WriteLine("try again");
//    }
//    public int Fire()
//    {
//        if (type is  "sniper")
//            return currentBullet--;
//        if (currentBullet == 0)
//            return 4;
//        else if (type is "assault")
//            return currentBullet = 0;
//        else
//            return 10;
//    }
//    public void Reload()
//    {
//        int freePlace = maxCapacity - currentBullet;
//        totalBullet -= freePlace;
//    }
//    public void Current()
//    {
//        int a = currentBullet;
//        int b = totalBullet;
//        Console.WriteLine($"{name} {a} {b} {type}");
//    }
//}

//5
//public static class Program
//{
//    public static void Main(string[] args)
//    {
//        Calculator calculator1 = new Calculator(3, 6, "+");
//        Calculator calculator2 = new Calculator(56, 7, "/");
//        calculator1.Calculate();
//        calculator2.Calculate();
//    }
//}
//public class Calculator
//{
//    public int number1;
//    public int number2;
//    public string emel;
//    public Calculator(int number1, int number2, string emel)
//    {
//        this.number1 = number1;
//        this.number2 = number2;
//        this.emel = emel;
//    }
//    public int Add()
//    {
//        return number1 + number2;
//    }
//    public int Subtract()
//    {
//        return number1 - number2;
//    }
//    public int Multiply()
//    {
//        return number1 * number2;
//    }
//    public int Divide()
//    {
//        return number1 / number2;
//    }
//    public void Calculate()
//    {
//        if (emel is not "+" && emel is not "-" && emel is not "*" && emel is not "/")
//        {
//            Console.WriteLine("try again, this is not possible");
//        }
//        else if (emel is "+")
//            Console.WriteLine($"{number1} {emel} {number2} = {Add()}");
//        else if (emel is "-")
//            Console.WriteLine($"{number1} {emel} {number2} = {Subtract()}");
//        else if (emel is "*")
//            Console.WriteLine($"{number1} {emel} {number2} = {Multiply()}");
//        else
//            Console.WriteLine($"{number1} {emel} {number2} = {Divide()}");
//    }
//}


