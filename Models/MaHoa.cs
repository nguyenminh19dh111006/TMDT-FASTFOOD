using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyFastFood.Models
{
    public class MaHoa
    {
        public string GetMD5_low(string chuoi)
        {
             
            MD5 mh = MD5.Create();
            
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(chuoi);
            
            byte[] hash = mh.ComputeHash(inputBytes);
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
            

        }
    }
}