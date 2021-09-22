using AspNet_Final.Migrations;
using AspNet_Final.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Final.Extensions
{
    public static class Extension
    {
        public static bool CheckType(IFormFile file,string type)
        {
            return file.ContentType.Contains(type);
        }
        public static bool ChekSize(this IFormFile file,int kb)
        {
            return file.Length / 1024 <= kb;
        }
        public static async Task<string> SaveFile(this IFormFile file, string folder, string root)
        {
            try
            {
                string fileName = Guid.NewGuid().ToString() + file.FileName;
                string resulthPath = Path.Combine(root, folder, fileName);

                using (FileStream fileStream = new FileStream(resulthPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                return fileName;
            }
            catch (Exception)
            {

                return null;
            }
           
        }
    }
}
