using System;
using RevitUI;
using Autodesk.Revit.UI;

namespace RevitDraw
{
    // Example implementation of IRevitCommand.
    // The project must reference RevitUI to compile this.
    public class Class1 : IRevitCommand
    {
        public Result Execute(ExternalCommandData commandData)
        {
            // TODO: adapt to real ExternalCommandData
            try
            {
                // perform operations
                return Result.Succeeded;
            }
            catch
            {
                return Result.Failed;
            }
        }
    }
}
