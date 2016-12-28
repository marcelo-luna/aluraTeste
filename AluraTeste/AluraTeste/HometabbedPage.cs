using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;
using AluraTeste.Data;

namespace AluraTeste
{
    public class HometabbedPage : TabbedPage
    {
        public HometabbedPage()
        {
            ObservableCollection<Refeicao> refeicoes = new ObservableCollection<Refeicao>();

            SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();
            RefeicaoDAO dao = new RefeicaoDAO(con);

            CadastroRefeicao telaCadastro = new CadastroRefeicao(refeicoes, dao);
            ListaRefeicoes telaLista = new ListaRefeicoes(refeicoes);

            this.Children.Add(telaCadastro);
            this.Children.Add(telaLista);
        }
    }
}
