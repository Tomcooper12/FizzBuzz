using System.IO;

namespace FizzBuzz.Output
{
    /// <summary>
    /// Output writer implementation
    /// </summary>
    public class Outputter : IOutput
    {
        private readonly TextWriter _writer;

        public Outputter(TextWriter writer)
        {
            _writer = writer;
        }

        /// <summary>
        /// Method to write out the given text to a writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="message"></param>
        public void WriteOut(string message)
        {
            _writer.WriteLine(message);
        }
    }
}
