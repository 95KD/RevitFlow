using System;
using System.Reflection;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Revit2023Addin
{
    /// <summary>
    /// Revit 애드인 시작점: 리본에 명령을 추가합니다.
    /// </summary>
    public class App : IExternalApplication
    {
        /// <summary>
        /// Revit 시작 시 호출됩니다. 리본 패널과 버튼을 등록합니다.
        /// </summary>
        public Result OnStartup(UIControlledApplication application)
        {
            try
            {
                var panel = application.CreateRibbonPanel("RevitFlow");
                var assemblyPath = Assembly.GetExecutingAssembly().Location;
                var buttonData = new PushButtonData(
                    "RevitFlow.Command",
                    "RevitFlow",
                    assemblyPath,
                    "Revit2023Addin.Command");

                panel.AddItem(buttonData);
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                TaskDialog.Show("RevitFlow - Startup Error", ex.Message);
                return Result.Failed;
            }
        }

        /// <summary>
        /// Revit 종료 시 호출됩니다.
        /// </summary>
        public Result OnShutdown(UIControlledApplication application)
        {
            // 필요 시 정리 로직 추가
            return Result.Succeeded;
        }
    }

    /// <summary>
    /// 샘플 외부 명령: 문서 접근, 트랜잭션 사용, 예외 처리 예시를 포함합니다.
    /// </summary>
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        /// <summary>
        /// Revit에서 명령이 실행될 때 호출됩니다.
        /// </summary>
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                var uiDoc = commandData.Application.ActiveUIDocument;
                if (uiDoc == null)
                {
                    message = "현재 활성 문서가 없습니다.";
                    return Result.Failed;
                }

                var doc = uiDoc.Document;

                // 예시: 단순 트랜잭션으로 작업 수행
                using (var tx = new Transaction(doc, "RevitFlow - Sample Operation"))
                {
                    tx.Start();
                    // TODO: 실제 로직 구현 (요소 생성/수정 등)
                    tx.Commit();
                }

                TaskDialog.Show("RevitFlow", "명령이 성공적으로 실행되었습니다.");
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                // 사용자에게 친절한 메시지 제공
                message = "오류가 발생했습니다: " + ex.Message;
                TaskDialog.Show("RevitFlow - Error", ex.ToString());
                return Result.Failed;
            }
        }
    }
}
