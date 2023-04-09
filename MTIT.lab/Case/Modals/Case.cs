using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case.Modals
{
    public class Case
    {
        public int CaseId { get; set; }

        public string UserId { get; set; }

        public string Description { get; set; }

        public DateTime? CaseDate { get; set; }
    }
}
