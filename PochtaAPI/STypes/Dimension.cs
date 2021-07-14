using System.Runtime.Serialization;

namespace PochtaAPI.STypes
{
    /// <summary>
    /// Линейные размеры
    /// </summary>
    [DataContract]
    public class Dimension
    {
        /// <summary>
        /// Линейная высота (сантиметры)
        /// </summary>
        [DataMember(Name = "height")]
        public int Height { get; set; }

        /// <summary>
        /// Линейная длина (сантиметры)
        /// </summary>
        [DataMember(Name = "length")]
        public int Length { get; set; }

        /// <summary>
        /// Линейная ширина (сантиметры)
        /// </summary>
        [DataMember(Name = "width")]
        public int Width { get; set; }
    }
}