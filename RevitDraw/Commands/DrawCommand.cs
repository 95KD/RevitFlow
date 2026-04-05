using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitDraw.Commands
{
    [Transaction(TransactionMode.Manual)]
    public class DrawCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("RevitDraw", "DrawCommand 실행!");
            return Result.Succeeded;
        }
    }
}
