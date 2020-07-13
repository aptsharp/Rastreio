using System;
using System.Collections.Generic;
using System.Text;

namespace Rastreio.Servico.Modelo
{
    public class Endereco
    {
        public String cep { get; set; }
        public String logradouro { get; set; }
        public String complemento { get; set; }
        public String bairro { get; set; }
        public String localidade { get; set; }
        public String uf { get; set; }
        public String unidade { get; set; }
        public String ibge { get; set; }
        public String gia { get; set; }

    }
}

