using CONTROLES_VARIOS_BLL.Ecuaciones;
using CONTROLES_VARIOS_DAL.Ecuaciones;
using CONTROLES_VARIOS_BLL.Sumatoria;
using CONTROLES_VARIOS_DAL.Sumatoria;
using CONTROLES_VARIOS_DAL.Arreglo;
using CONTROLES_VARIOS_BLL.Arreglo;
using System;
using System.Windows.Forms;
using CONTROLES_VARIOS_DAL.Timer;
using CONTROLES_VARIOS_BLL.Timer;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CONTROLES_VARIOS_PL.Pantallas.General
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.CenterToScreen();
        }

        #region Instancias de clase DAL Y BLL Sumatoria

        Cls_Sumatoria_DAL objSumatoria_DAL = new Cls_Sumatoria_DAL();
        Cls_Sumatoria_BLL objSumatoria_BLL = new Cls_Sumatoria_BLL();

        #endregion

        #region Instancias de clase DAL Y BLL para llenar arreglo

        Cls_Arreglo_DAL objArreglo_DAL = new Cls_Arreglo_DAL();
        Cls_Arreglo_BLL objArreglo_BLL = new Cls_Arreglo_BLL();

        #endregion

        #region Instancias de clases para timer

        Cls_Timer_DAL objTimer_DAL = new Cls_Timer_DAL();
        Stopwatch stw = new Stopwatch();

        #endregion

        #region Metodos Personalizados

        private void SeleccionCheckBox(Cls_Arreglo_DAL objArreglo_DAL)
        {
            objArreglo_DAL.sContArrMod = "";
            txt_Cont_Arr_Check.Clear();
            btn_Llen_Arr_Check.Enabled = false;

            if (ch_Rem_Par.Checked == true && ch_Rem_Num_Men_D.Checked == true && ch_Rem_Num_May_Cin.Checked == false)
            {
                objArreglo_BLL.RemPar_Men(ref objArreglo_DAL);
                txt_Cont_Arr_Check.Text = objArreglo_DAL.sContArrMod.ToString();
            }
            else if (ch_Rem_Par.Checked == true && ch_Rem_Num_May_Cin.Checked == true && ch_Rem_Num_Men_D.Checked == false)
            {
                objArreglo_BLL.RemPar_May(ref objArreglo_DAL);
                txt_Cont_Arr_Check.Text = objArreglo_DAL.sContArrMod.ToString();
            }
            else if (ch_Rem_Num_Men_D.Checked == true && ch_Rem_Num_May_Cin.Checked == true && ch_Rem_Par.Checked == false)
            {
                objArreglo_BLL.RemMen_May(ref objArreglo_DAL);
                txt_Cont_Arr_Check.Text = objArreglo_DAL.sContArrMod.ToString();
            }
            else if (ch_Rem_Par.Checked == true && ch_Rem_Num_Men_D.Checked == true && ch_Rem_Num_May_Cin.Checked == true)
            {
                objArreglo_BLL.RemTodos(ref objArreglo_DAL);
                txt_Cont_Arr_Check.Text = objArreglo_DAL.sContArrMod.ToString();
            }
            else if (ch_Rem_Par.Checked == true && ch_Rem_Num_Men_D.Checked == false && ch_Rem_Num_May_Cin.Checked == false)
            {
                objArreglo_BLL.RemoverParesArreglo(ref objArreglo_DAL);
                txt_Cont_Arr_Check.Text = objArreglo_DAL.sContArrMod.ToString();
            }
            else if (ch_Rem_Num_Men_D.Checked == true && ch_Rem_Par.Checked == false && ch_Rem_Num_May_Cin.Checked == false)
            {
                objArreglo_BLL.RemMenoresDiez(ref objArreglo_DAL);
                txt_Cont_Arr_Check.Text = objArreglo_DAL.sContArrMod.ToString();
            }
            else if (ch_Rem_Num_May_Cin.Checked == true && ch_Rem_Num_Men_D.Checked == false && ch_Rem_Par.Checked == false)
            {
                objArreglo_BLL.RemMayoresCincuenta(ref objArreglo_DAL);
                txt_Cont_Arr_Check.Text = objArreglo_DAL.sContArrMod.ToString();
            }
            else
            {
                objArreglo_BLL.MostrarArregloOriginal(ref objArreglo_DAL);
                txt_Cont_Arr_Check.Text = objArreglo_DAL.sContArregloOr.ToString();
            }
        }
        private void ValidacionNumerosGen(ref TextBox textbox, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                if (e.KeyChar != 8)
                {
                    if (Convert.ToInt16(textbox.Text + e.KeyChar.ToString()) <= 200)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        private void ValidacionTxtVacioEcua(ref TextBox textbox, EventArgs e)
        {
            if (textbox.Text.Length == 0 || textbox.Text == "-0," || textbox.Text == "-0.")
            {
                errorProvider1.SetError(textbox, "caja de texto no puede dejarse en blanco ni con el valor ' -0, '");
                textbox.Focus();
            }
            else
            {
                errorProvider1.Clear();

            }

            if (txt_A.Text.Length != 0 && txt_B.Text.Length != 0 && txt_C.Text.Length != 0)
            {
                btn_Calcular_Ecua.Enabled = true;
            }
        }
        private void DiscriminanteSoluciones(ref Cls_Ecuaciones_DAL obj_Ecuaciones_DAL)
        {
            if (obj_Ecuaciones_DAL.dDiscr == 0)
            {
                MessageBox.Show("La ecuacion solo tiene una unica solucion", "Ecuaciones Cuadraticas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (obj_Ecuaciones_DAL.dDiscr < 0)
            {
                MessageBox.Show("La ecuacion no tiene solucion", "Ecuaciones Cuadraticas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (obj_Ecuaciones_DAL.dDiscr > 0)
            {
                MessageBox.Show("La ecuacion tiene dos soluciones", "Ecuaciones Cuadraticas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ValidacionTxtVacioArreglo(ref TextBox textbox, EventArgs e)
        {
            if (textbox.Text.Length == 0)
            {
                errorProvider1.SetError(textbox, "caja de texto no puede dejarse en blanco");
                textbox.Focus();
            }
            else
            {
                errorProvider1.Clear();

            }

            if (txt_Tam_Arreglo.Text.Length != 0 & txt_Lim_Random_Check.Text.Length != 0)
            {
                btn_Llen_Arr_Check.Enabled = true;
                txt_Lim_Random_Check.ReadOnly = true;
                txt_Tam_Arreglo.ReadOnly = true;
                btn_Limp_Check.Enabled = true;
            }
        }
        private void ValidacionNumerosEcua(ref TextBox textbox, KeyPressEventArgs e)
        {
            char cSeparador = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString().Trim());

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (Regex.IsMatch(textbox.Text, @"[\.,]\d\d\d"))
                {
                    if (e.KeyChar == '\b')
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-')
            {
                if (textbox.Text.Length == 0 || textbox.SelectionStart == 0 && !textbox.Text.Contains("-"))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == cSeparador)
            {
                if (textbox.Text.EndsWith("-"))
                {
                    e.Handled = true;
                }
                else
                {
                    if (textbox.Text.Length == 0 || textbox.Text.LastIndexOf((char)46) >= 0 || textbox.Text.LastIndexOf((char)44) >= 0)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }

            }
        }
        private void UbicacionCursor(ref TextBox textbox, MouseEventArgs e)
        {
            textbox.SelectionStart = textbox.Text.Length;
            textbox.SelectionLength = 0;

        }
        private void DeteccionFlechas(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Eventos Ecuaciones 
        private void btn_Limpiar_Ecua_Click(object sender, EventArgs e)
        {
            btn_Calcular_Ecua.Enabled = false;
            txt_A.Text = "";
            txt_B.Text = "";
            txt_C.Text = "";
            txt_Discr.Text = "";
            txt_Sol_I.Text = "";
            txt_Sol_II.Text = "";
            btn_Limpiar_Ecua.Enabled = false;
            txt_A.ReadOnly = false;
            txt_B.ReadOnly = false;
            txt_C.ReadOnly = false;
        }
        private void txt_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionNumerosEcua(ref textbox, e);
        }
        private void txt_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionNumerosEcua(ref textbox, e);
        }
        private void txt_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionNumerosEcua(ref textbox, e);
        }
        private void txt_A_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            UbicacionCursor(ref textbox, e);
        }
        private void txt_B_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            UbicacionCursor(ref textbox, e);
        }
        private void txt_C_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            UbicacionCursor(ref textbox, e);
        }
        private void txt_A_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacioEcua(ref textbox, e);
        }
        private void txt_B_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacioEcua(ref textbox, e);
        }
        private void txt_C_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacioEcua(ref textbox, e);
        }
        private void txt_A_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }
        private void txt_B_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }
        private void txt_C_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            #region Instancias de clases

            Cls_Ecuaciones_DAL objEcuaciones_DAL = new Cls_Ecuaciones_DAL();
            Cls_Ecuaciones_BLL objEcuaciones_BLL = new Cls_Ecuaciones_BLL();

            #endregion

            #region Llenado de datos DAL

            objEcuaciones_DAL.dNumbA = Convert.ToDouble(txt_A.Text);
            objEcuaciones_DAL.dNumbB = Convert.ToDouble(txt_B.Text);
            objEcuaciones_DAL.dNumbC = Convert.ToDouble(txt_C.Text);

            #endregion

            #region Metodos

            objEcuaciones_BLL.CalculoEcuaciones(ref objEcuaciones_DAL);

            DiscriminanteSoluciones(ref objEcuaciones_DAL);

            #endregion

            #region Llenado text box

            txt_Discr.Text = objEcuaciones_DAL.dDiscr.ToString();
            txt_Sol_I.Text = objEcuaciones_DAL.dSol_I.ToString();
            txt_Sol_II.Text = objEcuaciones_DAL.dSol_II.ToString();

            #endregion
            btn_Limpiar_Ecua.Enabled = true;
            btn_Calcular_Ecua.Enabled = false;
            txt_A.ReadOnly = true;
            txt_B.ReadOnly = true;
            txt_C.ReadOnly = true;
        }

        #endregion

        #region Eventos Sumatoria

        private void btn_Sum_Rad_Click(object sender, EventArgs e)
        {

            #region Metodo

            if (objSumatoria_DAL.uNum != Convert.ToUInt16(txt_Num_Lim_Rad.Text))
            {
                objSumatoria_DAL.uNum = Convert.ToUInt16(txt_Num_Lim_Rad.Text);
                objSumatoria_BLL.Sumatoria(ref objSumatoria_DAL);
            }

            if (rad_Sol_Pares.Checked == true)
            {
                txt_Resu_Sum_Rad.Text = objSumatoria_DAL.uResulPares.ToString();

            }
            else if (rad_Sol_Impar.Checked == true)
            {

                txt_Resu_Sum_Rad.Text = objSumatoria_DAL.uResulImpares.ToString();

            }
            else if (rad_Todos.Checked == true)
            {
                txt_Resu_Sum_Rad.Text = objSumatoria_DAL.uResulTotal.ToString();
            }

            #endregion

            btn_Limp_Rad.Enabled = true;
        }
        private void rad_Todos_Click(object sender, EventArgs e)
        {
            btn_Sum_Rad.Enabled = true;
        }
        private void rad_Sol_Pares_Click(object sender, EventArgs e)
        {
            btn_Sum_Rad.Enabled = true;
        }
        private void rad_Sol_Impar_Click(object sender, EventArgs e)
        {
            btn_Sum_Rad.Enabled = true;
        }
        private void txt_Num_Lim_Rad_Leave(object sender, EventArgs e)
        {
            if (txt_Num_Lim_Rad.Text.Length == 0)
            {
                errorProvider1.SetError(txt_Num_Lim_Rad, "caja de texto no puede dejarse en blanco");
                txt_Num_Lim_Rad.Focus();
            }
            else
            {
                errorProvider1.Clear();
                gr_Control_Radio.Enabled = true;
                txt_Num_Lim_Rad.ReadOnly = true;
                btn_Limp_Rad.Enabled = true;
            }
        }
        private void btn_Limp_Rad_Click(object sender, EventArgs e)
        {
            txt_Num_Lim_Rad.ReadOnly = false;
            gr_Control_Radio.Enabled = false;
            btn_Sum_Rad.Enabled = false;
            btn_Limp_Rad.Enabled = false;
            rad_Sol_Impar.Checked = false;
            rad_Sol_Pares.Checked = false;
            rad_Todos.Checked = false;
            txt_Num_Lim_Rad.Text = "";
            txt_Resu_Sum_Rad.Text = "";
        }
        private void txt_Num_Lim_Rad_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionNumerosGen(ref textbox, e);
        }
        private void txt_Num_Lim_Rad_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            UbicacionCursor(ref textbox, e);
        }
        private void txt_Num_Lim_Rad_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }
        #endregion

        #region Eventos Arreglos 
        private void btn_Llen_Arr_Check_Click(object sender, EventArgs e)
        {
            #region Llenado de datos

            objArreglo_DAL.uTamArreglo = Convert.ToUInt16(txt_Tam_Arreglo.Text);
            objArreglo_DAL.uLimRandom = Convert.ToUInt16(txt_Lim_Random_Check.Text);

            #endregion

            #region Metodos

            objArreglo_BLL.LlenadoArreglo(ref objArreglo_DAL);

            MessageBox.Show("Se lleno el arreglo exitosamente", "Arreglo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            #endregion

            #region Habilitacion de botones y checkbox

            btn_Llen_Arr_Check.Enabled = false;
            btn_Ver_Arr_Check.Enabled = true;
            ch_Rem_Par.Enabled = true;
            ch_Rem_Num_May_Cin.Enabled = true;
            ch_Rem_Num_Men_D.Enabled = true;
            txt_Cont_Arr_Check.Text = "";


            #endregion

        }
        private void btn_Ver_Arr_Check_Click(object sender, EventArgs e)
        {
            SeleccionCheckBox(objArreglo_DAL);
        }
        private void txt_Lim_Random_Check_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }
        private void txt_Tam_Arreglo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionNumerosGen(ref textbox, e);
        }
        private void txt_Lim_Random_Check_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionNumerosGen(ref textbox, e);
        }
        private void txt_Tam_Arreglo_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacioArreglo(ref textbox, e);
        }
        private void txt_Lim_Random_Check_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacioArreglo(ref textbox, e);
        }
        private void btn_Limp_Check_Click(object sender, EventArgs e)
        {
            txt_Tam_Arreglo.ReadOnly = false;
            txt_Lim_Random_Check.ReadOnly = false;
            btn_Llen_Arr_Check.Enabled = false;
            btn_Ver_Arr_Check.Enabled = false;
            ch_Rem_Par.Enabled = false;
            ch_Rem_Par.Checked = false;
            ch_Rem_Num_May_Cin.Enabled = false;
            ch_Rem_Num_May_Cin.Checked = false;
            ch_Rem_Num_Men_D.Enabled = false;
            ch_Rem_Num_Men_D.Checked = false;
            btn_Limp_Check.Enabled = false;
            txt_Tam_Arreglo.Text = "";
            txt_Lim_Random_Check.Text = "";
            txt_Cont_Arr_Check.Text = "";

        }
        private void txt_Tam_Arreglo_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            UbicacionCursor(ref textbox, e);
        }
        private void txt_Lim_Random_Check_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            UbicacionCursor(ref textbox, e);
        }
        private void txt_Tam_Arreglo_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        #endregion

        #region Eventos Timer

        private void btn_Ini_Timer_Click(object sender, EventArgs e)
        {
            objTimer_DAL.bMinutosLimite = Convert.ToByte(txt_Tiemp_Timer.Text);
            stw.Start();
            tim_Crono.Enabled = true;
            btn_Det_Tim.Enabled = true;
            btn_Limp_Timer.Enabled = false;
            txt_Tiemp_Timer.ReadOnly = true;
            btn_Ini_Timer.Enabled = false;
        }
        private void tim_Crono_Tick(object sender, EventArgs e)
        {
            if (Convert.ToByte(txt_Min.Text) == objTimer_DAL.bMinutosLimite)
            {
                stw.Stop();
                btn_Det_Tim.Enabled = false;
                btn_Limp_Timer.Enabled = true;
            }
            else
            {
                TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stw.ElapsedMilliseconds);

                txt_Min.Text = ts.Minutes.ToString();
                txt_Seg.Text = ts.Seconds.ToString();
                txt_Mili.Text = ts.Milliseconds.ToString();
            }

        }
        private void btn_Det_Tim_Click(object sender, EventArgs e)
        {
            stw.Stop();
            tim_Crono.Enabled = false;
            btn_Limp_Timer.Enabled = true;
            btn_Ini_Timer.Enabled = true;
        }
        private void btn_Limp_Timer_Click(object sender, EventArgs e)
        {
            stw.Reset();
            tim_Crono.Enabled = false;
            txt_Min.Text = "0";
            txt_Seg.Text = "0";
            txt_Mili.Text = "0";
            txt_Tiemp_Timer.ReadOnly = false;
            txt_Tiemp_Timer.Text = "";
            btn_Ini_Timer.Enabled = false;
            btn_Det_Tim.Enabled = false;
        }
        private void txt_Tiemp_Timer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                if (e.KeyChar != 8)
                {
                    if (Convert.ToByte(txt_Tiemp_Timer.Text + e.KeyChar.ToString()) <= 5)
                    {
                        e.Handled = false;
                        btn_Ini_Timer.Enabled = true;
                        btn_Limp_Timer.Enabled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txt_Tiemp_Timer_Leave(object sender, EventArgs e)
        {
            if (txt_Tiemp_Timer.Text.Length == 0)
            {
                errorProvider1.SetError(txt_Tiemp_Timer, "caja de texto no puede dejarse en blanco");
                txt_Tiemp_Timer.Focus();
                btn_Ini_Timer.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txt_Tiemp_Timer_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            UbicacionCursor(ref textbox, e);
        }
        private void txt_Tiemp_Timer_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }
        #endregion

        private void txt_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
