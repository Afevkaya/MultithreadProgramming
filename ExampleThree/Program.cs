#region Semaphore
List<int> numbers = new();
Semaphore semaphore = new(2,2);
Thread threadOne = new Thread(()=>
{
    semaphore.WaitOne();
    int i = 0;
    while (i < 10)
    {   
        Console.WriteLine($"Thread One {++i}");
        numbers.Add(i);
        Thread.Sleep(1000);
    }
    semaphore.Release();
});

Thread threadTwo = new Thread(()=>
{
    semaphore.WaitOne();
    int i = 10;
    while (i < 20)
    {   
        Console.WriteLine($"Thread Two {++i}");
        numbers.Add(i);
        Thread.Sleep(1500);
    }
    semaphore.Release();
});

Thread threadThree = new Thread(()=>
{
    semaphore.WaitOne();
    int i = 20;
    while (i < 30)
    {   
        Console.WriteLine($"Thread Three {++i}");
        numbers.Add(i);
        Thread.Sleep(2000);
    }
    semaphore.Release();
});


threadOne.Start();
threadTwo.Start();
threadThree.Start();
#endregion

#region SemaphoreSlim
// List<int> numbers = new();
// SemaphoreSlim semaphoreSlim = new(2,3);
// Thread threadOne = new Thread(()=>
// {
//     semaphoreSlim.Wait();
//     int i = 0;
//     while (i < 10)
//     {   
//         Console.WriteLine($"Thread One {++i}");
//         numbers.Add(i);
//         Thread.Sleep(1000);
//     }
//     semaphoreSlim.Release();
// });
//
// Thread threadTwo = new Thread(()=>
// {
//     semaphoreSlim.Wait();
//     int i = 10;
//     while (i < 20)
//     {   
//         Console.WriteLine($"Thread Two {++i}");
//         numbers.Add(i);
//         Thread.Sleep(1500);
//     }
//     semaphoreSlim.Release();
// });
//
// Thread threadThree = new Thread(()=>
// {
//     semaphoreSlim.Wait();
//     int i = 20;
//     while (i < 30)
//     {   
//         Console.WriteLine($"Thread Three {++i}");
//         numbers.Add(i);
//         Thread.Sleep(2000);
//     }
//     semaphoreSlim.Release();
// });
//
//
// threadOne.Start();
// threadTwo.Start();
// threadThree.Start();
#endregion