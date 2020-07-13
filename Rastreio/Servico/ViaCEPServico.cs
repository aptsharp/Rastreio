using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Rastreio.Servico.Modelo;
using Newtonsoft.Json;

namespace Rastreio.Servico
{
    public class ViaCEPServico
    {

        public static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {

            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null) return null;

            return end;

        }


    }
}
/*
 * Serve para fazer o download da informação.
 */