using System.Collections.Generic;

namespace Foodie.Models
{
    class ListViewGrouping<T> : List<T>
    {
        public string Title { get; }

        public string ShortName { get; }

        public ListViewGrouping(string title, string shortName, IEnumerable<T> items)
        {
            Title = title;
            ShortName = shortName;
            AddRange(items);
        }
    }
}
