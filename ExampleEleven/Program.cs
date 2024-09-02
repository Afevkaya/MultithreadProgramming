#region ThreadStatic Attribute
// internal class Program 
// {
//     [ThreadStatic]
//     static int x = 0;
//     private static void Main(string[] args)
//     {
//         Thread threadOne = new(()=> 
//         {
//             while(x<10)
//                 System.Console.WriteLine($"Thread One: {++x}");
//         });
//
//         Thread threadTwo = new(()=> 
//         {
//             while(x<10)
//                 System.Console.WriteLine($"Thread Two: {++x}");
//         });
//
//         Thread threadThree = new(()=> 
//         {
//             while(x<10)
//                 System.Console.WriteLine($"Thread Three: {++x}");
//         });
//
//         threadOne.Start();
//         threadTwo.Start();
//         threadThree.Start();
//     }
// }
#endregion

#region ThreadLocal<T> Class 'ı
// ThreadLocal<int> x = new(() => 0);
//
// Thread threadOne = new(() => 
// {
//     while(x.Value<10)
//     {System.Console.WriteLine($"Thread One {++x.Value}");}
// });
//
// Thread threadTwo = new(() => 
// {
//     while(x.Value<10)
//     {System.Console.WriteLine($"Thread Two {++x.Value}");}
// });
//
// Thread threadThree = new(() => 
// {
//     while(x.Value<10)
//     {System.Console.WriteLine($"Thread Three {++x.Value}");}
// });
//
// threadOne.Start();
// threadTwo.Start();
// threadThree.Start();
#endregion

#region GetData ve SetData
// internal class Program
// {
//     static LocalDataStoreSlot localDataStoreSlot = Thread.GetNamedDataSlot("x");
//
//     static int X 
//     { 
//         get 
//         { 
//             var data = (int?)Thread.GetData(localDataStoreSlot);
//             return data is null ? 0 : data.Value;
//         }
//         set 
//         {
//             Thread.SetData(localDataStoreSlot, value);
//         }
//     }
//     private static void Main(string[] args)
//     {
//         Thread threadOne = new(() => 
//         {
//             while(X<10)
//             {System.Console.WriteLine($"Thread One {++X}");}
//         });
//
//         Thread threadTwo = new(() => 
//         {
//             while(X<10)
//             {System.Console.WriteLine($"Thread Two {++X}");}
//         });
//
//         Thread threadThree = new(() => 
//         {
//             while(X<10)
//             {System.Console.WriteLine($"Thread Three {++X}");}
//         });
//
//         threadOne.Start();
//         threadTwo.Start();
//         threadThree.Start();
//     }
// }
#endregion