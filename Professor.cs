using System;

namespace Recuperacão02
{
    class Professor: Pessoa 
    {
        private string _email;
        public string Email
        {
            get { return this._email; }
        }

      
        public Professor (string nome, string email)
        {
            this._nome = nome;
            this._email = email;
           
        }
        public override void Imprimir()
        {
            
            Console.WriteLine("Nome: {0}", this._nome);
            Console.WriteLine("Email: {0}", this._email);
            
            
        }
    }
}
