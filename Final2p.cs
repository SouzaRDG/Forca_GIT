using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto_Forca
{
	public class Final2p : ContentPage
	{
		public Final2p (String j1, String j2, int p1, int p2)
		{
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

            player.Loop = true;


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
                Navigation.PushModalAsync(new PaginaInicialDeVerdade());
            }


            if (p1 > p2)
            {
                player.Load("algo.wav");
                player.Play();
                BackgroundImage = "fim.jpeg";


                Content = new StackLayout
                {
                    Children = {
                    new Label { Text = j1 + " : " + p1 + "pontos            " +
                    j2 + " : " + p2  + "pontos", TextColor = Color.Red},
                    new Label { Text = j1 + " ROCKS ", TextColor = Color.Red},
                    new Label { Text = j2 + " é ruim demais da conta!!!", TextColor = Color.Red},
                    bContinuar
                }
                };
            



            }
            else
            {
                if (p2 > p1)
                {
                    player.Load("algo.wav");
                    player.Play();
                    BackgroundImage = "fim.jpeg";
                    Content = new StackLayout
                    {
                        Children = {
                            new Label { Text = j1 + " : " + p1 + "pontos            " +
                         j2 + " : " + p2  + "pontos", TextColor = Color.Red},
                          new Label { Text = j2 + " ROCKS ", TextColor = Color.Red},
                         new Label { Text = j1 + " é ruim demais da conta!!!", TextColor = Color.Red},
                         bContinuar
                           },
                       
                    };
                }


                else
                {
                    player.Load("empate.wav");
                    player.Play();
                    BackgroundImage = "empatou.jpg";

                    Content = new StackLayout
                    {
                        Children = {
                        new Label { Text = j1 + " : " + p1 + "pontos            " +
                    j2 + " : " + p2  + "pontos", TextColor = Color.Red},
                    new Label { Text = " Empate... Que chato...", TextColor = Color.Red},
                        
                        bContinuar
                        },
                    };
                    }

                }
                
                }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }

	}
