namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IFileSystem fs = new FileSystemProxy();

            var docs = new Folder("Documents", "C:");
            var file1 = new MyFile("notes", "C:/Documents", 1024, "text");
            var file2 = new MyFile("report", "C:/Documents", 204800, "pdf");

            fs.CreateFile(docs, file1);
            fs.CreateFile(docs, file2);

            var results = fs.Search(docs, "report");
            foreach (var kvp in results)
                Console.WriteLine("  Found: " + kvp.Value);

            fs.DeleteFile(docs, "notes_v2.txt");
        }
    }
}
