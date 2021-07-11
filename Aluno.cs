using System;

namespace Recuperacão02
{
    class Aluno: Pessoa 
    {
        private string _matricula;
        public string Matricula
        {
            get { return this._matricula; }
        }
        public Aluno (string nome, string matricula)
        {
            this._nome = nome;
            this._matricula = matricula;
           
        }

        protected Aluno _a1;
        public Aluno a1

        {
            get { return this._a1; }
        }

        protected Aluno _a2;
        public Aluno a2

        {
            get { return this._a2; }
        }

        protected Aluno _a3;
        public Aluno a3

        {
            get { return this._a3; }
        }

        protected Aluno _a4;
        public Aluno a4

        {
            get { return this._a4; }
        }

        protected Aluno _a5;
        public Aluno a5

        {
            get { return this._a5; }
        }

        protected Aluno _a6;
        public Aluno a6

        {
            get { return this._a6; }
        }



        public override void Imprimir()
        {
            Console.WriteLine("Nome: {0}", this._nome);
        
            Console.WriteLine("Matricula: {0}", this._matricula);
           
           
        }
    }
}
