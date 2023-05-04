namespace Logline
{
    public class LogLine
    {
        /// <summary>
        /// The Message method should return a log line's message. 
        /// Example input: "[ERROR]: Invaid operation"
        /// Example output: "Invald operation"
        /// </summary>
        /// <param name="logLine">The log message</param>
        /// <returns>A string containing just the message element of the log</returns>
        public static string Message(string logLine)
        {
            // [InlineData("[WARNING]:   \tTimezone not set  \r\n", "Timezone not set")]
            // TODO - Implement the method
            //throw new NotImplementedException("Implement the Message function to return the message string");

            // Remove any 
            string input = logLine.Replace("\n", "");
            input = input.Replace("\t", "");
            input = input.Replace("\r", "");
            input = input.TrimEnd();
            // Just get the text after the log
            int endOfLog = input.IndexOf(":");
            input = input.Substring(endOfLog + 1, input.Length - endOfLog - 1);

            return input.TrimStart();
        }

        /// <summary>
        /// The LogLevel method should return a log line's log level, in lower case.
        /// Example input: "[ERROR]: Invaid operation"
        /// Example output: "error"
        /// </summary>
        /// <param name="logLine"></param>
        /// <returns>A lowercase string containing the log level</returns>
        public static string LogLevel(string logLine)
        {
            //throw new NotImplementedException("Implement the LogLevel method to return the Log level");
            int indexOf = logLine.IndexOf("]");
            return logLine.Substring(1, indexOf - 1).ToLower();
        }

        /// <summary>
        /// The Reformat method should reformat the log line, putting the message first and the 
        /// log level after it in parentheses. The log level should be lowercase.
        /// Example input: "[INFO]: operation completed"
        /// Example output: "Operation completed (info)"
        /// </summary>
        /// <param name="logLine">The log message</param>
        /// <returns></returns>
        public static string Reformat(string logLine)
        {
            string returnString = Message(logLine) + " (" + LogLevel(logLine) + ")";
            return returnString;
        }
    }
}
