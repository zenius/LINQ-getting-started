using System.Collections.Generic;
using System.IO;

namespace Fundamentals
{
  public class FileInfoComparer : IComparer<FileInfo>
  {
    public int Compare(FileInfo x, FileInfo y)
    {
      return y.Length.CompareTo(x.Length);
    }
  }
}