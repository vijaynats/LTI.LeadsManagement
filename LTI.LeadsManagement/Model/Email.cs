﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.LeadsManagement.Model
{
    public class Email
    {
        public Email()
        {

        }

        public string Subject
        {
            get; set;
        }

        public IList<string> To
        {
            get;
            set;
        }

        public string From
        {
            get;
            set;
        }

        public string Body
        {
            get;
            set;
        }
    }
}
