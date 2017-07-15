using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.Crosscutting
{
    public interface IError
    {
        string DescriptionMessage { get; }
    }
}
