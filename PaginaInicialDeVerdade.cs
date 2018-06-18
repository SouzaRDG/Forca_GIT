using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto_Forca
{
	public class PaginaInicialDeVerdade : ContentPage
	{
		public PaginaInicialDeVerdade ()
		{

            

            // ESSA É A PRIMEIRA TELA VISTA PELO USUARIO, TUDO SAI DAQUi

            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("alguma.wav");

            player.Loop = true;

            if(player.IsPlaying == false) { 
            player.Play();
            }

            Button b1Jogador = new Button
            {

                Text = "1 Jogador",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center

            };

            b1Jogador.Clicked += b1Jogador_Clicked;


            Button b2Jogadores = new Button
            {
                Text = "Jogar",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            b2Jogadores.Clicked += b2Jogadores_Clicked;


            Button bSobre = new Button
            {
                Text = "Sobre",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            bSobre.Clicked += bSobre_Clicked;

            Button bSair = new Button
            {
                Text = "Sair",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            bSair.Clicked += bSair_Clicked;


            void b1Jogador_Clicked (object sender, EventArgs e)
            {
                // Mudar para tela de 1 jogador


            }

            void b2Jogadores_Clicked(object sender, EventArgs e)
            {
                // Mudar para tela de 2 Jogadores   ( ESSA TELA ----> MAIN PAGE ---->   Trocou)
                player.Stop();
                Navigation.PushModalAsync(new MainPage());
                
                

            }

            void bSobre_Clicked (object sender, EventArgs e)
            {
                // Mudar para tela sobre
                Navigation.PushModalAsync(new Sobre());

                //App.Current.MainPage = new Sobre();


            }

            void bSair_Clicked (object sender, EventArgs e)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                //fecha o app

            }

            BackgroundImage = "main.jpeg";

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.End,
                Children = {
                    
                           // b1Jogador,
                            b2Jogadores,
                            bSobre,
                            bSair
                             },
                Padding = 50
                    
               
            };

            //repete(player);
        }

      /*  async void repete (Plugin.SimpleAudioPlayer player)
        {
            while (true)
            {
                if(player.IsPlaying == false)
                {
                    player.Play();
                }
            }
        }
        */
        protected override bool OnBackButtonPressed()
        {
            return true;

            // impede de usar o botao voltar
        }


    }
}