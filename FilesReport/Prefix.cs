using System;

namespace FilesReport
{
    public class Prefix
    {
        public static void Nodes(int filesCount, double filesSize, int directoriesCount, double directoriesSize)
        {
            Console.WriteLine("Nodes:");
            Console.WriteLine("\t\t[count]  [total size]");
            Console.WriteLine("  Directories:\t  {0}\t      {1:F2}MB", directoriesCount, directoriesSize);
            Console.WriteLine("  Files:\t  {0}\t      {1:F2}MB", filesCount, filesSize);
        }
    }
}