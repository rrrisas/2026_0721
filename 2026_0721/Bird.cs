class Bird : Animal, IPlayable
{

    public Bird(string name, int age)
        :base(name, age)
    {

    }
    public override void Speak()
    {
        Console.WriteLine("ピヨピヨ");
    }
    public void Fly()
    {
        Console.WriteLine("パサパサ");
    }

    public override string Species => "Bird";
    protected override void MoveCore()
    {
        Console.WriteLine("飛ぶ");
    }
    public void Play()
    {
        Console.WriteLine("羽ばたいて遊ぶ");
    }
}
