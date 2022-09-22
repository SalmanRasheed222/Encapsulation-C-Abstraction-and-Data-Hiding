using Encapsulation_with_Abstraction;

student s1 = new student();


Console.Write("Enter Username:");
s1.name = Console.ReadLine();
Console.WriteLine(s1.name);
Console.WriteLine("Enter Father Name: ");
s1.fathername = Console.ReadLine();
Console.WriteLine("enter Rollnumber");
s1.roll = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Obtain Marks");
s1.obtainmarks = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("##################################################");
s1.print();



