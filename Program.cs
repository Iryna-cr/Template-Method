using System;

class OrderProcess
{
    public void Process()
    {
        SelectFlowers();
        Pay();
        Deliver();
    }

    protected void SelectFlowers() => Console.WriteLine("Вибір квітів");
    protected void Pay() => Console.WriteLine("Оплата замовлення");
    protected void Deliver() => Console.WriteLine("Доставка оформлена");
}

class Program
{
    static void Main()
    {
        new OrderProcess().Process();
    }
}














