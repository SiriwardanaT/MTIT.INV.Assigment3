using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Service
{
    public interface ICaseServicecs
    {
        Modals.Case CreateCase(Modals.Case _case);

        List<Modals.Case> getAllCases();

        Modals.Case getCaseByCaseId(int caseId);

        string deleteCase(int caseId);
    }
}
