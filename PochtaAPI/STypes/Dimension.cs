namespace PochtaAPI.STypes
{
    /// <summary>
    /// Линейные размеры
    /// </summary>
    public class Dimension
    {
        /// <summary>
        /// Линейная высота (сантиметры)
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Линейная длина (сантиметры)
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Линейная ширина (сантиметры)
        /// </summary>
        public int Width { get; set; }
    }
}