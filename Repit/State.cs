using System;
using System.Collections.Generic;
using System.Text;

namespace Repit
{
    class State//по умолчанию internal
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

        //private по умолчанию
        void Print() => Console.WriteLine($"{defaultVar}");
        //доступен производным классам в данном проекте и себе
        private protected void privateProtectedPrint() => Console.WriteLine($"{protectedPrivateVar}");
        //доступен производным классам в этом проекте
        protected void protectedPrint() => Console.WriteLine($"{protectedVar}");
        //достпуен из любой точки в данной сборке
        internal void internalPrint() => Console.WriteLine($"{internalVar}");
        //доступен из любой точки в данной сборке и производным классам в других сборках
        internal protected void internalProtectedPrint() => Console.WriteLine($"{protectedInternalVar}");
        //доступен в любом месте данной программы и в других сборках тоже
        public void publicPrint() => Console.WriteLine($"{publicVar}");



    }
}
