﻿namespace ModulesContracts
{
    public interface ILogger
    {
        void Log(string message);
        void Log(string message, params object[] args);
    }
}