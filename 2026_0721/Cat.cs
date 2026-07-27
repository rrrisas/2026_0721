class Cat : Animal
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
        Console.WriteLine("ニャー");
    }

}
