using System;
using System.Collections.Generic;
using System.Text;

namespace Rastreio.Servico.Modelo
{
    public class Pacote
    {
        public object TipoPesquisa { get; set; }
        public object TipoResultado { get; set; }        
        public string Qtd { get; set; }
        public string Versao { get; set; }
        public List<Objeto> Objeto { get; set; }

    }
}
