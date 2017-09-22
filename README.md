# WriteLog
Allow to write logs in c# console apps and log them using log4net

This class allow you to write in different colors depending if is a:
- Success: green
- Debug: white
- Info: cyan
- Working: Gray
- Warning: yellow
- Error: red
- Fatal: red

Apart from that, all of them except `success`, `Debug`, `Info` are stored into the log file using `Log4Net`
