using System;
using RevitUI;
using Autodesk.Revit.UI;

namespace RevitModeling
{
    // Example implementation of IRevitCommand. Requires RevitUI project reference.
    public class Class1 : IRevitCommand
    {
        public Result Execute(ExternalCommandData commandData)
        {
            // TODO: implement modeling logic using provided ExternalCommandData
            return Result.Succeeded;
        }
    }
}
