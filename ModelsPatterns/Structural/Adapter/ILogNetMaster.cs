using System;

namespace ModelsPatterns.Structural.Adapter
{
    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}
