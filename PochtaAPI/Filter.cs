using PochtaAPI.Interfaces;
using RestSharp;
using System.Collections;
using System.Collections.Generic;

namespace PochtaAPI
{
    /// <summary>
    /// Фильтр
    /// </summary>
    public class Filter : IRequestParameter, IEnumerable<KeyValuePair<string, string>>
    {
        private Dictionary<string, string> Query = new Dictionary<string, string>();

        /// <summary>
        /// Инициализирует новый пустой фильтр
        /// </summary>
        internal Filter() { }

        internal string this[string name]
        {
            get => Query.ContainsKey(name) ? Query[name] : null;
            set => Query[name] = value;
        }

        void IRequestParameter.ApplyParameters(IRestRequest request)
        {
            foreach (var KVPair in this)
            {
                request.AddQueryParameter(KVPair.Key, KVPair.Value);
            }
        }

        internal void Add(string name, string value) => this[name] = value;

        #region IEnumerable

        IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator() => Query.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Query.GetEnumerator();

        #endregion IEnumerable
    }
}