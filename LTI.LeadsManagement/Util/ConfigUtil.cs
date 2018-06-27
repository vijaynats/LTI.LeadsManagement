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
        public ConfigUtil()
        {
        
        }

        public static string getKeyValue(string key)
        {
            SPQuery q = new SPQuery();
            q.Query = String.Format(@" <Where>
                                              <Eq>
                                                 <FieldRef Name='Title' />
                                                 <Value Type='Text'>{0}</Value>
                                              </Eq>
                                           </Where>", key);

            return getKeyValue("q");
        }
        
       



    }
    

}

