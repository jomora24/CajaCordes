using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaCordes
{
    public partial class FormRegistroBeneficiarios : Form
    {
        DBConexion db = new DBConexion();
        public FormRegistroBeneficiarios()
        {
            InitializeComponent();

            txt_materno.Visible = false;
            txt_nombre.Visible = false;
            txt_paterno.Visible = false;
        }

        private void btn_buscar_titular_Click(object sender, EventArgs e)
        {
            if (txt_buscar_titular.Text == "")
            {
                MessageBox.Show("Debes Buscar Atraves del codigo de asegurado del Titular", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_buscar_titular.Focus();
            }
            else
            {
                db.CrearConexion();
                if (db.existeTitular(txt_buscar_titular.Text))
                {
                    MessageBox.Show("El titular si Exite, Favor llene sus datos", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_materno.Visible = true;
                    txt_nombre.Visible = true;
                    txt_paterno.Visible = true;
                    db.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("El titular no Exite", "No Exite!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingresa el nombrer", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }
            else if (txt_paterno.Text == "")
            {
                MessageBox.Show("Falta apellido paterno.", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_paterno.Focus();
            }
            else if (txt_materno.Text == "")
            {
                MessageBox.Show("Falta apellido materno.", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_materno.Focus();
            }
            else if (cbox_parentesco.Text == "")
            {
                MessageBox.Show("Escoge el parentesco.", "Alerta!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbox_parentesco.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de editar los datos", "Alerta de Confirmacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        db.CrearConexion();
                        db.InsertRegistro(txt_nombre.Text, txt_materno.Text, txt_paterno.Text, cbox_parentesco.Text, txt_buscar_titular.Text);
                        db.CerrarConexion();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Al Registrar datos");
                        throw;
                    }

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}
