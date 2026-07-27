class Dog2 : Animal
{

    public Dog2(string name, int age)
        : base(name, age)
    {

    }

    public void Run()
    {
        Console.WriteLine("トコトコ");
    }

    public override void Speak()
    {
        Console.WriteLine("ワンワン");
    }
}

