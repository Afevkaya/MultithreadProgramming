#region Spinning
// bool threadCondition = true;
//
// Thread threadOne = new(() => 
// {
//     while (true)
//     {
//         if(threadCondition)
//         {
//             for (int i = 1; i <= 10; i++)
//                 System.Console.WriteLine($"Thread One : {i}");
//             threadCondition = false;
//             break;
//         }
//     }
//     
// });
//
// Thread threadTwo = new(() => 
// {
//     while(true)
//     {
//         if(!threadCondition)
//         {
//             
//             for (int i = 10; i > 0; i--)
//                 System.Console.WriteLine($"Thread Two : {i}");
//             threadCondition = true;
//         }
//     }
// });
//
// threadOne.Start();
// threadTwo.Start();

#endregion

#region Monitor.Enter ve Monitor.Exit Metotları
// object locking = new();
// int i = 0;
//
// Thread threadOne = new (() => 
// {
//     try
//     {
//          Monitor.Enter(locking);
//         for(i=0;i<10;i++)
//             System.Console.WriteLine($"Thread One: {i}");
//     }
//     finally
//     {
//         Monitor.Exit(locking);
//     }
//    
//     
// });
//
// Thread threadTwo = new (() => 
// {
//     try
//     {
//          Monitor.Enter(locking);
//         for(i=0;i<10;i++)
//          System.Console.WriteLine($"Thread Two: {i}");
//     }
//     finally
//     {
//         Monitor.Exit(locking);
//     }
// });
//
// threadOne.Start();
// threadTwo.Start();

#endregion

#region lockTaken
// object locking = new();
// int i = 0;
//
// Thread threadOne = new (() => 
// {
//     try
//     {
//         bool lockTaken = false;
//         Monitor.Enter(locking, ref lockTaken);
//
//         if (lockTaken) 
//         {
//             for(i=0;i<10;i++)
//                 System.Console.WriteLine($"Thread One: {i}");
//         }
//     }
//     finally
//     {
//         Monitor.Exit(locking);
//     }
//    
//     
// });
//
// Thread threadTwo = new (() => 
// {
//     try
//     {
//         bool lockTaken = false;
//         Monitor.Enter(locking, ref lockTaken);
//         if(lockTaken)
//         {
//             for(i=0;i<10;i++)
//                 System.Console.WriteLine($"Thread Two: {i}");
//         }  
//     }
//     finally
//     {
//         Monitor.Exit(locking);
//     }
// });
//
// threadOne.Start();
// threadTwo.Start();
#endregion

#region Monitor.TryEnter
// object locking = new();
// int i = 0;
//
// Thread threadOne = new (() => 
// {
//    
//     var result = Monitor.TryEnter(locking, 100);
//     if (result)
//     {
//         try
//         {
//             for (i = 0; i < 10; i++)
//                 System.Console.WriteLine($"Thread One: {i}");
//         }
//         finally
//         {
//             Monitor.Exit(locking);
//         }
//     }
// });
//
// Thread threadTwo = new (() => 
// {
//    
//     var result = Monitor.TryEnter(locking, 100);
//     if (result)
//     {
//         try
//         {
//             for (i = 0; i < 10; i++)
//                 System.Console.WriteLine($"Thread Two: {i}");
//         }
//         finally
//         {
//             Monitor.Exit(locking);
//         }
//     }
// });
//
// threadOne.Start();
// threadTwo.Start();
#endregion

#region Mutex
// Mutex mutex = new();
// Thread threadOne = new (() => 
// {
//     mutex.WaitOne();
//     for (int i = 0; i < 10; i++) 
//     {
//         System.Console.WriteLine($"Thread One: {i}");
//     }
//     mutex.ReleaseMutex();
// });
//
// Thread threadTwo = new (() => 
// {
//     mutex.WaitOne();
//     for (int i = 0; i < 10; i++) 
//     {
//         System.Console.WriteLine($"Thread Two: {i}");
//     }
//     mutex.ReleaseMutex();
// });
//
// threadOne.Start();
// threadTwo.Start();
#endregion

#region Mutex ile Single Insatnce Application
// internal class Program 
// {
//     static Mutex _mutex;
//     static string _appName = "Example Project";
//     private static void Main(string[] args)
//     {
//         Mutex.TryOpenExisting(_appName, out _mutex);
//         if (_mutex == null)
//         {
//              _mutex = new Mutex(true, _appName);
//             System.Console.WriteLine("Program ayağa kaldırılı");
//             Console.Read();
//         }
//         else
//         {
//             _mutex.Close();
//             return;
//         }
//     }
// }
#endregion

