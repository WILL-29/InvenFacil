using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvenFacil
{
    class Methods
    {
        static void Limpiar(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is DateTime)
                {
                    ((DateTimePicker)c).ResetText();
                }
                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                    ((DataGridView)c).Refresh();
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c is ComboBox)
                {
                    ((PictureBox)c).Text = string.Empty;
                }
            }
        }
    }
}
