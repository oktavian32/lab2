namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);

            subject.Message = "Hello Observers!";
            Console.ReadKey();
        }
    }
}
