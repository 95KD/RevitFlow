using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevitUI;

namespace RevitModeling
{
    // Example implementation of IRevitCommand. Requires RevitUI project reference.
    public class Class1 : IRevitCommand
    {
        public RevitCommandResult Execute(ExternalCommandDataWrapper commandData)
        {
            // TODO: implement modeling logic using wrapped command data
            return RevitCommandResult.Succeeded;
        }
    }
}
