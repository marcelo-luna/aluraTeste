using System;
using System.Collections.ObjectModel;
using AluraTeste.Data;
using Xamarin.Forms;

namespace AluraTeste
{
    public partial class CadastroRefeicao : ContentPage
    {
        private RefeicaoDAO dao;

        public CadastroRefeicao(RefeicaoDAO dao)
        {
            this.dao = dao;
            InitializeComponent();
        }

        public void Atualiza(Object sender, EventArgs e)
        {
            double stpValue = slrCalorias.Value;
            lblCalorias.Text = stpValue.ToString();
        }

        public async void SalvarRefeicao(Object sender, EventArgs e)
        {
            string sDescricao = entDescricao.Text;
            double sValor = slrCalorias.Value;

            Refeicao refe = new Refeicao(sDescricao, sValor);
            dao.salvar(refe);

            await DisplayAlert("Salvar Refeição", $"A refeição {sDescricao} de {sValor} calorias foi salva com sucesso!","Ok");
            Clear();
        }

        public void Clear()
        {
            entDescricao.Text = "";
            lblCalorias.Text = "0";
            slrCalorias.Value = 0;
        }
    }
}
