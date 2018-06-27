using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;

namespace LTI.LeadsManagement.Util
{
    public class ConfigUtil
    {
        private SPWeb web;

        public ConfigUtil(SPWeb web)
        {
            this.web = web;  
        }

        public string getKeyValue(string key)
        {
            SPQuery q = new SPQuery();
            q.Query = String.Format(@" <Where>
                                              <Eq>
                                                 <FieldRef Name='Title' />
                                                 <Value Type='Text'>{0}</Value>
                                              </Eq>
                                           </Where>", key);

            var pairs = this.web.Lists["LeadsConfig"].GetItems(q);

            if(pairs.Count > 0)
            {
                string value = pairs[0]["KeyValue"].ToString();

                return value;
            }

            return "";
        }
    }
}

