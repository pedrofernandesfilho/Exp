using System.Collections.Generic;
using System.Dynamic;

namespace Exp.Core.Common.Service
{
    public class DynamicService
    {
        public IEnumerable<dynamic> Get()
        {
            List<dynamic> r = new List<dynamic>();
            dynamic item;
            
            for (int i = 10; i < 17; i++)
            {
                item = new ExpandoObject();

                item.Id = i;
                item.PropA = "prop a";
                item.PropB = "prop b";
                item.PropC = 456;

                r.Add(item);
            }

            return r;
        }

        public dynamic Get(int id)
        {
            dynamic r = new ExpandoObject();

            r.Id = id;
            r.PropA = "prop a";
            r.PropB = "prop b";
            r.PropC = 456;

            return r;
        }
    }
}