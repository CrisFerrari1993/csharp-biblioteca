﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente
    {
        private string _cognome;
        private string _nome;
        private string _email;
        private string _password;
        private string _recapitoTelefonico;

        public string Cognome {  get { return _cognome; } set { _cognome = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { set { _password = value; } }
        public string RecepcaoTelefonico { get {  return _recapitoTelefonico;} set { _recapitoTelefonico = value; } }

    }
}
