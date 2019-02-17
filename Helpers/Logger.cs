using log4net;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace SharepointHelper.Helpers
{
    public class Logger
    {
        private static Logger _logger;
        private ILog _log;

        public static Logger Instance
        {
            get
            {
                if( _logger == null )
                {
                    _logger = new Logger();
                }

                return _logger;
            }
        }

        private Logger()
        { }

      
        private void Initialize()
        {
            _log = LogManager.GetLogger(typeof(Logger));
            log4net.Config.XmlConfigurator.Configure();
        }

        public void Error( Exception ex, 
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            if( _log == null)
            {
                Initialize();
            }
            _log.Error(string.Format("Error logged from \r\n method: {0} \n\r in file: {1} \r\n at line: {2}", memberName, sourceFilePath, sourceLineNumber), ex);

        }
    }
}
