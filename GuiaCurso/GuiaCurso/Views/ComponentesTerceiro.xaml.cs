﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using GuiaCurso.Models;

namespace GuiaCurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Name = "Segurança de Sistemas de Informação. ",

                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança da informação. ",

                    ValoresAtitudes = "Estimular atitudes respeitosas. Incentivar comportamentos éticos. Desenvolver a criticidade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Name = "Banco de Dados III ",

                    AtribuicoesResponsabilidades = "Realizar gestão de bancos de dados. ",

                    ValoresAtitudes = "Incentivar a criatividade. Desenvolver a criticidade. Fortalecer a persistência e o interesse na resolução de situações-probçema. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Name = "Sistemas Embarcados",

                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados. ",

                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. Estimular a organização. Incentivar a criatividade."
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Name = "Programação de Aplicativos Mobile II ",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis. ",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. Incentivar a criatividade. Estimular a organização. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Name = "Programação Web III",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para web. ",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. Fortalecer a persistência e o interesse na resolução de situações-problema. Incentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Name = "Qualidade e Teste de Software",

                    AtribuicoesResponsabilidades = "Testar softwares para melhoria de sistemas. Elaborar registros e planilhas de acompanhamento e controle das atividades. ",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. Estimular a proatividade. Desenvolver vriticidade. Incentivar comportamentos éticos. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Name = "Ética e Cidadania Organizacional. ",

                    AtribuicoesResponsabilidades = "Atuar de acordo com princípios éticos nas relções de trabalho. ",

                    ValoresAtitudes = "Estimular atitudes respeitosas. Incentivar comportamentos éticos. Comprometer-se com a igualdade de direitos. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Name = "Desenvolvimento de Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas ",

                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais.",

                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas. Demonstrar comprometimento com equipe e o trabalho. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}