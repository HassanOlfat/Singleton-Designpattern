using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Setting
    {
        private static Setting setting = null;
        private Setting()
        {
        }

        public static async Task<Setting> getinstance()
        {
            if (setting == null)
            {
                await Task.Run(() => setting = new Setting());
                
            }

            return setting;
        }
    }
}
