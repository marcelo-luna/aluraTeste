using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace AluraTeste
{
    public class HometabbedPage : TabbedPage
    {
        public HometabbedPage()
        {
            this.Children.Add(new CadastroRefeicao());
            this.Children.Add(new ListaRefeicoes());
        }
    }
}
