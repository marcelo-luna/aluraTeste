using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AluraTeste
{
    public partial class CadastroRefeicao : ContentPage
    {
        public CadastroRefeicao()
        {
            InitializeComponent();
        }

        public void Atualiza(Object sender, EventArgs e)
        {
            //double stpValue = stpContadorCalorias.Value;
            double stpValue = slrCalorias.Value;
            lblCalorias.Text = stpValue.ToString();
        }

        public void SalvarRefeicao(Object sender, EventArgs e)
        {
            //string sDescricao = entDescricao.Text;
            string sDescricao = entDescricao.Text;
            double sValor = slrCalorias.Value;

            DisplayAlert("Salvar Refeição", $"A refeição {sDescricao} de {sValor} calorias foi salva com sucesso!","Ok");

            Clear();
        }

        public void Clear()
        {
            entDescricao.Text = "";
            lblCalorias.Text = "10";
        }

        public void MostraLista(Object sender, EventArgs e)
        {
            ListaRefeicoes tela = new ListaRefeicoes();
            Navigation.PushAsync(tela);
        }
    }
}
