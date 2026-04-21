using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class MyFileSystem : IFileSystem
    {
        public void CreateFile(Folder folder, MyFile file)
        {
            folder.Files[file.Name] = file;
            Console.WriteLine($"Created: {file}");
        }

        public void CreateFolder(Folder parentfolder, Folder folder)
        {
            parentfolder.SubFolders[folder.Name] = folder;
            Console.WriteLine($"Created: {folder}");
        }

        public void DeleteFile(Folder folder, string fileName)
        {
            folder.Files.Remove(fileName);
            Console.WriteLine($"Deleted: {fileName}");
        }

        public void DeleteFolder(Folder parentFolder, string folderName)
        {
            parentFolder.SubFolders.Remove(folderName);
        }

        public Dictionary<string, MyFile> Search(Folder folder, string keyword)
        {
            return folder.Files
                .Where(f => f.Key.Contains(keyword))
                .ToDictionary(f => f.Key, f => f.Value);
        }
    }
}
