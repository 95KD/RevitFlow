using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitModeling.Commands
{
    [Transaction(TransactionMode.Manual)]
    public class ModelCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // TODO: 실제 기능 구현
            TaskDialog.Show("RevitModeling", "ModelCommand 실행!");
            return Result.Succeeded;
        }
    }
}
