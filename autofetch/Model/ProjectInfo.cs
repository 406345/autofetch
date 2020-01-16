using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autofetch.Model
{
    class ProjectInfo
    {
        public string Path { get; set; }
        public string Branch { get; set; }

        public string ListDisplay
        {
            get
            {
                return string.Format("[{0}] {1}", this.Branch, this.Path);
            }
        }
    }
}
