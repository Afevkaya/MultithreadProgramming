#region Thread Pool
// ThreadPool.SetMaxThreads(4,4);
// ThreadPool.SetMinThreads(2,2);
//
// ThreadPool.QueueUserWorkItem(WorkerThread,"Task 1");
// ThreadPool.QueueUserWorkItem(WorkerThread,"Task 2");
// ThreadPool.QueueUserWorkItem(WorkerThread,"Task 3");
// ThreadPool.QueueUserWorkItem(WorkerThread,"Task 4");
// ThreadPool.QueueUserWorkItem(WorkerThread,"Task 5");
// ThreadPool.QueueUserWorkItem(WorkerThread,"Task 6");
//
// Console.Read();
//
// void WorkerThread(object state)
// {
//     System.Console.WriteLine($"Thread Count : {ThreadPool.ThreadCount}");
//     string name = (string)state;
//     System.Console.WriteLine($"{name} işi başladı");
//     Thread.Sleep(new Random().Next(1000,5000));
//     System.Console.WriteLine($"{name} işi bitti");
// }
#endregion

#region RegisterWaitForSingletonObject
// AutoResetEvent autoResetEvent = new AutoResetEvent(false);
//
// RegisteredWaitHandle registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject
//     (autoResetEvent, WorkerThread, "Task 1 Wait Handle", -1, false); // Time Out Süresiz
//
// // RegisteredWaitHandle registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject
// //     (autoResetEvent, WorkerThread, "Task 1 Wait Handle", 1500, true); // 1,5 saniye sonra faal hale gelecek
//
// Thread.Sleep(1500);
// autoResetEvent.Set();
//
// registeredWaitHandle.Unregister(autoResetEvent);
// Console.Read();
//
// void WorkerThread(object state, bool timedOut)
// {
//     System.Console.WriteLine($"Thread Count : {ThreadPool.ThreadCount}");
//     string name = (string)state;
//     System.Console.WriteLine($"{name} işi başladı");
//     Thread.Sleep(new Random().Next(1000,5000));
//     System.Console.WriteLine($"{name} işi bitti");
// }
#endregion

#region WaitHandle.WaitAll
// AutoResetEvent autoResetEvent1 = new AutoResetEvent(false);
// AutoResetEvent autoResetEvent2 = new AutoResetEvent(false);
// ManualResetEvent manualResetEvent1 = new ManualResetEvent(false);
// ManualResetEvent manualResetEvent2 = new ManualResetEvent(false);
//
// autoResetEvent1.Set();
// autoResetEvent2.Set();
// manualResetEvent1.Set();
// manualResetEvent2.Set();
//
// WaitHandle.WaitAll(new WaitHandle[] {
//     autoResetEvent1, autoResetEvent2, manualResetEvent1, manualResetEvent2
// });
//
// Console.WriteLine("Hi guys :)");
// Console.ReadLine();
#endregion

#region WaitHandle.WaitAny
// AutoResetEvent autoResetEvent1 = new AutoResetEvent(false);
// AutoResetEvent autoResetEvent2 = new AutoResetEvent(false);
//
// autoResetEvent1.Set();
// autoResetEvent2.Set();
//
// WaitHandle.SignalAndWait(autoResetEvent1, autoResetEvent2);
//
// Console.WriteLine("Hi guys :)");
// Console.ReadLine();
#endregion

#region WaitHandle.WaitAll
#endregion
