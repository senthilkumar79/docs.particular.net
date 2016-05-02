﻿using NLog;
using NLog.Config;
using NLog.Targets;
using NServiceBus;

class NLogFiltering
{
    NLogFiltering()
    {
        #region NLogFiltering

        LoggingConfiguration config = new LoggingConfiguration();

        ColoredConsoleTarget target = new ColoredConsoleTarget();
        config.AddTarget("console", target);
        config.LoggingRules.Add(new LoggingRule("MyNamespace.*", LogLevel.Debug, target));

        LogManager.Configuration = config;

        SetLoggingLibrary.NLog();

        #endregion
    }
}
