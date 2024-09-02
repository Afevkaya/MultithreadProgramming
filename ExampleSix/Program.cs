#region SpinLock
// int value = 0;
//
// SpinLock spinLock= new SpinLock();
// Thread threadOne = new(()=> 
// {
//     bool lockTaken = false;
//     try
//     {
//         spinLock.Enter(ref lockTaken);
//         if (lockTaken)
//         {
//             for (int i = 0; i < 20; i++ )
//                 System.Console.WriteLine($"Thread One : {++value}");
//         }
//     }
//     finally{ spinLock.Exit(); }
// });
//
// Thread threadTwo = new(()=> 
// {
//     bool lockTaken = false;
//     try
//     {
//         spinLock.Enter(ref lockTaken);
//         if (lockTaken)
//         {
//             for (int i = 0; i < 20; i++ )
//                 System.Console.WriteLine($"Thread Two : {--value}");
//         }
//     }
//     finally{ spinLock.Exit(); }
// });
//
// threadOne.Start();
// threadTwo.Start();
#endregion

#region SpinWait
bool waitMode = false;
bool condition = false;
Thread threadOne = new(()=> 
{
    while (true)
    {
        if (waitMode)
        {
            // Bekleniyor
            Thread.MemoryBarrier();;
            continue;
        }
        if (!condition)
        {
            Thread.Sleep(5);
            continue;
        }
        System.Console.WriteLine("Thread One işleniyor...");
    }
});

Thread threadTwo = new(()=> 
{
    while(true)
    {
        SpinWait.SpinUntil(() => 
        {
            Thread.MemoryBarrier();
            return waitMode || condition;
        });
        System.Console.WriteLine("Thread Two işleniyor...");
    }
});

threadOne.Start();
threadTwo.Start();
#endregion