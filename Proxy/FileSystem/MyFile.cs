using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class MyFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long SizeBytes { get; set; }
        public string Type { get; set; }

        public MyFile(string name, string path, long sizeBytes, string type) 
        {
            this.Name = name;
            this.Path = path;
            this.SizeBytes = sizeBytes;
            this.Type = type;
        }

        public override string ToString() => $"File => {Path}/{Name}.{Type} ({SizeBytes} bytes)";
    }
}
