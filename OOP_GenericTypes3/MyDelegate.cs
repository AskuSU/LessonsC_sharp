using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GenericDelegates
{
    delegate R MyDelegate<T, R>(T param); // Универсальный делегат
}
