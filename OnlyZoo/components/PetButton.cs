using OnlyZoo.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.components
{
    internal class PetButton : Button
    {
        public PetButton(Pet pet) 
        {
            string nombreBtn = "Id_" + pet.Id;
            Text = pet.Name;
            Name = nombreBtn;
            TextAlign = ContentAlignment.BottomCenter;
            
            Click += new System.EventHandler(this.MostrarPet);
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
