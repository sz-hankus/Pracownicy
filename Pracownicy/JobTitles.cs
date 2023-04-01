using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public enum JobTitles
    {
        DESIGNER, PROGRAMMMER, MANAGER, UNKNOWN
    }

    public class JobTitlesMethods
    {
        private Dictionary<JobTitles, String> titleToStringPL = new Dictionary<JobTitles, string>();
        private Dictionary<String, JobTitles> stringToTitlePL = new Dictionary<string, JobTitles>();
        public JobTitlesMethods()
        {
            titleToStringPL[JobTitles.DESIGNER] = "Projektant";
            titleToStringPL[JobTitles.PROGRAMMMER] = "Programista";
            titleToStringPL[JobTitles.MANAGER] = "Menedżer";

            // create a reverse map
            foreach (JobTitles title in titleToStringPL.Keys)
                stringToTitlePL[titleToStringPL[title]] = title;
            
        }
        public JobTitles fromString(String label)
        {
            if (stringToTitlePL.ContainsKey(label)) {
                return stringToTitlePL[label];
            }
            return JobTitles.UNKNOWN;
        }

        public String getString(JobTitles title)
        {
            if (titleToStringPL.ContainsKey(title)) {
                return titleToStringPL[title];
            }
            return "unknown";
        }

        public String[] getAllStrings()
        {
            return this.stringToTitlePL.Keys.ToArray();
        }
    }
}
