using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOOW.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new WOOWEntities())
            {
                string name = "PanSu";

                //var nickName = context.Profiles.Where(x => x.NickName.Equals(name)).Select(x => x.NickName).FirstOrDefault();
                var check = context.Profiles.FirstOrDefault(x => x.NickName == name);
                if(check == null)
                    Console.WriteLine("없음");
                else
                    Console.WriteLine("있음");
            }
        }
    }
}
