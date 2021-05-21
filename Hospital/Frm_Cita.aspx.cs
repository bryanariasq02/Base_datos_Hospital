using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Frm_Cita : System.Web.UI.Page
    {
        Cls_Cita objcita = new Cls_Cita();
        Cls_Paciente objpaciente = new Cls_Paciente();
        Cls_Medico objmedico = new Cls_Medico();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Txt_Codigo.Focus();
            }
        }

        protected void Brn_Cita_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text.Trim() == "")
            {
                LblMensaje.Text = "El codigo es requerido";
                Txt_Codigo.Focus();
            }
            else
            {
                LblMensaje.Text = "";
                DataSet ds = new DataSet();
                ds = objcita.concultar_cita(Txt_Codigo.Text);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LblMensaje.Text = "Cita no encontrada";
                    Txt_Fecha.Text = System.DateTime.Now.ToShortDateString();
                    Txt_Hora.Text = System.DateTime.Now.ToShortTimeString();
                    Txt_Hora.Enabled = true;
                    Txt_Fecha.Enabled = true;
                    Ddl_Consultorio.Enabled = true;
                    Txt_Paciente.Enabled = true;
                    Btn_Paciente.Enabled = true;
                    Txt_Paciente.Focus();


                }
                else
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["activo"].ToString()) == false)
                    {
                        LblMensaje.Text = "Registro Existe Pero Esta Anulado";
                    }
                    else
                    {
                        LblMensaje.Text = "Cita ya existe";
                        Txt_Fecha.Text = ds.Tables[0].Rows[0]["Fecha"].ToString();
                        Txt_Hora.Text = ds.Tables[0].Rows[0]["Hora"].ToString();
                        Ddl_Consultorio.Text = ds.Tables[0].Rows[0]["Consultorio"].ToString();
                        Txt_Hora.Text = ds.Tables[0].Rows[0]["Hora"].ToString();
                        Txt_Paciente.Text = ds.Tables[0].Rows[0]["Id_Paciente"].ToString();
                        LblNomPaciente.Text = ds.Tables[1].Rows[0]["Nom_paciente"].ToString();
                        LblTelPaciente.Text = ds.Tables[1].Rows[0]["tel_paciente"].ToString();
                        Txt_Medico.Text = ds.Tables[0].Rows[0]["Id_Medico"].ToString();
                        LblNomMedico.Text = ds.Tables[2].Rows[0]["Nom_Medico"].ToString();
                        LblEspMedico.Text = ds.Tables[2].Rows[0]["Especialidad"].ToString();
                        Txt_Valor.Text = ds.Tables[0].Rows[0]["Valor"].ToString();
                        Txt_Observaciones.Text = ds.Tables[0].Rows[0]["Observaciones"].ToString();
                        Txt_Hora.Enabled = true;
                        Txt_Fecha.Enabled = true;
                        Ddl_Consultorio.Enabled = true;
                        Txt_Paciente.Enabled = true;
                        Btn_Paciente.Enabled = true;
                        Txt_Medico.Enabled = true;
                        Txt_Valor.Enabled = true;
                        Txt_Observaciones.Enabled = true;
                        Btn_Guardar.Enabled = true;
                        Btn_Anular.Enabled = true;
                        Btn_medico.Enabled = true;
                    }
                }

            }
        }

        protected void Btn_Paciente_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = objpaciente.consulta_paciente(Txt_Paciente.Text);
            if (Txt_Paciente.Text.Trim() == "")
            {
                LblMensaje.Text = "Digite la Identificacion del paciente";
                Txt_Paciente.Focus();
            }
            else
            {

                if (ds.Tables[0].Rows.Count == 0)
                {
                    LblMensaje.Text = "El paciente no esta registrado";
                    Txt_Paciente.Focus();
                }
                else
                {
                    LblMensaje.Text = "";
                    LblNomPaciente.Text = ds.Tables[0].Rows[0]["Nom_paciente"].ToString();
                    LblTelPaciente.Text = ds.Tables[0].Rows[0]["tel_paciente"].ToString();
                    Txt_Medico.Enabled = true;
                    Btn_medico.Enabled = true;
                    Txt_Medico.Focus();
                }
            }
        }

        protected void Btn_medico_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = objmedico.consulta_medico(Txt_Medico.Text);
            if (Txt_Paciente.Text.Trim() == "")
            {
                LblMensaje.Text = "Digite la Identificacion del medico";
                Txt_Paciente.Focus();
            }
            else
            {

                if (ds.Tables[0].Rows.Count == 0)
                {
                    LblMensaje.Text = "El medico no esta registrado";
                    Txt_Paciente.Focus();
                }
                else
                {
                    LblMensaje.Text = "";
                    LblNomMedico.Text = ds.Tables[0].Rows[0]["Nom_Medico"].ToString();
                    LblEspMedico.Text = ds.Tables[0].Rows[0]["Especialidad"].ToString();
                    Txt_Valor.Enabled = true;
                    Txt_Valor.Focus();
                    Txt_Observaciones.Enabled = true;
                    Btn_Guardar.Enabled = true;
                }
            }
        }

        protected void limpiar_Campos()
        {
            Txt_Codigo.Text = "";
            Txt_Fecha.Text = "";
            Txt_Hora.Text = "";
            Txt_Medico.Text = "";
            Txt_Observaciones.Text = "";
            Txt_Paciente.Text = "";
            Txt_Valor.Text = "";
            LblEspMedico.Text = "";
            LblNomMedico.Text = "";
            LblNomPaciente.Text = "";
            LblTelPaciente.Text = "";
            Ddl_Consultorio.Text = "101";
        }

        protected void Desactivar_Campos()
        {
            Txt_Valor.Enabled = false;
            Txt_Paciente.Enabled = false;
            Txt_Observaciones.Enabled = false;
            Txt_Medico.Enabled = false;
            Txt_Hora.Enabled = false;
            Txt_Fecha.Enabled = false;
            Btn_Anular.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_medico.Enabled = false;
            Btn_Paciente.Enabled = false;
            Ddl_Consultorio.Enabled = false;
            Txt_Codigo.Focus();
        }

        protected void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (objcita.guardat_cita(Txt_Codigo.Text, Txt_Fecha.Text, Txt_Hora.Text, Ddl_Consultorio.Text, Txt_Paciente.Text, Txt_Medico.Text, Convert.ToInt32(Txt_Valor.Text), Txt_Observaciones.Text))
            {
                LblMensaje.Text = "Registro guardado";
                limpiar_Campos();
                Desactivar_Campos();
            }
            else
            {
                LblMensaje.Text = "Registro no guardado";
            }

        }

        protected void Btn_Anular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Anular este registro?" , "Eliminar", MessageBoxButtons.YesNo , MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (objcita.anular_cita(Txt_Codigo.Text))
                    {
                        LblMensaje.Text = "Cita Anulada";
                        limpiar_Campos();
                        Desactivar_Campos();
                    }
                else
                     {
                        LblMensaje.Text = "Cita No Anulada";
                     }
            } 
                        
        }

        protected void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar_Campos();
            Desactivar_Campos();
        }
    }
}