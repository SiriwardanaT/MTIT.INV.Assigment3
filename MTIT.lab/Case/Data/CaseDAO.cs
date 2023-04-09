using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Data
{
    public static class CaseDAO
    {
        public static List<Modals.Case> Cases = new List<Modals.Case>()
        {
            new Modals.Case(){ CaseId=10,CaseDate=DateTime.Now,Description="O13",UserId="U12" },
            new Modals.Case(){ CaseId=11,CaseDate=DateTime.Now,Description="O12",UserId="U12" }
        };
    }
}
