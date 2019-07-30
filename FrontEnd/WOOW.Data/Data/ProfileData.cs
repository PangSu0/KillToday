using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOOW.Data
{
    public class ProfileData
    {
        internal ProfileData()
        {

        }
        public bool IsUsedName(string name)
        {
            using (var context = new WOOWEntities())
            {
                return context.Profiles.FirstOrDefault(x => x.NickName == name) != null;
            }
        }
    }
}
