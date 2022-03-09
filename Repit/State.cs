using System;
using System.Collections.Generic;
using System.Text;

namespace Repit
{
    class State
    {
        //все равно что private string defaultVar
        string defaultVar = "Undefined";
        //поле доступно только из текущего класса
        private string privateVar = "privateVar";
        //доступно из данного класса или из производных классов которые 
        //определены в этом же проекте
        protected private string protectedPrivateVar = "ProtectedPrivateVar";
        //достпуно из текущего класса и производных
        protected string protectedVar = "protectedVar";
        //доступно в любом месте текущего проекта
        internal string internalVar = "internalVar";
        //доступно в любом месте текущего проекта и из классов производных в других проектах
        protected internal string protectedInternalVar = "protectedInternalVar";
        //достпуно в любом месте текущего проекта и в других проектах тоже
        public string publicVar = "publicVar";

    }
}
