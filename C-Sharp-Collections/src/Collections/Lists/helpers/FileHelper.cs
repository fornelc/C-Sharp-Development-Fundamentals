using System;

namespace Collections.Lists
{
    public class FileHelper
    {
        private const string fileName = "Countries.csv";
        public static string GetParentFile() {
            string basePath = Environment.CurrentDirectory;
            basePath = basePath.Substring(0, basePath.LastIndexOf('/'));
            return String.Format("{0}/{1}", basePath, fileName);
        }
    }
}