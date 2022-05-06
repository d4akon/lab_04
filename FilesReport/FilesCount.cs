using System.IO;
using System.Linq;

namespace FilesReport
{
    public class FilesCount
    {
        public string Path { get; set; }

        public int GetFilesCount(string path)
        {
            this.Path = path;

            var dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles("*", SearchOption.TopDirectoryOnly);
            return files.Length;
        }

        public int GetDirectoryCount(string path)
        {
            this.Path = path;

            var dir = new DirectoryInfo(path);
            DirectoryInfo[] directories = dir.GetDirectories("*", SearchOption.TopDirectoryOnly);
            return directories.Length;
        }

        public double GetFilesSize(string path)
        {
            this.Path = path;

            var info = new DirectoryInfo(path);
            double totalSize = info.EnumerateFiles().Sum(file => file.Length);
            return totalSize / 1024000;
        }

        public double GetDirectorySize(string path)
        {
            this.Path = path;

            double wholeSize = 0;

            var dir = new DirectoryInfo(path);
            DirectoryInfo[] directories = dir.GetDirectories("*", SearchOption.TopDirectoryOnly);

            foreach (var directory in directories)
            {
                var directoryPath = directory.ToString();
                var info = new DirectoryInfo(directoryPath);
                double totalSize = info.EnumerateFiles().Sum(file => file.Length);
                wholeSize += totalSize;
            }

            return wholeSize / 1024000;
        }
    }
}