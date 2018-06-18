using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto_Forca
{
	public class Errou2p : ContentPage
	{
		public Errou2p (String j1, String j2, string palavra, int mestre, int partida, int p1, int p2)
		{
            

            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("morte.wav");

            Button bContinuar = new Button
            {
                Text = "Continuar",

                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            };

            bContinuar.Clicked += BContinuar_Clicked;

            void BContinuar_Clicked(object sender, EventArgs e)
            {

                player.Stop();

                if (mestre == 1)
                {
                    mestre = 2;
                }
                else
                {
                    mestre = 1;
                    partida++;

                }

                if (partida < 3)
                {

                    Navigation.PushModalAsync(new Trocou(j1, j2, mestre, partida, p1, p2));
                }
                else
                {

                    // tela final p2
                    Navigation.PushModalAsync(new Final2p(j1, j2, p1, p2));


                }

            }
            StackLayout espaco = new StackLayout
            {

                Padding = 100,

            };


            player.Play();

            Tela();


            BackgroundImage = "morreu.jpeg";

            void Tela()
            {

                Content = new StackLayout
                {
                    Children = {
                        
                            new Label { Text = "UR DEAD! AND BAD!!! A palavra era: "
                            + palavra, TextColor = Color.Red,
                             HorizontalOptions = LayoutOptions.Center
                              },
                            espaco,

                            bContinuar


                        }
                };

            }
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}