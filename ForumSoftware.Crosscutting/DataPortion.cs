using System.Collections.Generic;

namespace ForumSoftware.Crosscutting
{
    /// <summary>
    /// Class that provides partial data passing with adding some additional metadata, f.e. total ItemsCount founded in Db
    /// </summary>
    /// <typeparam name="TEntity">Entity that class can containt</typeparam>
    public /* shared */class DataPortion<TItem> : IDataPortion<TItem> where TItem : class
    {
        private int _count = 0;
        private IEnumerable<TItem> _items = null;
        public DataPortion(IEnumerable<TItem> items, int totalAmount)
        {
            _count = totalAmount;
            _items = items;
        }

        IEnumerable<TItem> IDataPortion<TItem>.Items
        {
            get { return _items; }
        }
        int IDataPortion<TItem>.TotalItems
        {
            get { return _count; }
        }
    }
}
