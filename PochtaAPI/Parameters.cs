using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PochtaAPI
{
    /// <summary>
    /// Фильтр
    /// </summary>
    public class Parameters : IEnumerable<KeyValuePair<string, string>>
    {
        private readonly Dictionary<string, string> Query = new Dictionary<string, string>();

        /// <summary>
        /// Инициализирует новый пустой фильтр
        /// </summary>
        internal Parameters() { }

        internal int Count => Query.Count;

        internal string this[string name]
        {
            get => Query.ContainsKey(name) ? Query[name] : null;
            set => Query[name] = value;
        }

        internal void Add(string name, string value) => this[name] = value;

        internal string ToQuery()
        {
            var r = Query.Where(KV => KV.Value != null).Select(KV => $"{KV.Key.ToLower()}={KV.Value}");
            return string.Join("&", r);
        }

        #region IEnumerable

        IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator() => Query.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Query.GetEnumerator();

        #endregion IEnumerable
    }
}