using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto_Forca
{
    public class Trocou : ContentPage
    {
        public Trocou(String j1, String j2, int mestre, int partida, int p1, int p2)
        {

            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("jogo1.wav");

            player.Loop = true;

            if (player.IsPlaying == false)
            {
                player.Play();
            }

            //while (partida < 3) { 

            var palavra = new Entry { Placeholder = "Palavra" };
            var dica = new Entry { Placeholder = "Dica" };
            var desconhecida = "";
            var palavra2 = "";


            Label aviso = new Label
            {
                TextColor = Color.Red,

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center

            };


            Button start = new Button
            {
                Text = "Começar",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            start.Clicked += Start_Cc;


            BackgroundImage = "palavra.jpg";


            if (mestre == 1)
            {



                Content = new StackLayout {
                    Children = {
                        new Label { Text = j1 + ", Digite sua palavra e a dica"},

                        palavra,
                     dica,


                       new Label { Text = "Aperte \"Começar\" e entregue o dispositivo para " + j2},

                       start,
                       aviso,
                       new Label { Text = "" + desconhecida}
                   }
                };
            }
            else
            {
                Content = new StackLayout
                {
                    Children = {
                        new Label { Text = j2 + ", Digite sua palavra e a dica"},

                        palavra,
                     dica,


                       new Label { Text = "Aperte \"Começar\" e entregue o dispositivo para " + j1},

                       start,
                       aviso,
                       new Label { Text = "" + desconhecida}
                   }
                };

            }
            void Start_Cc(object sender, EventArgs e)
            {
                if (palavra.Text == null | dica.Text == null)
                {
                    aviso.Text = "A palavra e a dica não podem estar vazias";

                }
                else
                {
                    aviso.Text = "";

                    desconhecida = "";

                    palavra2 = palavra.Text;

                    player.Stop();

                    Navigation.PushModalAsync(new Jogo2p(j1, j2, palavra2, dica.Text, desconhecida, mestre, partida, p1, p2));

                }


            }

        //}



    }


        protected override bool OnBackButtonPressed()
        {
            return true;
        }


	}
}