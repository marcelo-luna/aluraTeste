using System;
using System.Collections.ObjectModel;
using AluraTeste.Data;
using Xamarin.Forms;

namespace AluraTeste
{
    public partial class ListaRefeicoes : ContentPage
    {
        public ObservableCollection<Refeicao> Refeicoes { get; set; }
        private RefeicaoDAO dao;

        public ListaRefeicoes(RefeicaoDAO dao)
        {
            Refeicoes = dao.Lista;
            this.dao = dao;
            BindingContext = this;
            InitializeComponent();
        }

        public async void AcaoItem(Object sender, ItemTappedEventArgs e)
        {
            try
            {
                Refeicao refeicao = e.Item as Refeicao;
            var displarAnswer = await DisplayAlert("Remover Item", $"Deseja remover  {refeicao.Descricao} ?","Sim","Não");

            if (displarAnswer)
            {
                dao.Remove(refeicao);
                await DisplayAlert("Remover Item","Refeição Removida", "OK");
            }
            }
            catch (Exception)
            {

                await DisplayAlert("Erro", "Ocorreu um erro", "OK");
            }
            
        }
    }
}
