using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Guía1
{
    public partial class Form1 : Form
    {
        int x, y; //Utilizado para la posición del mouse
        Graphics lienzo;
            
        public Form1()
        {
            InitializeComponent();
            lienzo = panel1.CreateGraphics();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            cmbColores.Items.AddRange(colores);

            panel1.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            /*
            Pen Lapiz = new Pen(Color.DarkRed);
            int tamaño = Convert.ToInt16(nmcTamaño.Value);
            int opcion = lstboxFiguras.SelectedIndex;

            switch(opcion) //Se pudo haber trabajado solamente con if's o else's pero con Switch es mas facil
            {
                case 0: //Si la figura es un circulo
                    break;

                case 1://Si la figura es un rectangulo
                    lienzo.DrawRectangle(Lapiz, x, y, tamaño,tamaño);
                    break;

                default:
                    break;
            }*/
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            x = panel1.PointToClient(Cursor.Position).X;
            y = panel1.PointToClient(Cursor.Position).Y;
            Color color = Color.FromName(cmbColores.SelectedItem.ToString());

            Pen Lapiz = new Pen(color);
            SolidBrush pincel = new SolidBrush(color);
            int tamaño = Convert.ToInt16(nmcTamaño.Value);
            int opcion = lstboxFiguras.SelectedIndex;


            switch (opcion) //Se pudo haber trabajado solamente con if's o else's pero con Switch es mas facil
            {
                case 0: //Si la figura es un circulo
                    lienzo.DrawEllipse(Lapiz, x - tamaño / 2, y - tamaño / 2, tamaño, tamaño);
                    lienzo.FillEllipse(pincel, x - tamaño / 2, y - tamaño / 2, tamaño, tamaño);
                    break;

                case 1://Si la figura es un rectangulo
                    lienzo.DrawRectangle(Lapiz, x, y, tamaño, tamaño);
                    lienzo.FillRectangle(pincel, x, y, tamaño, tamaño);
                    break;

                default:
                    MessageBox.Show("Debe de seleccionar una figura");
                    break;
            }

        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbColores_SelectedValueChanged(object sender, EventArgs e)
        {

            panel1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
