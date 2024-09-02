// #region Interlocked
// int i = 0;
// var preValue = Interlocked.Exchange(ref i, 5);
// System.Console.WriteLine(i);
// System.Console.WriteLine(preValue);
//
// Interlocked.CompareExchange(ref i, 15, 5);
// System.Console.WriteLine(i);
//
//
// Thread threadOne = new Thread(() -> 
// {
//     while (true)
//         Interlocked.Increment(ref i);
// });
//
// Thread threadTwo = new Thread(() -> 
// {
//     while (true)
//         System.Console.WriteLine(i);
// })
//
// Thread threadThree = new Thread(() -> 
// {
//     while (true)
//         Interlocked.Decrement(ref i);
// });
// #endregion

#region MemoryBarrier Metodu
int i = 0;
Thread writeThread = new(() => 
{
    while(true)
    {
        Interlocked.Increment(ref i);
        Thread.MemoryBarrier();
    }
});

Thread readThread = new(() => 
{
    while (true)
    {
        Thread.MemoryBarrier();
        System.Console.WriteLine(i);
    }
});

writeThread.Start();
readThread.Start();
#endregion


