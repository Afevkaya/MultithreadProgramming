#region Volatile Keyword
internal class Program
{
    public static void Main(string[] args)
    {
        Run();
    }
    static volatile int i;
    private static void Run()
    {
        Thread threadOne = new Thread(()=>
        {
            while (true) {i++;}
        });
        Thread threadTwo = new Thread(()=>
        {
            while (true) {System.Console.WriteLine(i);}
        });
        Thread threadThree = new Thread(()=>
        {
            while (true) {i--;}
        });
        threadOne.Start();
        threadTwo.Start();
        threadThree.Start();
    }
}
#endregion

// #region Volatile Sınıfı
// internal class Program
// {
//     public static void Main(string[] args)
//     {
//         Run();
//     }
//     static int i;
//     private static void Run()
//     {
//         Thread threadOne = new Thread(()=>
//         {
//             while (true) {Volatile.Write(ref i, Volatile.Read(ref i)+1);}
//         });
//         Thread threadTwo = new Thread(()=>
//         {
//             while (true) {System.Console.WriteLine(i);}
//         });
//         Thread threadThree = new Thread(()=>
//         {
//             while (true) {Volatile.Write(ref i, Volatile.Read(ref i)-1);}
//         });
//         threadOne.Start();
//         threadTwo.Start();
//         threadThree.Start();
//     }
// }
// #endregion