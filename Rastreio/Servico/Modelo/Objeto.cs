using System;
using System.Collections.Generic;
using System.Text;

namespace Rastreio.Servico.Modelo
{
    public class Objeto
    {
        public string Categoria { get; set; }
        public object Erro { get; set; }
        public List<Evento> Evento { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Sigla { get; set; }
    }
}
