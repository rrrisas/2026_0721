using System.Globalization;

abstract class Animal
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public virtual string Species => "Animal";

    public Animal(string name, int age)
    {

        Name = name;
        Age = age;
        
    }
    //名前
    //年齢

    public void ShowProfile()
    {
        Console.WriteLine(Name + "," + Age + "歳");
    }

    public abstract void Speak();
    protected abstract void MoveCore();

    public override string ToString()
    {
        return ($"{GetType().Name}名前:{Name}, 年齢:{Age}");
    }

    public virtual void Walk()
    {
        Console.WriteLine("トコトコ歩く");
    }
    public void Walk(int steps)
    {
        Console.WriteLine($"{steps}歩歩いた");
    }

    public void ShowKind()
    {
        Console.WriteLine("動物です");
    }

    
    public void DoDaily()
    {
        ShowProfile();
        Speak();
        MoveCore();
    }

    

}