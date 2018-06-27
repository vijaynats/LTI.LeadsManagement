using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.LeadsManagement.Model
{
    public enum ContactStatus
    {
        ToContact = 1,
        Contacted = 2,
        Regular = 3
    }

    public enum ContactStages
    {
        Fresh = 1,
        Contacted = 2,
        Prospect = 3,
        Disqualified = 4,
        Won = 5
    }
}
