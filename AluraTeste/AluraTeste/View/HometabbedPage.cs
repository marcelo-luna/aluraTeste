using SQLite;
using Xamarin.Forms;
using AluraTeste.Data;

namespace AluraTeste
{
    public class HometabbedPage : TabbedPage
    {
        public HometabbedPage()
        {
            SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();
            RefeicaoDAO dao = new RefeicaoDAO(con);


            CadastroRefeicao telaCadastro = new CadastroRefeicao(dao);
            ListaRefeicoes telaLista = new ListaRefeicoes(dao);

            this.Children.Add(telaCadastro);
            this.Children.Add(telaLista);
        }
    }
}
