static class LogLine
{
    public static string Message(string logLine)
    {
       int index = logLine.IndexOf("]:");
        string message = logLine.Substring(index + 2);
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf("[") + 1;
        int end = logLine.IndexOf("]");
        string level = logLine.Substring(start, end - start);
        return level.ToLower();
            
    }

    public static string Reformat(string logLine)
    {
        return $"{LogLine.Message(logLine)} ({LogLine.LogLevel(logLine)})";
    }
    
}
