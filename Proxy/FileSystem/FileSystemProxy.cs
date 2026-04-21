using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class FileSystemProxy : IFileSystem
    {
        private IFileSystem _real = new MyFileSystem();

        public void CreateFile(Folder folder, MyFile file)
        {
            Console.WriteLine($"[LOG] CreateFile  → {file.Name}");
            _real.CreateFile(folder, file);
        }
        public void DeleteFile(Folder folder, string fileName)
        {
            Console.WriteLine($"[LOG] DeleteFile  → {fileName}");
            _real.DeleteFile(folder, fileName);
        }
        public void CreateFolder(Folder parentFolder, Folder folder)
        {
            Console.WriteLine($"[LOG] CreateFolder → {folder.Name}");
            _real.CreateFolder(parentFolder, folder);
        }
        public Dictionary<string, MyFile> Search(Folder folder, string keyword)
        {
            Console.WriteLine($"[LOG] Search → keyword: \"{keyword}\" in {folder.Name}");
            return _real.Search(folder, keyword);
        }
        public void DeleteFolder(Folder parentFolder, string folderName)
        {
            parentFolder.SubFolders.Remove(folderName);
        }
    }
}
