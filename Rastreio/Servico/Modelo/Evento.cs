using System;
using System.Collections.Generic;
using System.Text;

namespace Rastreio.Servico.Modelo
{
    public class Evento
    {
        public object Amazoncode { get; set; }
        public object Amazontimezone { get; set; }
        public string Cidade { get; set; }
        public string Codigo { get; set; }
        public object Comentario { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }
        public List<Object> Destino { get; set; }
        public object Detalhe { get; set; }
        public object Documento { get; set; }
        public object Endereco { get; set; }
        public string Hora { get; set; }
        public string Local { get; set; }
        public object Recebedor { get; set; }
        public string Status { get; set; }
        public object Sto { get; set; }
        public string Tipo { get; set; }
        public string Uf { get; set; }

    }
}
