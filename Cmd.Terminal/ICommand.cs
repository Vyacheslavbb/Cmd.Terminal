using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.Terminal
{
    public interface ICommand
    {
        string Description { get; }
        string Name { get; }

        void Process(Queue<string> command);
    }
}
