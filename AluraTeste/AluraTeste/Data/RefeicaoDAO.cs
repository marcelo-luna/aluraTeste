using SQLite;
namespace AluraTeste.Data
{
    public class RefeicaoDAO
    {
        private SQLiteConnection conexao;
        public RefeicaoDAO(SQLiteConnection con)
        {
            conexao = con;
        }

        public void salvar(Refeicao refeicao)
        {
            conexao.Insert(refeicao);
        }
    }
}
