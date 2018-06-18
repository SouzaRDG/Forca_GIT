using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto_Forca
{
	public class transicao : ContentPage
	{
		public transicao ()
		{
            Navigation.PushModalAsync(new PaginaInicialDeVerdade());
            
        }
	}
}