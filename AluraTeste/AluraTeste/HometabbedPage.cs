using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace AluraTeste
{
    public class HometabbedPage : TabbedPage
    {
        public HometabbedPage()
        {
            ObservableCollection<Refeicao> refeicoes = new ObservableCollection<Refeicao>();

            this.Children.Add(new CadastroRefeicao(refeicoes));
            this.Children.Add(new ListaRefeicoes(refeicoes));
        }
    }
}
