using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    enum JobTitles
    {
        DESIGNER, PROGRAMMMER, MANAGER
    }

    static class JobTitlesMethods
    {
        public static String getString(JobTitles title)
        {
            switch (title)
            {
                case JobTitles.DESIGNER:
                    return "Projektant";
                case JobTitles.PROGRAMMMER:
                    return "Programista";
                case JobTitles.MANAGER:
                    return "Menedzer";
            }
            return "unknown";
        } 
    }
}
