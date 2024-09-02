#region AutoResetEvent
// // Constructor da geçilen initialState parametresinin değerinin false olması 
// // AutoResetEvent nesnesinin sinyal bekleyen konumda olduğunu belirtmektedir.
// // Eğerki true verilseydi sinyal verilmiş modda olacaktı
//
// AutoResetEvent autoResetEvent = new(false);
// int counter = 0;
//
// Thread threadOne = new(() => 
// {
//     while(counter < 10)
//     {
//         Thread.Sleep(1000);
//         System.Console.WriteLine($"Thread One {++counter}");
//     }
//     // Sinyal/olayın gerçekleştiği diğer thread 'e bildiriliyor
//     autoResetEvent.Set();
// });
//
// Thread threadTwo = new(() => 
// {
//     // Sinyal/olayın gerçekleşmesi bekleniyor
//     autoResetEvent.WaitOne(); 
//     while(counter < 20)
//     {
//         Thread.Sleep(1000);
//         System.Console.WriteLine($"Thread Two {++counter}");
//     }
//     autoResetEvent.Set();
// });
//
// Thread threadThree = new(() => 
// {
//     // Sinyal/olayın gerçekleşmesi bekleniyor
//     autoResetEvent.WaitOne(); 
//     while(counter < 30)
//     {
//         Thread.Sleep(1000);
//         System.Console.WriteLine($"Thread Three {++counter}");
//     }
//     autoResetEvent.Set();
// });
//
// threadOne.Start();
// threadTwo.Start();
// threadThree.Start();
#endregion

#region ManualResetEventSlim
// ManualResetEventSlim manualResetEvent = new(false);
// int counter = 0;
//
// Thread threadOne = new(() => 
// {
//     while(counter < 10)
//     {
//         Thread.Sleep(1000);
//         System.Console.WriteLine($"Thread One {++counter}");
//     }
//     // Bekleyen threadler serbeest bırakılıyor
//     manualResetEvent.Set();
//
//     // Uyanan threadler reset ile tekrardan uyutuluyor
//     // manualResetEvent.Reset();
// });
//
// Thread threadTwo = new(() => 
// {
//     
//     while(counter < 20)
//     {
//         // Thread beklemeye alınıyor
//         manualResetEvent.Wait(); 
//         Thread.Sleep(1000);
//         System.Console.WriteLine($"Thread Two {++counter}");
//     }
//     manualResetEvent.Set();
// });
//
// Thread threadThree = new(() => 
// {
//     while(counter < 30)
//     {
//         manualResetEvent.Wait(); 
//         Thread.Sleep(1000);
//         System.Console.WriteLine($"Thread Three {++counter}");
//     }
// });
//
// threadOne.Start();
// threadTwo.Start();
// threadThree.Start();
#endregion

#region EventWaitHandle
// EventWaitHandle eventWaitHandle = new(false, EventResetMode.AutoReset);
// int counter = 0;
//
// Thread threadOne = new(() => 
// {
//     while(counter < 10)
//     {
//         Thread.Sleep(1000);
//         System.Console.WriteLine($"Thread One {++counter}");
//     }
//     // Bekleyen threadler serbeest bırakılıyor
//     eventWaitHandle.Set();
//
//     // Uyanan threadler reset ile tekrardan uyutuluyor
//     // manualResetEvent.Reset();
// });
//
// Thread threadTwo = new(() => 
// {
//     // Thread beklemeye alınıyor
//     eventWaitHandle.WaitOne(); 
//     while(counter < 20)
//     {
//         Thread.Sleep(1000);
//         System.Console.WriteLine($"Thread Two {++counter}");
//     }
//     eventWaitHandle.Set();
// });
//
// Thread threadThree = new(() => 
// {
//     eventWaitHandle.WaitOne(); 
//     while(counter < 30)
//     {    
//         Thread.Sleep(1000);
//         System.Console.WriteLine($"Thread Three {++counter}");
//     }
// });
//
// threadOne.Start();
// threadTwo.Start();
// threadThree.Start();
#endregion

#region CountdownEvent
// Constructor da kaç adet thread den sinyal beklendiği belirtilir.
CountdownEvent countdownEvent = new(3);
Thread threadOne = new(() => 
{
    System.Console.WriteLine("Thread One");
    Thread.Sleep(2000);
    countdownEvent.Signal();
});

Thread threadTwo = new(() => 
{
    System.Console.WriteLine("Thread Two");
    Thread.Sleep(1500);
    countdownEvent.Signal();
});

Thread threadThree = new(() => 
{
    System.Console.WriteLine("Thread Three");
    Thread.Sleep(1000);
    countdownEvent.Signal();
});

Thread threadFour = new(() => 
{
    countdownEvent.Wait();
    System.Console.WriteLine("Thread Four");
});

threadOne.Start();
threadTwo.Start();
threadThree.Start();
threadFour.Start();
#endregion