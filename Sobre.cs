using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto_Forca
{
	public class Sobre : ContentPage
	{
		public Sobre ()
		{

          

            Button bContinuar = new Button
            {
                Text = "Continuar",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            bContinuar.Clicked += BContinuar_Clicked;

            void BContinuar_Clicked(object sender, EventArgs e)
            {
                Navigation.PushModalAsync(new PaginaInicialDeVerdade());

             //   App.Current.MainPage = new PaginaInicialDeVerdade();

            }

            BackgroundImage = "sobre.jpg";

            Content = new StackLayout {
                VerticalOptions = LayoutOptions.End,
				Children = {
					new Label { Text = "    Jogo da Forca foi desenvolvido para a componente curricular de Sistemas Multimídia da Universidade de Sorocaba por alunos de Engenharia da computação usando somente o Xamarin. Ele pode ser jogado em Windowns, Android e iOS!"+
                    "\n   Evite usar acentos e 'Ç' no jogo, visto que não foram implementados!\n\n"+
                    " Isso é tudo pessoal!",
                    TextColor = Color.OrangeRed},
                    bContinuar
				}
			};
		}

        protected override bool OnBackButtonPressed()
        {
            return true;

            // impede de usar o botao voltar
        }
    }
}