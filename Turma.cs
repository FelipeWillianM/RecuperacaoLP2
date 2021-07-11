using System;
using System.Collections.Generic;


namespace Recuperacão02
{
    class Turma : IImprimivel
    {
        protected string _nome;
        public string Nome
        {
            get { return this._nome; }
        }

        protected string _serie;
        public string Serie
        {
            get { return this._serie; }
        }

        private Professor _p1;
        public Professor p1
        {
            get { return this._p1; }
        }

        protected Professor _p2;
        public Professor p2
        {
            get { return this._p2; }
        }


        private List<Aluno> _alunos;


        public Turma(string nome, string serie, Professor p1, Professor p2)
        {
            this._nome = nome;
            this._serie = serie;
            this._p1 = p1;
            this._p2 = p2;
            this._alunos = new List<Aluno>();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            this._alunos.Add(aluno);

        }

        public void Imprimir()
        {
            Console.WriteLine("Turma: {0}", this._nome);
            Console.WriteLine("Serie: {0}", this._serie);
            Console.WriteLine("Professores: {0} e {1}", this._p1.Nome, this._p2.Nome);
            Console.WriteLine("Alunos:");
            foreach (var aluno in this._alunos)
            { Console.Write(aluno.Nome);  }


        }

    }
}