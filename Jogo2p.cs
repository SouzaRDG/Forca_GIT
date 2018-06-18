using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Projeto_Forca
{
	public class Jogo2p : ContentPage
	{
        public Jogo2p(String j1, String j2, string palavra, string dica, string desconhecida, int mestre, int partida, int p1, int p2)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("alguma2.wav");

            player.Loop = true;

            if (player.IsPlaying == false)
            {
                player.Play();
            }

            List<Label> lista = new List<Label>();

            var erros = 0;
            var acertos = 0;


            Button bT = new Button
            {
                Text = "T",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bS = new Button
            {
                Text = "S",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 41,
                HeightRequest = 85
            };
            Button bE = new Button
            {
                Text = "E",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bQ = new Button
            {
                Text = "Q",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bW = new Button
            {
                Text = "W",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bR = new Button
            {
                Text = "R",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bY = new Button
            {
                Text = "Y",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bU = new Button
            {
                Text = "U",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bI = new Button
            {
                Text = "I",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bO = new Button
            {
                Text = "O",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bP = new Button
            {
                Text = "P",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 36,
                HeightRequest = 80
            };
            Button bA = new Button
            {
                Text = "A",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 41,
                HeightRequest = 85
            };
            Button bD = new Button
            {
                Text = "D",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 41,
                HeightRequest = 85
            };
            Button bF = new Button
            {
                Text = "F",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 41,
                HeightRequest = 85
            };
            Button bG = new Button
            {
                Text = "G",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 41,
                HeightRequest = 85
            };
            Button bH = new Button
            {
                Text = "H",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 41,
                HeightRequest = 85
            };
            Button bJ = new Button
            {
                Text = "J",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 41,
                HeightRequest = 85
            };
            Button bK = new Button
            {
                Text = "K",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 41,
                HeightRequest = 85
            };
            Button bL = new Button
            {
                Text = "L",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 41,
                HeightRequest = 85
            };
            /*    Button bÇ = new Button
                {
                    Text = "Ç",

                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    WidthRequest = 55,
                    HeightRequest = 90
                };*/
            Button bZ = new Button
            {
                Text = "Z",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 50,
                HeightRequest = 90
            };
            Button bX = new Button
            {
                Text = "X",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 50,
                HeightRequest = 90
            };
            Button bC = new Button
            {
                Text = "C",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 50,
                HeightRequest = 90
            };
            Button bV = new Button
            {
                Text = "V",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 50,
                HeightRequest = 90
            };
            Button bB = new Button
            {
                Text = "B",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 50,
                HeightRequest = 90
            };
            Button bN = new Button
            {
                Text = "N",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 50,
                HeightRequest = 90
            };
            Button bM = new Button
            {
                Text = "M",

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                WidthRequest = 50,
                HeightRequest = 90
            };

            StackLayout botoes1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.End,
                Spacing = 0.3,
                Children =
                {

                    bQ,bW,bE,bR,bT,bY,bU,bI,bO,bP,
                    //bA,bS,bD,bF,bG,bH,bJ,bK,bL,
                   // bZ,bX,bC,bV,bB,bN,bM


                }


            };

            StackLayout botoes2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.End,
                Spacing = 0.2,
                Children =
                {


                    bA,bS,bD,bF,bG,bH,bJ,bK,bL



                }


            };

            StackLayout botoes3 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.End,
                Spacing = 0.5,
                Children =
                {

                    bZ,bX,bC,bV,bB,bN,bM


                }


            };


            StackLayout bttt = new StackLayout
            {

                Padding = 120,

            };


            bM.Clicked += BM_Clicked;

            bN.Clicked += BN_Clicked;

            bB.Clicked += BB_Clicked;

            bV.Clicked += BV_Clicked;

            bC.Clicked += BC_Clicked;

            bX.Clicked += BX_Clicked;

            bZ.Clicked += BZ_Clicked;

            //bÇ.Clicked += BÇ_Clicked;

            bL.Clicked += BL_Clicked;

            bK.Clicked += BK_Clicked;

            bJ.Clicked += BJ_Clicked;

            bH.Clicked += BH_Clicked;

            bG.Clicked += BG_Clicked;

            bF.Clicked += BF_Clicked;

            bD.Clicked += BD_Clicked;

            bA.Clicked += BA_Clicked;

            bP.Clicked += BP_Clicked;

            bO.Clicked += BO_Clicked;

            bI.Clicked += BI_Clicked;

            bU.Clicked += BU_Clicked;

            bY.Clicked += BY_Clicked;

            bR.Clicked += BR_Clicked;

            bW.Clicked += BW_Clicked;

            bQ.Clicked += BQ_Clicked;

            bT.Clicked += BT_Clicked;

            bS.Clicked += BS_Clicked;

            bE.Clicked += BE_Clicked;

            void BE_Clicked(object sender, EventArgs e)
            {
                var letra = 'E';

                bE.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BS_Clicked(object sender, EventArgs e)
            {
                var letra = 'S';

                bS.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BT_Clicked(object sender, EventArgs e)
            {
                var letra = 'T';

                bT.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BQ_Clicked(object sender, EventArgs e)
            {
                var letra = 'Q';

                bQ.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BW_Clicked(object sender, EventArgs e)
            {
                var letra = 'W';

                bW.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BR_Clicked(object sender, EventArgs e)
            {
                var letra = 'R';

                bR.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BY_Clicked(object sender, EventArgs e)
            {
                var letra = 'Y';

                bY.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BU_Clicked(object sender, EventArgs e)
            {
                var letra = 'U';

                bU.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BI_Clicked(object sender, EventArgs e)
            {
                var letra = 'I';

                bI.IsEnabled = false;

                Pesquisar_Letra(letra);
            }
            void BO_Clicked(object sender, EventArgs e)
            {
                var letra = 'O';

                bO.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BP_Clicked(object sender, EventArgs e)
            {
                var letra = 'P';

                bP.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BA_Clicked(object sender, EventArgs e)
            {
                var letra = 'A';

                bA.IsEnabled = false;

                Pesquisar_Letra(letra);
            }
            void BD_Clicked(object sender, EventArgs e)
            {
                var letra = 'D';

                bD.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BF_Clicked(object sender, EventArgs e)
            {
                var letra = 'F';

                bF.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BG_Clicked(object sender, EventArgs e)
            {
                var letra = 'G';

                bG.IsEnabled = false;

                Pesquisar_Letra(letra);
            }
            void BH_Clicked(object sender, EventArgs e)
            {
                var letra = 'H';

                bH.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BJ_Clicked(object sender, EventArgs e)
            {
                var letra = 'J';

                bJ.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BK_Clicked(object sender, EventArgs e)
            {
                var letra = 'K';

                bK.IsEnabled = false;

                Pesquisar_Letra(letra);
            }
            void BL_Clicked(object sender, EventArgs e)
            {
                var letra = 'L';

                bL.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

          /*  void BÇ_Clicked(object sender, EventArgs e)
            {
                var letra = 'Ç';

                bÇ.IsEnabled = false;

                Pesquisar_Letra(letra, palavra, desconhecida, lista, dica, bE, bS, bT);
            } */

            void BZ_Clicked(object sender, EventArgs e)
            {
                var letra = 'Z';

                bZ.IsEnabled = false;

                Pesquisar_Letra(letra);
            }
            void BX_Clicked(object sender, EventArgs e)
            {
                var letra = 'X';

                bX.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BC_Clicked(object sender, EventArgs e)
            {
                var letra = 'C';

                bC.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BV_Clicked(object sender, EventArgs e)
            {
                var letra = 'V';

                bV.IsEnabled = false;

                Pesquisar_Letra(letra);
            }
            void BB_Clicked(object sender, EventArgs e)
            {
                var letra = 'B';

                bB.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BN_Clicked(object sender, EventArgs e)
            {
                var letra = 'N';

                bN.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

            void BM_Clicked(object sender, EventArgs e)
            {
                var letra = 'M';

                bM.IsEnabled = false;

                Pesquisar_Letra(letra);
            }

           

            CriarLabel();

            Atualizar();

            void Atualizar()
            {


                BackgroundImage = "jogo.jpg";

                if (mestre == 1)
                {
                

                desconhecida = "";

                for (int x = 0; x < palavra.Length; x++)
                {
                    desconhecida += lista[x].Text;
                }


                    Content = new StackLayout
                {
                    Children = {
                new Label { Text = "    " + desconhecida,
                        TextColor = Color.Red,
                        HorizontalOptions = LayoutOptions.Center
                        },
                    new Label { Text ="Dica: " +dica + "               Tentativas: " + (erros+1)+"/5",TextColor = Color.Red,
                        HorizontalOptions = LayoutOptions.Center
                        },
                    new Label { Text ="Partida: "   + (partida+1) +   "                   Pontuação: "  + p2,TextColor = Color.Red,
                        HorizontalOptions = LayoutOptions.Center
                        },

                    bttt,

                    botoes1,
                    botoes2,
                    botoes3


                }

                    };

                }
                else
                {

                    desconhecida = "";

                    for (int x = 0; x < palavra.Length; x++)
                    {
                        desconhecida += lista[x].Text;
                    }

                    Content = new StackLayout
                    {
                        Children = {
                new Label { Text = "    " + desconhecida,TextColor = Color.Red,
                        HorizontalOptions = LayoutOptions.Center
                        },
                    new Label { Text = "Dica: " +dica + "              Tentativas: " + (erros + 1)+"/5",TextColor = Color.Red,
                        HorizontalOptions = LayoutOptions.Center
                        },
                    new Label { Text ="Partida: " + (partida+1)  +   "                   Pontuação: "  + p1,TextColor = Color.Red,
                        HorizontalOptions = LayoutOptions.Center
                        },

                    bttt,

                    botoes1,
                    botoes2,
                    botoes3

                }
                    };

                }


            }

            void Pesquisar_Letra(char letra)
            {


                var pontoporletra = 100 - (10 * palavra.Length) + (palavra.Length * palavra.Length); // pontuação por palavra

                var penalidadePorErro = 25 + (palavra.Length * palavra.Length);
                // ESSE É O ALGORITMO DA PONTUAÇÃO


                if (palavra.Contains(letra)|| palavra.Contains(char.ToLower(letra)))
                {
                    // se a palavra tiver a letra
                    char[] letras = palavra.ToCharArray();

                    for (int x = 0; x < palavra.Length; x++)
                    {
                        
                        if (char.ToUpper(letras[x]).Equals(letra))
                        {
                            lista[x].Text = letra.ToString();

                             //   if da pontuação pra saber o jogador que recebe
                                if(mestre == 1)
                                {
                                    p2 += pontoporletra;
                                }
                                else
                                {
                                    p1 += pontoporletra;
                                }

                                // contagem de acertos aumenta

                            acertos++;

                        }

                    }

                }//se não houver a letra na palavra
                else
                {

                    // aumenta a contagem de erros e diminui a pontuação
                    erros++;

                    if (mestre == 1)
                    {
                        p2 -= penalidadePorErro;
                    }
                    else
                    {
                        p1 -= penalidadePorErro;
                    }

                }

                if(erros == 5)
                {
                    // se os erros chegarem a 5

                    //aqui vai pra tela de game over muda o mestre----> volta pra trocou
                    player.Stop();

                    Navigation.PushModalAsync(new Errou2p(j1, j2, palavra, mestre, partida, p1, p2));
                }
                else
                {
                    if(acertos == palavra.Length)
                    {

                        player.Stop();

                        //se acertar tudo vai pra tela de congratulação

                        Navigation.PushModalAsync(new Acetou2p(j1, j2, palavra, mestre, partida, p1, p2));
                    }
                    else
                    {

                        //se não errou 5 ou acertou tudo atualiza a tela

                        Atualizar();

                    }



                }

                

            }

            void CriarLabel ()
        {
            for (int x = 0; x < palavra.Length; x++)
            {
                    // cria a label que vai ser exibida
                lista.Add(new Label());

                if(Char.IsLetter(palavra[x]))
                {
                    lista[x].Text = "–"; 
                }
                else
                {
                    lista[x].Text = palavra[x].ToString();
                        // se não for letra aumenta a contagem de acertos tbm
                        acertos++;
                }
            }


        }


        }


        protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }

        


    }
//}