using System;
using System.IO;

namespace RESTfulOutlook.Utils
{
    public class LoggerEventArgs : EventArgs
    {
        private DateTime _logTime;
        private string _logDetails;

        public LoggerEventArgs(DateTime LogTime, string LogDetails)
        {
            _logTime = LogTime;
            _logDetails = LogDetails;
        }

        public string LogDetails
        {
            get { return _logDetails; }
        }
    }

    public class ClassLogger : IDisposable
    {
        private StreamWriter _logStream = null;
        private string _logPath = "";
        private bool _logDateAndTime = true;
        private bool disposed = false;

        public delegate void LoggerEventHandler(object sender, LoggerEventArgs a);
        public event LoggerEventHandler LogAdded;

        public ClassLogger(string LogFile)
        {
            try
            {
                _logStream = File.AppendText(LogFile);
                _logPath = LogFile;
            }
            catch { }
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            // Dispose of managed resources here. 
            if (disposing)
            {
                _logStream.Flush();
                _logStream.Close();
            }

            disposed = true;
        }  


        protected virtual void OnLogAdded(LoggerEventArgs e)
        {
            LoggerEventHandler handler = LogAdded;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void Log(string Details, string Description = "", bool SuppressEvent = false)
        {
            try
            {
                DateTime oLogTime = DateTime.Now;

                if (String.IsNullOrEmpty(Description))
                {
                    if (_logDateAndTime)
                        _logStream.WriteLine(String.Format("{0:MM/dd/yy h:mm:ss tt}", oLogTime) + " ==> " + Details);
                }
                else
                {
                    _logStream.WriteLine("");
                    if (_logDateAndTime)
                        _logStream.WriteLine(String.Format("{0:MM/dd/yy h:mm:ss tt}", oLogTime) + " ==> " + Description);
                    _logStream.WriteLine(Details);
                }
                _logStream.Flush();

                if (!SuppressEvent)
                    OnLogAdded(new LoggerEventArgs(oLogTime, Description + Environment.NewLine + Details));
            }
            catch {}
        }
    }
}
