using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.Crosscutting
{
    public class OperationFailureError : IError
    {
        private string _msg;
        private string _propertyName;

        public OperationFailureError(string msg, string propertyName)
        {
            _msg = msg;
            _propertyName = propertyName;
        }
        public string DescriptionMessage
        {
            get { return _msg; }
        }
        public string PropertyName
        {
            get { return _propertyName; }
        }
    }
}
