using ForumSoftware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.DAL.Abstract
{
    /// <summary>
    /// Interface for DataPortion passing
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public interface IDataPortion<TItem> where TItem : class
    {
        IEnumerable<TItem> Items { get; }
        int TotalCount { get; }
    }
}
