class Cat : Animal, IPlayable

{
    public Cat(string name, int age)
        : base(name, age)   //Animal のコンストラクタを呼ぶ
    {
    }
    public void Sleep()
    {
        Console.WriteLine("スースー");
    }

    public override void Speak()
    {
        Console.WriteLine("ニャーニャー");
    }

    public override string Species => "Cat";

    public new void ShowKind()
    {
        Console.WriteLine("猫です");
    }
    protected override void MoveCore()
    {
        Console.WriteLine("速い");
    }

    public void Play()
    {
        Console.WriteLine("じゃれる");
    }
}
