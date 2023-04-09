using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Service
{
    public class CaseService : ICaseServicecs
    {
        public Modals.Case CreateCase(Modals.Case _case)
        {
            Data.CaseDAO.Cases.Add(_case);
            return _case;
        }

        public string deleteCase(int caseId)
        {
            Modals.Case getCase =  Data.CaseDAO.Cases.Find(_cas => _cas.CaseId == caseId);
            Data.CaseDAO.Cases.Remove(getCase);
            return caseId.ToString();
        }

        public List<Modals.Case> getAllCases()
        {
            return Data.CaseDAO.Cases;
        }

        public Modals.Case getCaseByCaseId(int caseId)
        {
            return Data.CaseDAO.Cases.FirstOrDefault(_case => _case.CaseId == caseId);
        }
    }
}
