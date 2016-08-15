using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Canaan.Envio.Utilitarios
{
    public class FileManager : ManagerBase
    {
        public FileStream File { get; set; }

        public FileManager(string path)
            : base(path)
        {
            if (!FileExist(path))
            {
                CreateFile(path);
            }
            File = new FileStream(Path, FileMode.Append);
        }

        public void CreateFile(string path)
        {
            var created = System.IO.File.Create(path);
            created.Close();
        }

        public bool FileExist(string path)
        {
            return System.IO.File.Exists(path);
        }

        public void Write(string info)
        {
            var infoBytes = Encoding.ASCII.GetBytes(info + Environment.NewLine);
            File.Write(infoBytes, 0, infoBytes.Length);
            File.Flush();
            Close();
        }

        public static string CleanDateCharacters(string date)
        {
            var rgx = new Regex("[^a-zA-Z0-9 -]");
            return rgx.Replace(date, "-");
        }

        public void Close()
        {
            File.Close();
        }
    }
}
