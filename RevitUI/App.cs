using Autodesk.Revit.UI;
using System;
using System.IO;
using System.Reflection;

namespace RevitUI
{
    public class App : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
            => Result.Succeeded;

        public Result OnStartup(UIControlledApplication application)
        {
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            CreateTab(application, "RevitDraw", "도구",
                dir, "RevitDraw.dll",
                ("DrawTool", "Draw", "RevitDraw.Commands.DrawCommand"));

            CreateTab(application, "RevitModeling", "도구",
                dir, "RevitModeling.dll",
                ("ModelTool", "Model", "RevitModeling.Commands.ModelCommand"));

            return Result.Succeeded;
        }

        private void CreateTab(
            UIControlledApplication app,
            string tabName,
            string panelName,
            string dllDir,
            string dllName,
            params (string name, string text, string className)[] buttons)
        {
            app.CreateRibbonTab(tabName);
            var panel = app.CreateRibbonPanel(tabName, panelName);
            var dllPath = Path.Combine(dllDir, dllName);

            foreach (var (name, text, className) in buttons)
            {
                panel.AddItem(new PushButtonData(name, text, dllPath, className));
            }
        }
    }
}