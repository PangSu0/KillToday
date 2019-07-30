using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOOW.Data
{
    public class DataRepository
    {
        private DataRepository(){ }
        public static ProfileData Profile { get; } = new ProfileData();
    }
}
