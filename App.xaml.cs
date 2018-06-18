using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto_Forca
{
	public partial class App : Application
	{
		public App ()
		{

            //MainPage = new NavigationPage(new PaginaInicialDeVerdade()); // Pagina inicial

            MainPage = new NavigationPage(new transicao());

            //App.Current.MainPage = new PaginaInicialDeVerdade();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
