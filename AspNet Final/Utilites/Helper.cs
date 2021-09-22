using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Utilites
{
    public static class Helper
    {
        public static void RemoveFile(string root,string folder,string file)
        {
            string resultPath = Path.Combine(root,folder,file);
            if (System.IO.File.Exists(resultPath))
            {
                System.IO.File.Delete(resultPath);
            }
        }
    }
}
