using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    /// <summary>
    ///  Class Income represents the personal income that you are getting e.g salary.
    /// </summary>
    public class Income : ICategorizable
    {
        private string category;
        public string Category  
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
    }
}
