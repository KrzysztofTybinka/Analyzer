
namespace Models.Interfaces
{
    public interface IValueComparable
    {
        /// <summary>
        /// Compares property value declared in string format with given in string format value
        /// </summary>
        /// <param name="value">Value to compare</param>
        /// <param name="propertyName">Property name</param>
        /// <returns>-1 if value is before property value, 0 if values are equal, 1 if value is after property value</returns>
        public int Compare(string value, string propertyName);
    }
}
