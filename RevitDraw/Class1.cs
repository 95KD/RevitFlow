using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevitUI;

namespace RevitDraw
{
    // Example implementation of IRevitCommand.
    // The project must reference RevitUI to compile this.
    public class Class1 : IRevitCommand
    {
        public RevitCommandResult Execute(ExternalCommandDataWrapper commandData)
        {
            // TODO: adapt to real ExternalCommandData wrapped in commandData.CommandData
            try
            {
                // perform operations
                return RevitCommandResult.Succeeded;
            }
            catch
            {
                return RevitCommandResult.Failed;
            }
        }
    }
}
