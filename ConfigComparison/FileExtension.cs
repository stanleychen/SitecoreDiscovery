using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigComparison
{
    public static class FileExtension
    {
        public static string RemoveFileExtension(this string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                return string.Empty;

            string fileNoExtension = string.Empty;

            if (fileName.ToLower().IndexOf(".config") > 0)
            {
                fileNoExtension = fileName.Substring(0, fileName.ToLower().IndexOf(".config"));
            }

            return fileNoExtension;
        }

        public static IEnumerable<string> GetFiles(string path)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                path = queue.Dequeue();
                try
                {
                    foreach (string subDir in Directory.GetDirectories(path))
                    {
                        queue.Enqueue(subDir);
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                if (files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        yield return files[i];
                    }
                }
            }
        }
    }
}
