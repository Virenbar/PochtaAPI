using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace PochtaAPI
{
    /// <summary>
    /// Параметры запроса
    /// </summary>
    public class Parameters : IEnumerable
    {
        private readonly NameValueCollection Query = HttpUtility.ParseQueryString(string.Empty);

        internal int Count => Query.Count;

        internal string this[string name]
        {
            get => Query[name];
            set => Query[name] = value;
        }

        internal void Add(string name, string value) => this[name] = value;

        internal void Add(string name, IList<string> values)
        {
            foreach (string value in values) { Add(name, value); };
        }

        internal string ToQuery() => Query.ToString();

        #region IEnumerable

        IEnumerator IEnumerable.GetEnumerator() => Query.GetEnumerator();

        #endregion IEnumerable
    }
}