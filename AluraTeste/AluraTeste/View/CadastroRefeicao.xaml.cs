using System;
using AluraTeste.Data;
using AluraTeste.ViewModel;
using Xamarin.Forms;

namespace AluraTeste
{
    public partial class CadastroRefeicao : ContentPage
    {
        public CadastroRefeicao(RefeicaoDAO dao)
        {
            CadastroRefeicaoViewModel vm = new CadastroRefeicaoViewModel(dao, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
