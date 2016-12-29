using System.ComponentModel;
using System.Windows.Input;
using AluraTeste.Data;
using Xamarin.Forms;

namespace AluraTeste.ViewModel
{
    public class CadastroRefeicaoViewModel : INotifyPropertyChanged
    {
        private string descricao;
        private double calorias;

        public string Descricao
        {
            get { return descricao; }
            set
            {
                if (value != descricao)
                {
                    descricao = value;
                    OnPropertyChanged("Descricao");
                }
            }
        }

        public double Calorias
        {
            get { return calorias; }
            set
            {
                if (value != calorias)
                {
                    calorias = value;
                    OnPropertyChanged("Calorias");
                }
            }
        }

        public ICommand SalvaRefeicao { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private RefeicaoDAO dao;
        private ContentPage page;

        public CadastroRefeicaoViewModel(RefeicaoDAO dao, ContentPage page)
        {
            this.dao = dao;
            this.page = page;

            SalvaRefeicao = new Command(() =>
            {
                Refeicao refeicao = new Refeicao(descricao, calorias);
                dao.salvar(refeicao);
                page.DisplayAlert("Salvar Refeição",$"A refeição {descricao} de {calorias} calorias foi salva com sucesso!", "Ok");
                Descricao = string.Empty;
                Calorias = 0;
            });
        }

        private void OnPropertyChanged(string nome)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nome));
        }
    }
}
