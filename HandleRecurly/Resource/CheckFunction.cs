using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandleRecurly.Resource
{
    public class CheckFunction
    {
        public bool CheckDuplicateElement(List<string> listString)
        {
            var duplicateItems = listString.GroupBy(x => x).Where(x => x.Count() > 1).ToList();
            return duplicateItems.Count() == 0;
        }
    }
}
