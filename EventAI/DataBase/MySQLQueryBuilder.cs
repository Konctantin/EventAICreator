using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAI
{
    class MySQLQueryBuilder
    {
        private string _query;
        private string _text;

        public MySQLQueryBuilder()
        { 
        }

        public String Text
        {
            set { value = _text; }
        }
    }
}
