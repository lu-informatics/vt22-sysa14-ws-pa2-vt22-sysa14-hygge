using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace HyggeLibrary
{
    public class Poems
    {
        private string poemID; 
        private string poemName;
        private string poemContent;

        public string PoemID { get => poemID; set => poemID = value; }
        public string PoemName { get => poemName; set => poemName = value; }
        public string PoemContent { get => poemContent; set => poemContent = value; }
    }
}
