class Animal
{
    public string Name { get; private set; }
    public int Age { get; private set; }

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

    public virtual void Speak()
    {
        Console.WriteLine(".........");
    }
}