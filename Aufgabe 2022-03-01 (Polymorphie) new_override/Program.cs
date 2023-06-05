A a = new A();
B b = new B();
A c = new C();


Console.WriteLine(a.X());
Console.WriteLine(b.X());
Console.WriteLine(c.X());

Console.ReadLine();

class A
{
    public virtual string X()
    {
        return "A";
    }
}

class B : A
{
    public override string X()
    {
        return "B";
    }
}

class C : B
{
    public new string X()
    {
        return "C";
    }
}

