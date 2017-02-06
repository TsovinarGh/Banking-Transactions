using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class InfoEventArgs : EventArgs
    {
        public String Args { get; set; }
        public InfoEventArgs( ) 
        {
            Args = String.Empty;
        }
    }
}
