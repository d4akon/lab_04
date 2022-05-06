using System;
using System.Collections.Generic;
using System.IO;

namespace FilesReport
{
    public class Program
    {
        static void Main(string[] args)
        {
            var directory = new FilesCount();
            Console.WriteLine("Insert the path");
            directory.Path = Console.ReadLine();
            string path = directory.Path;

            Prefix.Nodes(directory.GetFilesCount(directory.Path), directory.GetFilesSize(path), directory.GetDirectoryCount(path), directory.GetDirectorySize(path));
        }
    }
}
