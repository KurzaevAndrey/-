using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
namespace SimpleThreadingDemo
{
  class Program
  {
    static void counting()
    {
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("Count: " + i + " - Thread " + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(10);
      } 
    }
    static void Main(string[] args)
    {
      ThreadStart starter = new ThreadStart(counting);
      Thread first = new Thread(starter);
      Thread second = new Thread(starter);
      first.Start(); 
      second.Start();
      first.Join(); 
      second.Join();
     // Console.Read();

      
    }
  }
}
