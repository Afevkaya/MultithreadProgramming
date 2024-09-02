// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         for (int i = 0; i < 5; i++)
//             new Thread(Read).Start();
//         
//         for (int i = 0; i < 2; i++)
//             new Thread(Writer).Start();
//     }
// }
//
// static new ReaderWriterLockSlim();
// static int counter = 0;
//
// static void Read()
// {
//     for (int i = 0; i < 10; i++)
//     {
//         try
//         {
//             readerWriterLockSlim.EnterReadLock();
//             System.Console.WriteLine($"Read : Thread {Thread.CurrentThread.ManagedThreadId} is reading: {counter}");
//         }
//         finally
//         {
//             readerWriterLockSlim.ExitReadLock();
//         }
//         Thread.Sleep(1000);
//     }
// }
//
// static void Write()
// {
//     for (int i = 0; i < 10; i++)
//     {
//         try
//         {
//             readerWriterLockSlim.EnterReadLock();
//             System.Console.WriteLine($"Write : Thread {Thread.CurrentThread.ManagedThreadId} is writing: {counter}");
//             Thread.Sleep(200);
//         }
//         finally
//         {
//             readerWriterLockSlim.ExitReadLock();
//         }
//     }
// }