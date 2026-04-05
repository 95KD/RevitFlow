using Autodesk.Revit.UI;

namespace RevitUI
{
    /// <summary>
    /// Interface for commands implemented in runtime-loaded assemblies.
    /// Placed in RevitUI so projects that implement commands can reference
    /// the Revit API types via the RevitUI project.
    /// </summary>
    public interface IRevitCommand
    {
        Result Execute(ExternalCommandData commandData);
    }
}
