using System;

namespace Recuperacão02
{
    public abstract class Pessoa : IImprimivel
    {

        protected string _nome;

        public string Nome
        {
            get { return this._nome; }
        }

        public abstract void Imprimir();

    }

}