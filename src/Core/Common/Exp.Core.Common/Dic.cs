using System.Collections.Generic;

namespace Exp.Core.Common
{
    class Dic
    {
        private readonly Dictionary<string, string> _dic;

        public Dic()
        {
            _dic = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dic[key]; }
            set { _dic[key] = value; }
        }

        public Dic Clone()
        {
            return (Dic)MemberwiseClone();
        }
    }
}