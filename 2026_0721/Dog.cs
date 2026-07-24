class Dog
{

    private string mName = "";
    private int mAge = 0;
    private string mKensyu = "";

    public Dog(string name, int age, string kensyu)
    {
        mName = name;
        mAge = age;
        mKensyu = kensyu;
    }
    //public int Age
    //{
    //    get { return mAge; }
    //    set { mAge = value; }
   // }
     public void ShowProfile()
    {
      Console.WriteLine($"犬の名前は{mName}です");
      Console.WriteLine($"年齢は{mAge}才です");
      Console.WriteLine($"犬種は{mKensyu}です");
    }
    }