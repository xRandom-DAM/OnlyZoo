using OnlyZoo.models;
using OnlyZoo.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyZoo
{
    public partial class InfoMascota : Form
    {
        private Pet Mascota;
        private Breed Raza;
        public InfoMascota(Pet mascota)
        {
            Mascota = mascota;
            Raza = DataBuffer.GetInstance().GetBreed(Mascota);
            InitializeComponent();
            InitPetData();
        }

        private void InitPetData()
        {
            lblShowID.Text = Mascota.Id.ToString();
            lblShowSpecies.Text = Raza.Species;
            lblShowKind.Text = Raza.Kind;
            lblShowName.Text = Mascota.Name;
            lblShowDescription.Text = Mascota.Description;
        }
    }
}
