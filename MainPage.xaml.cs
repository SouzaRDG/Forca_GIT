using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto_Forca
{
    
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("morte2.wav");

            player.Loop = true;

            if (player.IsPlaying == false)
            {
                player.Play();
            }

            //ESSA É A TELA QUE VAI APARECER QUANDO O JOGADOR CLICAR EM "2 JOGADORES"


            var user = new Entry { Placeholder = "Jogador 1" };
            var user2 = new Entry { Placeholder = "Jogador 2" };

            Button muda = new Button
            {
                Text = "Começar!",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center    // botão pra começar o jogo
            };

            muda.Clicked += Muda_Clicked;


            Button butao = new Button
            {
                Text = "Voltar",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center       // botão pra voltar par o menu anterior

            };

            butao.Clicked += Butao_Clicked;

            BackgroundImage = "nome.jpeg";

            this.Content = new StackLayout
            {
                
                Children =
                {
                    user,
                    user2,
                    muda,
                    butao


                }


            };


            //}


        void Muda_Clicked(object sender, EventArgs e)
            {
                if(user.Text == null)
                {
                    user.Text += "Jogador 1" ;
                }

                if (user2.Text == null)
                {
                    user2.Text += "Jogador 2";
                }

                var mestre = 1;
                var partida = 0;
                var p1 = 0;
                var p2 = 0;

                player.Stop();

                Navigation.PushModalAsync(new Trocou(user.Text, user2.Text, mestre, partida, p1, p2));     // se as entries estiverem vazias coloca um nome padrão
            }

            void Butao_Clicked(object sender, EventArgs e)
            {


                Navigation.PushModalAsync(new PaginaInicialDeVerdade());
                // volta pra pagina inicial
            }





        }



        protected override bool OnBackButtonPressed()
        {
            return true;

            // impede de usar o btão voltar

        }




    }

}
