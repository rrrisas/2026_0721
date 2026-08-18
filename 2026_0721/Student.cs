 public class Student
 {
    
    public string Name { get; set;}
    public int Age { get; set;}

    public int Score { get; set;}



    public void ShowProfile()
    {
        Console.WriteLine($"{Name}さん,{Age}才");
    }

 }
