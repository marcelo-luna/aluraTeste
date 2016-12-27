using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace AluraTeste
{
    public partial class ListaRefeicoes : ContentPage
    {
        public ObservableCollection<Refeicao> Refeicoes { get; set; }
        public ListaRefeicoes(ObservableCollection<Refeicao> refeicoes)
        {
            Refeicoes = refeicoes;
            BindingContext = this;
            InitializeComponent();
        }

        public async void AcaoItem(Object sender, ItemTappedEventArgs e)
        {
            Refeicao refeicao = e.Item as Refeicao;
            var displarAnswer = await DisplayAlert("Remover Item", $"Deseja remover  {refeicao.Descricao} ?","Sim","Não");

            if (displarAnswer)
            {
                Refeicoes.Remove(refeicao);
                await DisplayAlert("Remover Item","Refeição Removida", "OK");
            }
        }
    }
}
