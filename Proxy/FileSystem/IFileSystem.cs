using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public interface IFileSystem
    {
        public void CreateFile(Folder folder, MyFile file);

        public void CreateFolder(Folder parentfolder, Folder folder);

        public void DeleteFile(Folder folder, string fileName);

        public void DeleteFolder(Folder parentFolder, string folderName);
        public Dictionary<string, MyFile> Search(Folder folder, string keyword);

    }
}
