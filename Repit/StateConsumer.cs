using System;
using System.Collections.Generic;
using System.Text;

namespace Repit
{
    class StateConsumer
    {
        public void PrintState()
        {
            State state = new State();
            // переменная internalVar с модификатором internal доступна из любого места текущего проекта
            // поэтому спокойно присваиваем ей значение
            Console.WriteLine(state.internalVar);

            // переменная protectedInternalVar так же доступна из любого места текущего проекта
            Console.WriteLine(state.protectedInternalVar);

            // переменная publicVar общедоступна
            Console.WriteLine(state.publicVar);
        }   
    }
}
