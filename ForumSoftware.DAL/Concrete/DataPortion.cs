using ForumSoftware.DAL.Abstract;
using ForumSoftware.DAL.Concrete;
using ForumSoftware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.DAL.Concrete
{
    /// <summary>
    /// Class that provides partial data passing with adding some additional metadata, f.e. total ItemsCount founded in Db
    /// </summary>
    /// <typeparam name="TEntity">Entity that class can containt</typeparam>
    public class DataPortion<TItem> : IDataPortion<TItem> where TItem : class
    {
        // backing fields for porperties
        IEnumerable<TItem> _items = null;
        int _count = 0;
        
        // ctor
        public DataPortion(IEnumerable<TItem> items, int dataAmount)
        {
            _items = items;
            _count = dataAmount;
        }

        // public data access properties
        public IEnumerable<TItem> Items
        {
            get { return _items; }
        }
        public int TotalCount
        {
            get { return _count; }
        }
    }
}
