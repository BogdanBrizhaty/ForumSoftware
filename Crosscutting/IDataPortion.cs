using System.Collections.Generic;

namespace ForumSoftware.Crosscutting
{
    /// <summary>
    /// Interface for DataPortion passing
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public interface IDataPortion<TItem> where TItem : class
    {
        IEnumerable<TItem> Items { get; }
        int TotalItems { get; }
    }
}
