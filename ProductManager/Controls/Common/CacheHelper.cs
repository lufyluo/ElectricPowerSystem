using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Model.ViewModel;

namespace ProductManager.Controls.Common
{
    public  class CacheHelper
    {
        private static FileCache fileCache;
        private static object lockObj = new object();

        public static FileCache GetCache()
        {
            if (fileCache == null)
            {
                lock (lockObj)
                {
                    InitCache();
                    return fileCache;
                }
               
            }
            return fileCache;
        }
        public static void SetCache(FileCache cache)
        {
            var path = ConfigurationSettings.AppSettings["DbPath"];
            path = Path.Combine(path, "data.bin");
            using (var fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, cache);
                fileCache = cache;
            }
        }
        private static void InitCache()
        {
            var path = ConfigurationSettings.AppSettings["DbPath"];
            var file = new FileCache();
            var isNeedReadFile = FileCheck(path, "data.bin",out file);
            path = Path.Combine(path, "data.bin");
            if (!isNeedReadFile)
            {
                fileCache = file;
                return;
            }
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    fileCache = bf.Deserialize(fs) as FileCache;
                }
            }
        }

        private static bool FileCheck(string path,string fileName,out FileCache _fileCache)
        {
            if (!File.Exists(Path.Combine(path, "data.bin")))
            {
                var fs = File.Create(Path.Combine(path, "data.bin"));
                fs.Dispose();
                fs.Close();
                _fileCache = new FileCache()
                {
                    Account = "",
                    IsRememberedAccount = false,
                    Password = "",
                    Version = ConfigurationSettings.AppSettings["Version"]
                };
                SetCache(_fileCache);
                return false;
            }
            _fileCache = null;
            return true;
        }
    }
}
