using System;
using System.Collections.Generic;
using System.Text;
using Rastreio.Servico.Modelo;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Rastreio.Servico
{
    public class PacoteServico
    {
        public static string PacoteURL = "https://correios.postmon.com.br/rastreamento/?objeto={0}";

        public static  Pacote PacoteRastreio(string numero)
        {
            string NovoPacoteURL = string.Format(PacoteURL, numero);

            WebClient wcp = new WebClient();
            string Conteudop = wcp.DownloadString(NovoPacoteURL);

            Pacote pac = JsonConvert.DeserializeObject<Pacote>(Conteudop);

            return pac;
        }
        
    }
}

/*
 * fonte usada para facilitar o complexidade SOAP dos correios
 * https://github.com/PostmonAPI/correios.postmon.com.br
 */
