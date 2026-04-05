using Autodesk.Revit.UI;

namespace RevitUI
{
    /// <summary>
    /// Minimal Revit application entry point. The class registered in the .addin file
    /// should point to this type (FullClassName = "RevitUI.App").
    /// Keep startup logic small; ribbon and command proxies can be added here.
    /// </summary>
    public class App : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            // TODO: cleanup if needed
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            // TODO: create ribbons / buttons or initialize the proxy command loader
            return Result.Succeeded;
        }
    }
}
