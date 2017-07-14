using System.IO;

namespace FizzBuzz.Output
{
    /// <summary>
    /// Application Output interface
    /// </summary>
    public interface IOutput
    {
        /// <summary>
        /// Member to write output
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="message"></param>
        void WriteOut(string message);
    }
}
