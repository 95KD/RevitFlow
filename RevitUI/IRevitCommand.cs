using System;

namespace RevitUI
{
    public enum RevitCommandResult
    {
        Succeeded = 0,
        Failed = 1,
        Cancelled = 2
    }

    /// <summary>
    /// Lightweight wrapper for Revit's ExternalCommandData so projects that don't
    /// reference the Revit API can still implement IRevitCommand. The RevitUI
    /// entry point should wrap the real ExternalCommandData when calling into
    /// implementations.
    /// </summary>
    public sealed class ExternalCommandDataWrapper
    {
        public object CommandData { get; }

        public ExternalCommandDataWrapper(object commandData)
        {
            CommandData = commandData;
        }
    }

    public interface IRevitCommand
    {
        RevitCommandResult Execute(ExternalCommandDataWrapper commandData);
    }
}
