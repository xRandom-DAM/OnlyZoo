using OnlyZoo.models;

namespace OnlyZoo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeEvents();
        }

        /// <summary>
        /// Metodo que iniciliza eventos y asigna funcionalidades al Diseño.
        /// </summary>
        private void InitializeEvents()
        {
            //create_BtnPet_InFlowLayout();  //Añadir por parámetros una lista Pet
        }

        /// <summary>
        /// Metodo que genera Botones a partir de una Lista que contiene Clase Pet.
        /// </summary>
        /// <param name="lista"></param>
        private void create_BtnPet_InFlowLayout(List<Pet> lista)
        {
            Button button;
            foreach (Pet pet in lista)
            {
                string nombreBtn = "Id_" + pet.Id;
                button = new Button();
                button.Text = pet.Name;
                button.Name = nombreBtn;
                button.TextAlign = ContentAlignment.BottomCenter;
                this.flowLayoutPanel_Mascotas.Controls.Add(button);
                button.Click += new System.EventHandler(this.MostrarPet);
            }
        }

        /// <summary>
        /// A partir de un String que contiene el Id de una mascota 
        /// desarrollar "Interfaz de la mascota" Tarea 11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarPet(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string pet_ID = button.Name; //Example --> "Id_12"
                MessageBox.Show("Muestra Contenido sobre la mascota elegida: " + pet_ID);
                
            }
        }
    }
}