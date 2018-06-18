using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto_Forca
{
	public class Acetou2p : ContentPage
	{
		public Acetou2p (String j1, String j2, string palavra, int mestre, int partida, int p1, int p2)
		{

            


            // eu errei o nome mas foda-se
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("fuga.wav");


            Button bContinuar = new Button
            {
                Text = "Continuar",

                HorizontalOptions = LayoutOptions.Center,
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

                if(partida < 3)
                {

                    Navigation.PushModalAsync(new Trocou(j1, j2, mestre, partida,  p1, p2));
                }
                else
                {

                    // tela final p2
                    Navigation.PushModalAsync(new Final2p(j1, j2, p1, p2));


                }

            }
            

            player.Play();


            BackgroundImage = "venceu.jpeg";

            Tela();

            void Tela()
            {

                    Content = new StackLayout
                    {
                        Children = {

                            new Label { Text = "Parabéns, você acertou! A palavra era: " 
                            + palavra, TextColor = Color.Red,
                             HorizontalOptions = LayoutOptions.Center
                              },

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