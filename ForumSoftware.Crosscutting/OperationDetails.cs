using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.Crosscutting
{
    public class OperationDetails : IOperationDetails
    {
        private OperationFailureError _error;
        public OperationDetails(OperationFailureError error)
        {
            _error = error;
        }
        public OperationDetails()
        {
            _error = null;
        }
        public OperationFailureError Error
        {
            get { return _error; }
        }

        public bool Succeeded
        {
            get { return (_error == null); }
        }
    }
}
