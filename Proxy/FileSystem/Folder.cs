using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class Folder
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Dictionary<string, MyFile> Files { get; set; } = new();
        public Dictionary<string, Folder> SubFolders { get; set; } = new();

        public Folder(string name, string path)
        {
           Name = name;
           Path = path;
        }

        public override string ToString()
        {
            return $"Dir => {Path}/{Name} ({Files.Count} files)";
        }
    }
}
