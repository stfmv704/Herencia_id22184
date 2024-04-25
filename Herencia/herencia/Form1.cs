using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    /*Clase principal o clase para que guardara lo metodos de lectura de
     * lod valores y almacenados de valores en variable*/
    //nombre de clase   
    class operacion
    {
        //declaracion de variables que usa la clase 
        //tipo de acceso        tipo de dato     nombre de dato
        protected int valor1;
        protected int valor2;
        protected int resultado;

    }
    /// <summary>
    /// Punto de entrada principal para la aplicacion 
    /// </summary>
    [STAThread]             
    


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
