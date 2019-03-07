using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OOP_TransferOfOwnship
{
    class ClassB
    {
        public void DoSomething()
        {
            new ClassA().DoSomething();
        }
    }
}