using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinepolisproyect.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        List<CineItemCmbClass> nombre;
        public HomePage()
        {
            InitializeComponent();
            InitApp();
        }

        private void InitApp()
        {
            nombre = new List<CineItemCmbClass>();
            nombre.Add(new CineItemCmbClass {name=" Tegucigalpa"});
            nombre.Add(new CineItemCmbClass {name = " SPS" });
            foreach(var cinevar in nombre) { CmbCine.Items.Add(cinevar.name); }
        }

        private void CmbCine_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = CmbCine.SelectedIndex;
            if (position>-1)
            {
                CmbOptions.Color = nombre[position].cine;
            }
        }
    }
}