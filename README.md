# WriteLog
## C# Class library
Allow to write logs in c# console apps and log them using log4net

This class allow you to write in different colors depending if is a:
- Success: green
- Debug: white
- Info: cyan
- Working: Gray
- Warning: yellow
- Error: red
- Fatal: red

Apart from that, all of them except `success`, `Debug`, `Info` are stored into the log file using `Log4Net`. All the Logs are written using a new line.


## Usage

`WriteLog.Debug("this is a test");`


you can set different levels of depht, seting a value after the text, wich will bring a `dot` on the screen:
`WriteLog.Debug("this is a test",2);`
The result will be `.. this is a test` this will help a lot in order to clarify where the process is at this point.

Finally the log 4 net exceptions are available on `Warning`, `Error`, `Fatal` using the next 
`WriteLog.Warning("This is a warning",2,exception)`


##### Idea to convert to .net core
