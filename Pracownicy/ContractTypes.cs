using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public enum ContractTypes
    {
        PERMANENT_EMPLOYMENT, FIXED_TERM_CONTRACT, CIVIL, UNKNOWN
    }
    public class ContractTypesMethods
    {
        private Dictionary<ContractTypes, String> contractTypeToStringPL = new Dictionary<ContractTypes, string>();
        private Dictionary<String, ContractTypes> stringToContractTypePL = new Dictionary<string, ContractTypes>();
        public ContractTypesMethods()
        {
            contractTypeToStringPL[ContractTypes.PERMANENT_EMPLOYMENT] = "Umowa na czas nieokreślony";
            contractTypeToStringPL[ContractTypes.FIXED_TERM_CONTRACT] = "Umowa na czas określony";
            contractTypeToStringPL[ContractTypes.CIVIL] = "Umowa o zlecenie";

            // create a reverse map
            foreach (ContractTypes type in contractTypeToStringPL.Keys)
                stringToContractTypePL[contractTypeToStringPL[type]] = type;

        }
        public ContractTypes fromString(String label)
        {
            if (stringToContractTypePL.ContainsKey(label))
            {
                return stringToContractTypePL[label];
            }
            return ContractTypes.UNKNOWN;
        }

        public String getString(ContractTypes type)
        {
            if (contractTypeToStringPL.ContainsKey(type))
            {
                return contractTypeToStringPL[type];
            }
            return "unknown";
        }

        public String[] getAllStrings()
        {
            return this.stringToContractTypePL.Keys.ToArray();
        }
    }
}
