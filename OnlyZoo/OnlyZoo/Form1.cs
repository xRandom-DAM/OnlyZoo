using OnlyZoo.components;
using OnlyZoo.models;
using OnlyZoo.util;

namespace OnlyZoo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitPetButtons();
            InitializeEvents();
        }

        private void InitPetButtons()
        {
            DataBuffer.GetInstance().PetCollection.ForEach(pet => this.flowLayoutPanel_Mascotas.Controls.Add(new PetButton(pet)));
        }

        /// <summary>
        /// Metodo que iniciliza eventos y asigna funcionalidades al Diseño.
        /// </summary>
        private void InitializeEvents()
        {
                      
        }

    }
}