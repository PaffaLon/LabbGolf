using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI
{
    interface IUI_Base
    {
        public int Button { get; set; }
        public List<string> Elements { get; set; }
    }
}
