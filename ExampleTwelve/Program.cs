#region System.Threading.Timer
// Timer timer = new((state) => 
// {
//     System.Console.WriteLine(state);
// }, "Eoo", 2000,100);
//
// Thread.Sleep(10000);
// timer.Change(0,1500);
//
// Console.Read();
#endregion

#region System.Timers.Timer
// System.Timers.Timer timer = new();
// timer.Elapsed += (sender, e) => System.Console.WriteLine("Eooo System.Timers.Timer");
// timer.Start();
// timer.Interval = 500;
// // timer.Stop();
// Thread.Sleep(10000);
// // timer.Change(0,1500);
//
// Console.Read();
#endregion