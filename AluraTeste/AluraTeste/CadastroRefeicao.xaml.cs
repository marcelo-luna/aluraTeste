using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace AluraTeste
{
    public partial class CadastroRefeicao : ContentPage
    {
        public ObservableCollection<Refeicao> Refeicoes { get; set; }
        public CadastroRefeicao(ObservableCollection<Refeicao> refeicoes)
        {
            Refeicoes = refeicoes;
            InitializeComponent();
        }

        public void Atualiza(Object sender, EventArgs e)
        {
            double stpValue = slrCalorias.Value;
            lblCalorias.Text = stpValue.ToString();
        }

        public void SalvarRefeicao(Object sender, EventArgs e)
        {
            string sDescricao = entDescricao.Text;
            double sValor = slrCalorias.Value;

            Refeicao refe = new Refeicao(sDescricao, sValor);
            Refeicoes.Add(refe);

            DisplayAlert("Salvar Refeição", $"A refeição {sDescricao} de {sValor} calorias foi salva com sucesso!","Ok");
            Clear();
        }

        public void Clear()
        {
            entDescricao.Text = "";
            lblCalorias.Text = "10";
        }
    }
}
