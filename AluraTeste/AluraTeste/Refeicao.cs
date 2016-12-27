namespace AluraTeste
{
    public class Refeicao
    {
        public string Descricao { get; set; }
        public double Calorias { get; set; }

        public Refeicao (string descricao, double calorias)
        {
            this.Descricao = descricao;
            this.Calorias = calorias;
        }
    }
}
