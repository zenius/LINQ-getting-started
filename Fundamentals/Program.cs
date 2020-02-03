using System;
using System.IO;
using System.Linq;

namespace Fundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      string path = @"/home/zenius";
      ShowLargeFilesWithoutLinq(path);

      Console.WriteLine("-------------------------------------------------------");

      ShowLargeFilesWithLinq(path);


      Console.ReadKey();
    }

    private static void ShowLargeFilesWithLinq(string path)
    {
      DirectoryInfo directory = new DirectoryInfo(path);
      FileInfo[] files = directory.GetFiles();

      /* 
        var filteredFiles = (
                            from file in files
                            orderby file.Length descending
                            select file
                          ).Take(3);
      */

      var filteredFiles = files.OrderByDescending(file => file.Length).Take(3);

      foreach (var file in filteredFiles)
      {
        Console.WriteLine($"{file.Name,-30} : {file.Length,10:N0}");
      }
    }

    private static void ShowLargeFilesWithoutLinq(string path)
    {
      DirectoryInfo directory = new DirectoryInfo(path);
      FileInfo[] files = directory.GetFiles();

      Array.Sort(files, new FileInfoComparer());

      for (var i = 0; i < 3; i++)
      {
        FileInfo file = files[i];
        Console.WriteLine($"{file.Name,-30} : {file.Length,10:N0}");
      }
    }
  }

}
