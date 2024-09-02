Barrier barrier= new Barrier(3 , _ => System.Console.WriteLine(".1 Threads is finished"));

Thread threadOne = new(() => 
{
    for(int i=0; i<5; i++)
        System.Console.WriteLine($"Thread 1.1 - {i}");

    System.Console.WriteLine("Thread 1.1 bitti");
    barrier.SignalAndWait();
    System.Console.WriteLine("Thread 1.2 başladı");

    for(int i=0; i<3; i++)
        System.Console.WriteLine($"Thread 1.2 - {i}");
});

Thread threadTwo = new(() => 
{
    for(int i=0; i<4; i++)
        System.Console.WriteLine($"Thread 2.1 - {i}");

    System.Console.WriteLine("Thread 2.1 bitti");
    barrier.SignalAndWait();
    System.Console.WriteLine("Thread 2.2 başladı");

    for(int i=0; i<2; i++)
        System.Console.WriteLine($"Thread 2.2 - {i}");
});

Thread threadThree = new(() => 
{
    for(int i=0; i<2; i++)
        System.Console.WriteLine($"Thread 3.1 - {i}");

    System.Console.WriteLine("Thread 3.1 bitti");
    barrier.SignalAndWait();
    System.Console.WriteLine("Thread 3.2 başladı");

    for(int i=0; i<5; i++)
        System.Console.WriteLine($"Thread 3.2 - {i}");
});

threadOne.Start();
threadTwo.Start();
threadThree.Start();