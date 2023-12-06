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
        Pet Mascota { get; set; }
        public PetButton(Pet pet) 
        {
            Mascota = pet;
            string nombreBtn = "Id_" + pet.Id;
            Text = pet.Name;
            Name = nombreBtn;
            TextAlign = ContentAlignment.BottomCenter;
            Click += this.MostrarPet;
        }

        /// <summary>
        /// A partir de un String que contiene el Id de una mascota 
        /// desarrollar "Interfaz de la mascota" Tarea 11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MostrarPet(object sender, EventArgs e)
        {
            new InfoMascota(Mascota);
        }
    }

}
