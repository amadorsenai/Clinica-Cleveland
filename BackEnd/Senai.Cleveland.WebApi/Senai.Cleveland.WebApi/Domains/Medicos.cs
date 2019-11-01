using System;
using System.Collections.Generic;

namespace Senai.Cleveland.WebApi.Domains
{
    public partial class Medicos
    {
        public int IdMedico { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public int Crm { get; set; }
        public string Estado { get; set; }
    }
}
