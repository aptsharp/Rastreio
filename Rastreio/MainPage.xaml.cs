﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rastreio.Servico;
using Rastreio.Servico.Modelo;
using System.Numerics;
using Xamarin.Forms.Xaml;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Collections;

namespace Rastreio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;

            BOTAOP.Clicked += AchaPacote;

        }

        private void BuscarCEP(object sender, EventArgs args)
        {


            string cep = CEP.Text.Trim();


            if(isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {2}, Bairro: {3},{0}-{1}", end.localidade, end.uf, end.logradouro, end.bairro);

                    }
                    else
                    {
                        DisplayAlert("Erro", "Endereço não encotrado "+ cep, "ok", "cancelar");
                    }

                    
                }
                catch (Exception e)
                {

                    DisplayAlert("Erro Critico", e.Message, "ok");

                }

            }
            else
            {
                // caso erro
            }
                     

        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;

            int n;
            bool isNumeric = int.TryParse(cep, out n);
            // preciso para fazer a comparação entre string cep e se ela sé tera numeros para exibir mensagem de erro expecifica.
                        

            if (cep.Length != 8 && isNumeric == true)
            {
                DisplayAlert("Error", "CEP deve conter 8 caracteres", "ok");

                valido = false;
            }
            int NovoCEP = 0;
            if (!int.TryParse(cep, out NovoCEP))
            //caso a conversão tenha sido feita com sucesso a variavel novocep tera um valor numerico
            {
                DisplayAlert("Erro", "CEP apenas nuemros", "ok");

                valido = false;
                //erro
            }

            return valido;
        }
   
        private void AchaPacote(object sender, EventArgs args)
        {

            string numero = PACOTE.Text.Trim();
            Pacote pac = PacoteServico.PacoteRastreio(numero);

            RESULTADOP.Text = string.Format("Qdt Pac: {0}", pac.qtd);    
        
        }
    }
}
