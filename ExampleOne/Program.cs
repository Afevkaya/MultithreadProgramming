#region Thread Sınıfı
// Thread thread= new(()=>{
//     for (int i = 0; i < 999; i++)
//     {
//         Console.WriteLine($"Wroker Thread {i}");    
//     }
// });
// thread.Start();
// for (int i = 0; i < 999; i++)
// {
//     Console.WriteLine($"Main Thread {i}");
// }
#endregion

#region Thread Id

// Console.WriteLine("Main Thread");
// Console.WriteLine(System.Environment.CurrentManagedThreadId);
// Console.WriteLine(AppDomain.GetCurrentThreadId());
// Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

// System.Console.WriteLine("********");

// Thread threadOne = new(()=>{
//     Console.WriteLine("Worker One Thread");
//     Console.WriteLine(System.Environment.CurrentManagedThreadId);
//     Console.WriteLine(AppDomain.GetCurrentThreadId());
//     Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
// });

// System.Console.WriteLine("********");

// Thread threadTwo = new(()=>{
//     Console.WriteLine("Worker Two Thread");
//     Console.WriteLine(System.Environment.CurrentManagedThreadId);
//     Console.WriteLine(AppDomain.GetCurrentThreadId());
//     Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
// });

// threadOne.Start();
// threadTwo.Start();
#endregion

#region Thread IsBackground Property

int i = 10;
Thread thread = new(()=>
{
    while(i >= 0)
    {
        i--;
        Thread.Sleep(1000);
    }
   System.Console.WriteLine("Worker thread görevini tamamladı");
});
thread.IsBackground = false;
thread.Start();
System.Console.WriteLine("Main thread görevini tamamladı");

#endregion

#region Thread State
// int i = 10;
// Thread thread = new(()=>
// {
//     while(i >= 0)
//     {
//         i--;
//         Thread.Sleep(1000);
//     }
//     System.Console.WriteLine("Worker thread görevini tamamladı");
// });

// thread.Start();

// ThreadState state = ThreadState.Running;

// while(true)
// {
//     if(state == ThreadState.Stopped)
//         break;

//     if(state != thread.ThreadState)
//     {
//         state = thread.ThreadState;
//         Console.WriteLine(thread.ThreadState);
//     }
// }

// System.Console.WriteLine("Main thread görevini tamamladı");
#endregion

#region Locking Mekanizması

// object locking = new();
// int i = 1;
// Thread threadOne = new(()=>
// {
//     lock(locking)
//     {
//         while (i <= 10)
//         {
//             System.Console.WriteLine($"Thread 1: {i++}");
//         }
//     }

// });

// Thread threadTwo = new(()=>
// {
//     lock (locking)
//     {
//         while (i > 0)
//         {
//             System.Console.WriteLine($"Thread 2: {--i}");
//         }
//     }
// });

// threadOne.Start();
// threadTwo.Start();
#endregion

#region Sleep

// Thread thread = new(() => 
// {
//     for (int i = 0; i < 10; i++)
//     {
//         System.Console.WriteLine($"Thread {i}");
//         Thread.Sleep(1000);
//     }
// });
// thread.Start();
#endregion

#region Join

// Thread threadOne = new(() => 
// {
//     for (int i = 0; i < 10; i++)
//     {
//         System.Console.WriteLine($"Thread One {i}");
//     }
// });

// Thread threadTwo = new(() => 
// {
//     for (int i = 0; i < 10; i++)
//     {
//         System.Console.WriteLine($"Thread Two {i}");
//     }
// });
// threadOne.Start();
// threadOne.Join();
// threadTwo.Start();

#endregion

#region Thread İptal Etme

// bool stop = false;
// Thread thread = new(() => 
// {
//     int i = 1;
//     while(true)
//     {
//         if(stop) break;
//         System.Console.WriteLine($"Thread çalıştı {i++}");
//         Thread.Sleep(1000);
//     } 
//     System.Console.WriteLine("Thread görev sonlandı");
// });

// thread.Start();
// Thread.Sleep(5000);
// stop = true;
#endregion

#region Interrupt

// Thread thread = new(() => 
// {
//     try
//     {
//         Thread.Sleep(Timeout.Infinite);
//     }
//     catch (ThreadInterruptedException ex)
//     {
//         Console.WriteLine("Thread Uyandırıldı : " + ex.Message);
//     }
// });

// thread.Start();
// thread.Interrupt();
#endregion