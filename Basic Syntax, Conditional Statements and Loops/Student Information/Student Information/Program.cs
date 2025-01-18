class Student_Information
{
    static void Main() { 

    string student_name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    double average_grade = double.Parse(Console.ReadLine());

    Console.WriteLine($"Name: {student_name}, Age: {age}, Grade: {average_grade.ToString("F2")}");
    }
}