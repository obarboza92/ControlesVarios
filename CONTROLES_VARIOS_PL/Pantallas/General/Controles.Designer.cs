
namespace CONTROLES_VARIOS_PL.Pantallas.General
{
    partial class Controles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controles));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EcuacionesCuadraticas = new System.Windows.Forms.TabPage();
            this.gr_Informacion_Ecuacion = new System.Windows.Forms.GroupBox();
            this.txt_Sol_II = new System.Windows.Forms.TextBox();
            this.txt_Sol_I = new System.Windows.Forms.TextBox();
            this.txt_Discr = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_Sol_I = new System.Windows.Forms.Label();
            this.lab_Discr = new System.Windows.Forms.Label();
            this.lab_C = new System.Windows.Forms.Label();
            this.lab_B = new System.Windows.Forms.Label();
            this.lab_A = new System.Windows.Forms.Label();
            this.gr_Opciones_Ecua = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar_Ecua = new System.Windows.Forms.Button();
            this.btn_Calcular_Ecua = new System.Windows.Forms.Button();
            this.RadioButton = new System.Windows.Forms.TabPage();
            this.gr_Sumatoria = new System.Windows.Forms.GroupBox();
            this.txt_Resu_Sum_Rad = new System.Windows.Forms.TextBox();
            this.txt_Num_Lim_Rad = new System.Windows.Forms.TextBox();
            this.lab_Resul_Sum_Rad = new System.Windows.Forms.Label();
            this.lab_Num_Lim_Rad = new System.Windows.Forms.Label();
            this.gr_Control_Radio = new System.Windows.Forms.GroupBox();
            this.rad_Sol_Impar = new System.Windows.Forms.RadioButton();
            this.rad_Sol_Pares = new System.Windows.Forms.RadioButton();
            this.rad_Todos = new System.Windows.Forms.RadioButton();
            this.gr_Opciones_Radio = new System.Windows.Forms.GroupBox();
            this.btn_Limp_Rad = new System.Windows.Forms.Button();
            this.btn_Sum_Rad = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.TabPage();
            this.gr_Arreglo_Check = new System.Windows.Forms.GroupBox();
            this.lab_Cont_Arr_Check = new System.Windows.Forms.Label();
            this.txt_Cont_Arr_Check = new System.Windows.Forms.TextBox();
            this.txt_Lim_Random_Check = new System.Windows.Forms.TextBox();
            this.txt_Tam_Arreglo = new System.Windows.Forms.TextBox();
            this.lab_Lim_Rand_Check = new System.Windows.Forms.Label();
            this.lab_Tam_Arr_Check = new System.Windows.Forms.Label();
            this.btn_Llen_Arr_Check = new System.Windows.Forms.Button();
            this.gr_Control_Check = new System.Windows.Forms.GroupBox();
            this.ch_Rem_Num_May_Cin = new System.Windows.Forms.CheckBox();
            this.ch_Rem_Num_Men_D = new System.Windows.Forms.CheckBox();
            this.ch_Rem_Par = new System.Windows.Forms.CheckBox();
            this.gr_Opciones_Check = new System.Windows.Forms.GroupBox();
            this.btn_Limp_Check = new System.Windows.Forms.Button();
            this.btn_Ver_Arr_Check = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.TabPage();
            this.gr_Cron_Timer = new System.Windows.Forms.GroupBox();
            this.txt_Mili = new System.Windows.Forms.TextBox();
            this.txt_Seg = new System.Windows.Forms.TextBox();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.txt_Tiemp_Timer = new System.Windows.Forms.TextBox();
            this.lab_Mili_Timer = new System.Windows.Forms.Label();
            this.lab_Seg_Tim = new System.Windows.Forms.Label();
            this.lab_Min_Tim_II = new System.Windows.Forms.Label();
            this.lab_Min_Timer = new System.Windows.Forms.Label();
            this.lab_Tiemp_Timer = new System.Windows.Forms.Label();
            this.gr_Opciones_Timer = new System.Windows.Forms.GroupBox();
            this.btn_Limp_Timer = new System.Windows.Forms.Button();
            this.btn_Det_Tim = new System.Windows.Forms.Button();
            this.btn_Ini_Timer = new System.Windows.Forms.Button();
            this.txt_Salir = new System.Windows.Forms.Button();
            this.tim_Crono = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.EcuacionesCuadraticas.SuspendLayout();
            this.gr_Informacion_Ecuacion.SuspendLayout();
            this.gr_Opciones_Ecua.SuspendLayout();
            this.RadioButton.SuspendLayout();
            this.gr_Sumatoria.SuspendLayout();
            this.gr_Control_Radio.SuspendLayout();
            this.gr_Opciones_Radio.SuspendLayout();
            this.CheckBox.SuspendLayout();
            this.gr_Arreglo_Check.SuspendLayout();
            this.gr_Control_Check.SuspendLayout();
            this.gr_Opciones_Check.SuspendLayout();
            this.Timer.SuspendLayout();
            this.gr_Cron_Timer.SuspendLayout();
            this.gr_Opciones_Timer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EcuacionesCuadraticas);
            this.tabControl1.Controls.Add(this.RadioButton);
            this.tabControl1.Controls.Add(this.CheckBox);
            this.tabControl1.Controls.Add(this.Timer);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 299);
            this.tabControl1.TabIndex = 0;
            // 
            // EcuacionesCuadraticas
            // 
            this.EcuacionesCuadraticas.BackColor = System.Drawing.Color.RosyBrown;
            this.EcuacionesCuadraticas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EcuacionesCuadraticas.Controls.Add(this.gr_Informacion_Ecuacion);
            this.EcuacionesCuadraticas.Location = new System.Drawing.Point(4, 22);
            this.EcuacionesCuadraticas.Name = "EcuacionesCuadraticas";
            this.EcuacionesCuadraticas.Padding = new System.Windows.Forms.Padding(3);
            this.EcuacionesCuadraticas.Size = new System.Drawing.Size(498, 273);
            this.EcuacionesCuadraticas.TabIndex = 0;
            this.EcuacionesCuadraticas.Text = "Ecuaciones Cuadráticas";
            // 
            // gr_Informacion_Ecuacion
            // 
            this.gr_Informacion_Ecuacion.Controls.Add(this.txt_Sol_II);
            this.gr_Informacion_Ecuacion.Controls.Add(this.txt_Sol_I);
            this.gr_Informacion_Ecuacion.Controls.Add(this.txt_Discr);
            this.gr_Informacion_Ecuacion.Controls.Add(this.txt_C);
            this.gr_Informacion_Ecuacion.Controls.Add(this.txt_B);
            this.gr_Informacion_Ecuacion.Controls.Add(this.txt_A);
            this.gr_Informacion_Ecuacion.Controls.Add(this.label6);
            this.gr_Informacion_Ecuacion.Controls.Add(this.lab_Sol_I);
            this.gr_Informacion_Ecuacion.Controls.Add(this.lab_Discr);
            this.gr_Informacion_Ecuacion.Controls.Add(this.lab_C);
            this.gr_Informacion_Ecuacion.Controls.Add(this.lab_B);
            this.gr_Informacion_Ecuacion.Controls.Add(this.lab_A);
            this.gr_Informacion_Ecuacion.Controls.Add(this.gr_Opciones_Ecua);
            this.gr_Informacion_Ecuacion.Location = new System.Drawing.Point(15, 16);
            this.gr_Informacion_Ecuacion.Name = "gr_Informacion_Ecuacion";
            this.gr_Informacion_Ecuacion.Size = new System.Drawing.Size(394, 226);
            this.gr_Informacion_Ecuacion.TabIndex = 0;
            this.gr_Informacion_Ecuacion.TabStop = false;
            this.gr_Informacion_Ecuacion.Text = "Informacion de la Ecuacion";
            // 
            // txt_Sol_II
            // 
            this.txt_Sol_II.Location = new System.Drawing.Point(117, 187);
            this.txt_Sol_II.Name = "txt_Sol_II";
            this.txt_Sol_II.ReadOnly = true;
            this.txt_Sol_II.Size = new System.Drawing.Size(100, 20);
            this.txt_Sol_II.TabIndex = 12;
            // 
            // txt_Sol_I
            // 
            this.txt_Sol_I.Location = new System.Drawing.Point(117, 155);
            this.txt_Sol_I.Name = "txt_Sol_I";
            this.txt_Sol_I.ReadOnly = true;
            this.txt_Sol_I.Size = new System.Drawing.Size(100, 20);
            this.txt_Sol_I.TabIndex = 11;
            // 
            // txt_Discr
            // 
            this.txt_Discr.Location = new System.Drawing.Point(117, 125);
            this.txt_Discr.Name = "txt_Discr";
            this.txt_Discr.ReadOnly = true;
            this.txt_Discr.Size = new System.Drawing.Size(100, 20);
            this.txt_Discr.TabIndex = 10;
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(166, 78);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(35, 20);
            this.txt_C.TabIndex = 9;
            this.txt_C.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_C_MouseClick);
            this.txt_C.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_C_KeyDown);
            this.txt_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_KeyPress);
            this.txt_C.Leave += new System.EventHandler(this.txt_C_Leave);
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(99, 78);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(35, 20);
            this.txt_B.TabIndex = 8;
            this.txt_B.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_B_MouseClick);
            this.txt_B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_B_KeyDown);
            this.txt_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_B_KeyPress);
            this.txt_B.Leave += new System.EventHandler(this.txt_B_Leave);
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(31, 78);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(35, 20);
            this.txt_A.TabIndex = 7;
            this.txt_A.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_A_MouseClick);
            this.txt_A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_A_KeyDown);
            this.txt_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_A_KeyPress);
            this.txt_A.Leave += new System.EventHandler(this.txt_A_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Solucion2:";
            // 
            // lab_Sol_I
            // 
            this.lab_Sol_I.AutoSize = true;
            this.lab_Sol_I.Location = new System.Drawing.Point(28, 158);
            this.lab_Sol_I.Name = "lab_Sol_I";
            this.lab_Sol_I.Size = new System.Drawing.Size(57, 13);
            this.lab_Sol_I.TabIndex = 5;
            this.lab_Sol_I.Text = "Solucion1:";
            // 
            // lab_Discr
            // 
            this.lab_Discr.AutoSize = true;
            this.lab_Discr.Location = new System.Drawing.Point(28, 128);
            this.lab_Discr.Name = "lab_Discr";
            this.lab_Discr.Size = new System.Drawing.Size(73, 13);
            this.lab_Discr.TabIndex = 4;
            this.lab_Discr.Text = "Discriminante:";
            // 
            // lab_C
            // 
            this.lab_C.AutoSize = true;
            this.lab_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_C.Location = new System.Drawing.Point(170, 37);
            this.lab_C.Name = "lab_C";
            this.lab_C.Size = new System.Drawing.Size(28, 25);
            this.lab_C.TabIndex = 3;
            this.lab_C.Text = "C";
            // 
            // lab_B
            // 
            this.lab_B.AutoSize = true;
            this.lab_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_B.Location = new System.Drawing.Point(102, 36);
            this.lab_B.Name = "lab_B";
            this.lab_B.Size = new System.Drawing.Size(26, 25);
            this.lab_B.TabIndex = 2;
            this.lab_B.Text = "B";
            // 
            // lab_A
            // 
            this.lab_A.AutoSize = true;
            this.lab_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_A.Location = new System.Drawing.Point(35, 37);
            this.lab_A.Name = "lab_A";
            this.lab_A.Size = new System.Drawing.Size(27, 25);
            this.lab_A.TabIndex = 1;
            this.lab_A.Text = "A";
            // 
            // gr_Opciones_Ecua
            // 
            this.gr_Opciones_Ecua.Controls.Add(this.btn_Limpiar_Ecua);
            this.gr_Opciones_Ecua.Controls.Add(this.btn_Calcular_Ecua);
            this.gr_Opciones_Ecua.Location = new System.Drawing.Point(257, 37);
            this.gr_Opciones_Ecua.Name = "gr_Opciones_Ecua";
            this.gr_Opciones_Ecua.Size = new System.Drawing.Size(118, 88);
            this.gr_Opciones_Ecua.TabIndex = 0;
            this.gr_Opciones_Ecua.TabStop = false;
            this.gr_Opciones_Ecua.Text = "Opciones";
            // 
            // btn_Limpiar_Ecua
            // 
            this.btn_Limpiar_Ecua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar_Ecua.Enabled = false;
            this.btn_Limpiar_Ecua.Location = new System.Drawing.Point(23, 50);
            this.btn_Limpiar_Ecua.Name = "btn_Limpiar_Ecua";
            this.btn_Limpiar_Ecua.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar_Ecua.TabIndex = 1;
            this.btn_Limpiar_Ecua.Text = "Limpiar";
            this.btn_Limpiar_Ecua.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Ecua.Click += new System.EventHandler(this.btn_Limpiar_Ecua_Click);
            // 
            // btn_Calcular_Ecua
            // 
            this.btn_Calcular_Ecua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Calcular_Ecua.Enabled = false;
            this.btn_Calcular_Ecua.Location = new System.Drawing.Point(23, 21);
            this.btn_Calcular_Ecua.Name = "btn_Calcular_Ecua";
            this.btn_Calcular_Ecua.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular_Ecua.TabIndex = 0;
            this.btn_Calcular_Ecua.Text = "Calcular";
            this.btn_Calcular_Ecua.UseVisualStyleBackColor = true;
            this.btn_Calcular_Ecua.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // RadioButton
            // 
            this.RadioButton.BackColor = System.Drawing.Color.CadetBlue;
            this.RadioButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RadioButton.Controls.Add(this.gr_Sumatoria);
            this.RadioButton.Location = new System.Drawing.Point(4, 22);
            this.RadioButton.Name = "RadioButton";
            this.RadioButton.Padding = new System.Windows.Forms.Padding(3);
            this.RadioButton.Size = new System.Drawing.Size(498, 273);
            this.RadioButton.TabIndex = 1;
            this.RadioButton.Text = "RadioButton";
            // 
            // gr_Sumatoria
            // 
            this.gr_Sumatoria.Controls.Add(this.txt_Resu_Sum_Rad);
            this.gr_Sumatoria.Controls.Add(this.txt_Num_Lim_Rad);
            this.gr_Sumatoria.Controls.Add(this.lab_Resul_Sum_Rad);
            this.gr_Sumatoria.Controls.Add(this.lab_Num_Lim_Rad);
            this.gr_Sumatoria.Controls.Add(this.gr_Control_Radio);
            this.gr_Sumatoria.Controls.Add(this.gr_Opciones_Radio);
            this.gr_Sumatoria.Location = new System.Drawing.Point(16, 15);
            this.gr_Sumatoria.Name = "gr_Sumatoria";
            this.gr_Sumatoria.Size = new System.Drawing.Size(410, 163);
            this.gr_Sumatoria.TabIndex = 0;
            this.gr_Sumatoria.TabStop = false;
            this.gr_Sumatoria.Text = "Sumatoria";
            // 
            // txt_Resu_Sum_Rad
            // 
            this.txt_Resu_Sum_Rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resu_Sum_Rad.Location = new System.Drawing.Point(126, 119);
            this.txt_Resu_Sum_Rad.Name = "txt_Resu_Sum_Rad";
            this.txt_Resu_Sum_Rad.ReadOnly = true;
            this.txt_Resu_Sum_Rad.Size = new System.Drawing.Size(100, 20);
            this.txt_Resu_Sum_Rad.TabIndex = 5;
            this.txt_Resu_Sum_Rad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Num_Lim_Rad
            // 
            this.txt_Num_Lim_Rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num_Lim_Rad.Location = new System.Drawing.Point(107, 19);
            this.txt_Num_Lim_Rad.Name = "txt_Num_Lim_Rad";
            this.txt_Num_Lim_Rad.Size = new System.Drawing.Size(100, 23);
            this.txt_Num_Lim_Rad.TabIndex = 4;
            this.txt_Num_Lim_Rad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Num_Lim_Rad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Num_Lim_Rad_MouseClick);
            this.txt_Num_Lim_Rad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Num_Lim_Rad_KeyDown);
            this.txt_Num_Lim_Rad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num_Lim_Rad_KeyPress);
            this.txt_Num_Lim_Rad.Leave += new System.EventHandler(this.txt_Num_Lim_Rad_Leave);
            // 
            // lab_Resul_Sum_Rad
            // 
            this.lab_Resul_Sum_Rad.AutoSize = true;
            this.lab_Resul_Sum_Rad.Location = new System.Drawing.Point(12, 122);
            this.lab_Resul_Sum_Rad.Name = "lab_Resul_Sum_Rad";
            this.lab_Resul_Sum_Rad.Size = new System.Drawing.Size(108, 13);
            this.lab_Resul_Sum_Rad.TabIndex = 3;
            this.lab_Resul_Sum_Rad.Text = "Resultado Sumatoria:";
            // 
            // lab_Num_Lim_Rad
            // 
            this.lab_Num_Lim_Rad.AutoSize = true;
            this.lab_Num_Lim_Rad.Location = new System.Drawing.Point(9, 22);
            this.lab_Num_Lim_Rad.Name = "lab_Num_Lim_Rad";
            this.lab_Num_Lim_Rad.Size = new System.Drawing.Size(77, 13);
            this.lab_Num_Lim_Rad.TabIndex = 2;
            this.lab_Num_Lim_Rad.Text = "Numero Limite:";
            // 
            // gr_Control_Radio
            // 
            this.gr_Control_Radio.Controls.Add(this.rad_Sol_Impar);
            this.gr_Control_Radio.Controls.Add(this.rad_Sol_Pares);
            this.gr_Control_Radio.Controls.Add(this.rad_Todos);
            this.gr_Control_Radio.Enabled = false;
            this.gr_Control_Radio.Location = new System.Drawing.Point(12, 55);
            this.gr_Control_Radio.Name = "gr_Control_Radio";
            this.gr_Control_Radio.Size = new System.Drawing.Size(263, 47);
            this.gr_Control_Radio.TabIndex = 1;
            this.gr_Control_Radio.TabStop = false;
            this.gr_Control_Radio.Text = "Control";
            // 
            // rad_Sol_Impar
            // 
            this.rad_Sol_Impar.AutoSize = true;
            this.rad_Sol_Impar.Location = new System.Drawing.Point(143, 20);
            this.rad_Sol_Impar.Name = "rad_Sol_Impar";
            this.rad_Sol_Impar.Size = new System.Drawing.Size(86, 17);
            this.rad_Sol_Impar.TabIndex = 2;
            this.rad_Sol_Impar.TabStop = true;
            this.rad_Sol_Impar.Text = "Solo Impares";
            this.rad_Sol_Impar.UseVisualStyleBackColor = true;
            this.rad_Sol_Impar.Click += new System.EventHandler(this.rad_Sol_Impar_Click);
            // 
            // rad_Sol_Pares
            // 
            this.rad_Sol_Pares.AutoSize = true;
            this.rad_Sol_Pares.Location = new System.Drawing.Point(69, 20);
            this.rad_Sol_Pares.Name = "rad_Sol_Pares";
            this.rad_Sol_Pares.Size = new System.Drawing.Size(76, 17);
            this.rad_Sol_Pares.TabIndex = 1;
            this.rad_Sol_Pares.TabStop = true;
            this.rad_Sol_Pares.Text = "Solo Pares";
            this.rad_Sol_Pares.UseVisualStyleBackColor = true;
            this.rad_Sol_Pares.Click += new System.EventHandler(this.rad_Sol_Pares_Click);
            // 
            // rad_Todos
            // 
            this.rad_Todos.AutoSize = true;
            this.rad_Todos.Location = new System.Drawing.Point(7, 20);
            this.rad_Todos.Name = "rad_Todos";
            this.rad_Todos.Size = new System.Drawing.Size(55, 17);
            this.rad_Todos.TabIndex = 0;
            this.rad_Todos.TabStop = true;
            this.rad_Todos.Text = "Todos";
            this.rad_Todos.UseVisualStyleBackColor = true;
            this.rad_Todos.Click += new System.EventHandler(this.rad_Todos_Click);
            // 
            // gr_Opciones_Radio
            // 
            this.gr_Opciones_Radio.Controls.Add(this.btn_Limp_Rad);
            this.gr_Opciones_Radio.Controls.Add(this.btn_Sum_Rad);
            this.gr_Opciones_Radio.Location = new System.Drawing.Point(290, 22);
            this.gr_Opciones_Radio.Name = "gr_Opciones_Radio";
            this.gr_Opciones_Radio.Size = new System.Drawing.Size(96, 90);
            this.gr_Opciones_Radio.TabIndex = 0;
            this.gr_Opciones_Radio.TabStop = false;
            this.gr_Opciones_Radio.Text = "Opciones";
            // 
            // btn_Limp_Rad
            // 
            this.btn_Limp_Rad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limp_Rad.Enabled = false;
            this.btn_Limp_Rad.Location = new System.Drawing.Point(9, 48);
            this.btn_Limp_Rad.Name = "btn_Limp_Rad";
            this.btn_Limp_Rad.Size = new System.Drawing.Size(75, 23);
            this.btn_Limp_Rad.TabIndex = 1;
            this.btn_Limp_Rad.Text = "Limpiar";
            this.btn_Limp_Rad.UseVisualStyleBackColor = true;
            this.btn_Limp_Rad.Click += new System.EventHandler(this.btn_Limp_Rad_Click);
            // 
            // btn_Sum_Rad
            // 
            this.btn_Sum_Rad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sum_Rad.Enabled = false;
            this.btn_Sum_Rad.Location = new System.Drawing.Point(9, 19);
            this.btn_Sum_Rad.Name = "btn_Sum_Rad";
            this.btn_Sum_Rad.Size = new System.Drawing.Size(75, 23);
            this.btn_Sum_Rad.TabIndex = 0;
            this.btn_Sum_Rad.Text = "Sumar";
            this.btn_Sum_Rad.UseVisualStyleBackColor = true;
            this.btn_Sum_Rad.Click += new System.EventHandler(this.btn_Sum_Rad_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.BackColor = System.Drawing.Color.OliveDrab;
            this.CheckBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CheckBox.Controls.Add(this.gr_Arreglo_Check);
            this.CheckBox.Location = new System.Drawing.Point(4, 22);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(498, 273);
            this.CheckBox.TabIndex = 2;
            this.CheckBox.Text = "CheckBox";
            // 
            // gr_Arreglo_Check
            // 
            this.gr_Arreglo_Check.Controls.Add(this.lab_Cont_Arr_Check);
            this.gr_Arreglo_Check.Controls.Add(this.txt_Cont_Arr_Check);
            this.gr_Arreglo_Check.Controls.Add(this.txt_Lim_Random_Check);
            this.gr_Arreglo_Check.Controls.Add(this.txt_Tam_Arreglo);
            this.gr_Arreglo_Check.Controls.Add(this.lab_Lim_Rand_Check);
            this.gr_Arreglo_Check.Controls.Add(this.lab_Tam_Arr_Check);
            this.gr_Arreglo_Check.Controls.Add(this.btn_Llen_Arr_Check);
            this.gr_Arreglo_Check.Controls.Add(this.gr_Control_Check);
            this.gr_Arreglo_Check.Controls.Add(this.gr_Opciones_Check);
            this.gr_Arreglo_Check.Location = new System.Drawing.Point(12, 13);
            this.gr_Arreglo_Check.Name = "gr_Arreglo_Check";
            this.gr_Arreglo_Check.Size = new System.Drawing.Size(450, 235);
            this.gr_Arreglo_Check.TabIndex = 0;
            this.gr_Arreglo_Check.TabStop = false;
            this.gr_Arreglo_Check.Text = "Arreglo";
            // 
            // lab_Cont_Arr_Check
            // 
            this.lab_Cont_Arr_Check.AutoSize = true;
            this.lab_Cont_Arr_Check.Location = new System.Drawing.Point(11, 196);
            this.lab_Cont_Arr_Check.Name = "lab_Cont_Arr_Check";
            this.lab_Cont_Arr_Check.Size = new System.Drawing.Size(94, 13);
            this.lab_Cont_Arr_Check.TabIndex = 8;
            this.lab_Cont_Arr_Check.Text = "Contenido Arreglo:";
            // 
            // txt_Cont_Arr_Check
            // 
            this.txt_Cont_Arr_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cont_Arr_Check.Location = new System.Drawing.Point(111, 193);
            this.txt_Cont_Arr_Check.Name = "txt_Cont_Arr_Check";
            this.txt_Cont_Arr_Check.ReadOnly = true;
            this.txt_Cont_Arr_Check.Size = new System.Drawing.Size(325, 20);
            this.txt_Cont_Arr_Check.TabIndex = 7;
            // 
            // txt_Lim_Random_Check
            // 
            this.txt_Lim_Random_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lim_Random_Check.Location = new System.Drawing.Point(111, 46);
            this.txt_Lim_Random_Check.MaxLength = 4;
            this.txt_Lim_Random_Check.Name = "txt_Lim_Random_Check";
            this.txt_Lim_Random_Check.Size = new System.Drawing.Size(68, 23);
            this.txt_Lim_Random_Check.TabIndex = 6;
            this.txt_Lim_Random_Check.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Lim_Random_Check.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Lim_Random_Check_MouseClick);
            this.txt_Lim_Random_Check.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Lim_Random_Check_KeyDown);
            this.txt_Lim_Random_Check.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Lim_Random_Check_KeyPress);
            this.txt_Lim_Random_Check.Leave += new System.EventHandler(this.txt_Lim_Random_Check_Leave);
            // 
            // txt_Tam_Arreglo
            // 
            this.txt_Tam_Arreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tam_Arreglo.Location = new System.Drawing.Point(111, 18);
            this.txt_Tam_Arreglo.MaxLength = 4;
            this.txt_Tam_Arreglo.Name = "txt_Tam_Arreglo";
            this.txt_Tam_Arreglo.Size = new System.Drawing.Size(68, 23);
            this.txt_Tam_Arreglo.TabIndex = 5;
            this.txt_Tam_Arreglo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Tam_Arreglo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Tam_Arreglo_MouseClick);
            this.txt_Tam_Arreglo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Tam_Arreglo_KeyDown);
            this.txt_Tam_Arreglo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tam_Arreglo_KeyPress);
            this.txt_Tam_Arreglo.Leave += new System.EventHandler(this.txt_Tam_Arreglo_Leave);
            // 
            // lab_Lim_Rand_Check
            // 
            this.lab_Lim_Rand_Check.AutoSize = true;
            this.lab_Lim_Rand_Check.Location = new System.Drawing.Point(11, 49);
            this.lab_Lim_Rand_Check.Name = "lab_Lim_Rand_Check";
            this.lab_Lim_Rand_Check.Size = new System.Drawing.Size(97, 13);
            this.lab_Lim_Rand_Check.TabIndex = 4;
            this.lab_Lim_Rand_Check.Text = "Limite del Random:";
            // 
            // lab_Tam_Arr_Check
            // 
            this.lab_Tam_Arr_Check.AutoSize = true;
            this.lab_Tam_Arr_Check.Location = new System.Drawing.Point(11, 23);
            this.lab_Tam_Arr_Check.Name = "lab_Tam_Arr_Check";
            this.lab_Tam_Arr_Check.Size = new System.Drawing.Size(85, 13);
            this.lab_Tam_Arr_Check.TabIndex = 3;
            this.lab_Tam_Arr_Check.Text = "Tamaño Arreglo:";
            // 
            // btn_Llen_Arr_Check
            // 
            this.btn_Llen_Arr_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Llen_Arr_Check.Enabled = false;
            this.btn_Llen_Arr_Check.Location = new System.Drawing.Point(194, 44);
            this.btn_Llen_Arr_Check.Name = "btn_Llen_Arr_Check";
            this.btn_Llen_Arr_Check.Size = new System.Drawing.Size(89, 23);
            this.btn_Llen_Arr_Check.TabIndex = 2;
            this.btn_Llen_Arr_Check.Text = "Llenar Arreglo";
            this.btn_Llen_Arr_Check.UseVisualStyleBackColor = true;
            this.btn_Llen_Arr_Check.Click += new System.EventHandler(this.btn_Llen_Arr_Check_Click);
            // 
            // gr_Control_Check
            // 
            this.gr_Control_Check.Controls.Add(this.ch_Rem_Num_May_Cin);
            this.gr_Control_Check.Controls.Add(this.ch_Rem_Num_Men_D);
            this.gr_Control_Check.Controls.Add(this.ch_Rem_Par);
            this.gr_Control_Check.Location = new System.Drawing.Point(14, 77);
            this.gr_Control_Check.Name = "gr_Control_Check";
            this.gr_Control_Check.Size = new System.Drawing.Size(214, 97);
            this.gr_Control_Check.TabIndex = 1;
            this.gr_Control_Check.TabStop = false;
            this.gr_Control_Check.Text = "Control";
            // 
            // ch_Rem_Num_May_Cin
            // 
            this.ch_Rem_Num_May_Cin.AutoSize = true;
            this.ch_Rem_Num_May_Cin.Enabled = false;
            this.ch_Rem_Num_May_Cin.Location = new System.Drawing.Point(7, 68);
            this.ch_Rem_Num_May_Cin.Name = "ch_Rem_Num_May_Cin";
            this.ch_Rem_Num_May_Cin.Size = new System.Drawing.Size(178, 17);
            this.ch_Rem_Num_May_Cin.TabIndex = 2;
            this.ch_Rem_Num_May_Cin.Text = "Remover numeros mayores a 50";
            this.ch_Rem_Num_May_Cin.UseVisualStyleBackColor = true;
            // 
            // ch_Rem_Num_Men_D
            // 
            this.ch_Rem_Num_Men_D.AutoSize = true;
            this.ch_Rem_Num_Men_D.Enabled = false;
            this.ch_Rem_Num_Men_D.Location = new System.Drawing.Point(7, 44);
            this.ch_Rem_Num_Men_D.Name = "ch_Rem_Num_Men_D";
            this.ch_Rem_Num_Men_D.Size = new System.Drawing.Size(179, 17);
            this.ch_Rem_Num_Men_D.TabIndex = 1;
            this.ch_Rem_Num_Men_D.Text = "Remover numeros menores a 10";
            this.ch_Rem_Num_Men_D.UseVisualStyleBackColor = true;
            // 
            // ch_Rem_Par
            // 
            this.ch_Rem_Par.AutoSize = true;
            this.ch_Rem_Par.Enabled = false;
            this.ch_Rem_Par.Location = new System.Drawing.Point(7, 20);
            this.ch_Rem_Par.Name = "ch_Rem_Par";
            this.ch_Rem_Par.Size = new System.Drawing.Size(141, 17);
            this.ch_Rem_Par.TabIndex = 0;
            this.ch_Rem_Par.Text = "Remover numeros pares";
            this.ch_Rem_Par.UseVisualStyleBackColor = true;
            // 
            // gr_Opciones_Check
            // 
            this.gr_Opciones_Check.Controls.Add(this.btn_Limp_Check);
            this.gr_Opciones_Check.Controls.Add(this.btn_Ver_Arr_Check);
            this.gr_Opciones_Check.Location = new System.Drawing.Point(310, 49);
            this.gr_Opciones_Check.Name = "gr_Opciones_Check";
            this.gr_Opciones_Check.Size = new System.Drawing.Size(106, 89);
            this.gr_Opciones_Check.TabIndex = 0;
            this.gr_Opciones_Check.TabStop = false;
            this.gr_Opciones_Check.Text = "Opciones";
            // 
            // btn_Limp_Check
            // 
            this.btn_Limp_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limp_Check.Enabled = false;
            this.btn_Limp_Check.Location = new System.Drawing.Point(19, 49);
            this.btn_Limp_Check.Name = "btn_Limp_Check";
            this.btn_Limp_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Limp_Check.TabIndex = 1;
            this.btn_Limp_Check.Text = "Limpiar";
            this.btn_Limp_Check.UseVisualStyleBackColor = true;
            this.btn_Limp_Check.Click += new System.EventHandler(this.btn_Limp_Check_Click);
            // 
            // btn_Ver_Arr_Check
            // 
            this.btn_Ver_Arr_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ver_Arr_Check.Enabled = false;
            this.btn_Ver_Arr_Check.Location = new System.Drawing.Point(19, 20);
            this.btn_Ver_Arr_Check.Name = "btn_Ver_Arr_Check";
            this.btn_Ver_Arr_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Ver_Arr_Check.TabIndex = 0;
            this.btn_Ver_Arr_Check.Text = "Ver Arreglo";
            this.btn_Ver_Arr_Check.UseVisualStyleBackColor = true;
            this.btn_Ver_Arr_Check.Click += new System.EventHandler(this.btn_Ver_Arr_Check_Click);
            // 
            // Timer
            // 
            this.Timer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Timer.Controls.Add(this.gr_Cron_Timer);
            this.Timer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Timer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Timer.Location = new System.Drawing.Point(4, 22);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(498, 273);
            this.Timer.TabIndex = 3;
            this.Timer.Text = "Timer";
            // 
            // gr_Cron_Timer
            // 
            this.gr_Cron_Timer.Controls.Add(this.txt_Mili);
            this.gr_Cron_Timer.Controls.Add(this.txt_Seg);
            this.gr_Cron_Timer.Controls.Add(this.txt_Min);
            this.gr_Cron_Timer.Controls.Add(this.txt_Tiemp_Timer);
            this.gr_Cron_Timer.Controls.Add(this.lab_Mili_Timer);
            this.gr_Cron_Timer.Controls.Add(this.lab_Seg_Tim);
            this.gr_Cron_Timer.Controls.Add(this.lab_Min_Tim_II);
            this.gr_Cron_Timer.Controls.Add(this.lab_Min_Timer);
            this.gr_Cron_Timer.Controls.Add(this.lab_Tiemp_Timer);
            this.gr_Cron_Timer.Controls.Add(this.gr_Opciones_Timer);
            this.gr_Cron_Timer.Location = new System.Drawing.Point(13, 14);
            this.gr_Cron_Timer.Name = "gr_Cron_Timer";
            this.gr_Cron_Timer.Size = new System.Drawing.Size(413, 190);
            this.gr_Cron_Timer.TabIndex = 0;
            this.gr_Cron_Timer.TabStop = false;
            this.gr_Cron_Timer.Text = "Cronometro";
            // 
            // txt_Mili
            // 
            this.txt_Mili.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mili.Location = new System.Drawing.Point(339, 141);
            this.txt_Mili.Multiline = true;
            this.txt_Mili.Name = "txt_Mili";
            this.txt_Mili.ReadOnly = true;
            this.txt_Mili.Size = new System.Drawing.Size(58, 34);
            this.txt_Mili.TabIndex = 9;
            this.txt_Mili.Text = "0";
            this.txt_Mili.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Seg
            // 
            this.txt_Seg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Seg.Location = new System.Drawing.Point(189, 143);
            this.txt_Seg.Multiline = true;
            this.txt_Seg.Name = "txt_Seg";
            this.txt_Seg.ReadOnly = true;
            this.txt_Seg.Size = new System.Drawing.Size(58, 32);
            this.txt_Seg.TabIndex = 8;
            this.txt_Seg.Text = "0";
            this.txt_Seg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Min
            // 
            this.txt_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Min.Location = new System.Drawing.Point(61, 143);
            this.txt_Min.Multiline = true;
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.ReadOnly = true;
            this.txt_Min.Size = new System.Drawing.Size(52, 32);
            this.txt_Min.TabIndex = 7;
            this.txt_Min.Text = "0";
            this.txt_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Tiemp_Timer
            // 
            this.txt_Tiemp_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tiemp_Timer.Location = new System.Drawing.Point(61, 27);
            this.txt_Tiemp_Timer.Name = "txt_Tiemp_Timer";
            this.txt_Tiemp_Timer.Size = new System.Drawing.Size(100, 23);
            this.txt_Tiemp_Timer.TabIndex = 6;
            this.txt_Tiemp_Timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Tiemp_Timer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Tiemp_Timer_MouseClick);
            this.txt_Tiemp_Timer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Tiemp_Timer_KeyDown);
            this.txt_Tiemp_Timer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tiemp_Timer_KeyPress);
            this.txt_Tiemp_Timer.Leave += new System.EventHandler(this.txt_Tiemp_Timer_Leave);
            // 
            // lab_Mili_Timer
            // 
            this.lab_Mili_Timer.AutoSize = true;
            this.lab_Mili_Timer.Location = new System.Drawing.Point(262, 153);
            this.lab_Mili_Timer.Name = "lab_Mili_Timer";
            this.lab_Mili_Timer.Size = new System.Drawing.Size(71, 13);
            this.lab_Mili_Timer.TabIndex = 5;
            this.lab_Mili_Timer.Text = "Milisegundos:";
            // 
            // lab_Seg_Tim
            // 
            this.lab_Seg_Tim.AutoSize = true;
            this.lab_Seg_Tim.Location = new System.Drawing.Point(121, 153);
            this.lab_Seg_Tim.Name = "lab_Seg_Tim";
            this.lab_Seg_Tim.Size = new System.Drawing.Size(58, 13);
            this.lab_Seg_Tim.TabIndex = 4;
            this.lab_Seg_Tim.Text = "Segundos:";
            // 
            // lab_Min_Tim_II
            // 
            this.lab_Min_Tim_II.AutoSize = true;
            this.lab_Min_Tim_II.Location = new System.Drawing.Point(6, 153);
            this.lab_Min_Tim_II.Name = "lab_Min_Tim_II";
            this.lab_Min_Tim_II.Size = new System.Drawing.Size(47, 13);
            this.lab_Min_Tim_II.TabIndex = 3;
            this.lab_Min_Tim_II.Text = "Minutos:";
            // 
            // lab_Min_Timer
            // 
            this.lab_Min_Timer.AutoSize = true;
            this.lab_Min_Timer.Location = new System.Drawing.Point(169, 30);
            this.lab_Min_Timer.Name = "lab_Min_Timer";
            this.lab_Min_Timer.Size = new System.Drawing.Size(43, 13);
            this.lab_Min_Timer.TabIndex = 2;
            this.lab_Min_Timer.Text = "minutos";
            // 
            // lab_Tiemp_Timer
            // 
            this.lab_Tiemp_Timer.AutoSize = true;
            this.lab_Tiemp_Timer.Location = new System.Drawing.Point(10, 30);
            this.lab_Tiemp_Timer.Name = "lab_Tiemp_Timer";
            this.lab_Tiemp_Timer.Size = new System.Drawing.Size(45, 13);
            this.lab_Tiemp_Timer.TabIndex = 1;
            this.lab_Tiemp_Timer.Text = "Tiempo:";
            // 
            // gr_Opciones_Timer
            // 
            this.gr_Opciones_Timer.Controls.Add(this.btn_Limp_Timer);
            this.gr_Opciones_Timer.Controls.Add(this.btn_Det_Tim);
            this.gr_Opciones_Timer.Controls.Add(this.btn_Ini_Timer);
            this.gr_Opciones_Timer.Location = new System.Drawing.Point(220, 13);
            this.gr_Opciones_Timer.Name = "gr_Opciones_Timer";
            this.gr_Opciones_Timer.Size = new System.Drawing.Size(113, 116);
            this.gr_Opciones_Timer.TabIndex = 0;
            this.gr_Opciones_Timer.TabStop = false;
            this.gr_Opciones_Timer.Text = "Opciones";
            // 
            // btn_Limp_Timer
            // 
            this.btn_Limp_Timer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limp_Timer.Enabled = false;
            this.btn_Limp_Timer.Location = new System.Drawing.Point(17, 77);
            this.btn_Limp_Timer.Name = "btn_Limp_Timer";
            this.btn_Limp_Timer.Size = new System.Drawing.Size(75, 23);
            this.btn_Limp_Timer.TabIndex = 2;
            this.btn_Limp_Timer.Text = "Limpiar";
            this.btn_Limp_Timer.UseVisualStyleBackColor = true;
            this.btn_Limp_Timer.Click += new System.EventHandler(this.btn_Limp_Timer_Click);
            // 
            // btn_Det_Tim
            // 
            this.btn_Det_Tim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Det_Tim.Enabled = false;
            this.btn_Det_Tim.Location = new System.Drawing.Point(17, 48);
            this.btn_Det_Tim.Name = "btn_Det_Tim";
            this.btn_Det_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_Det_Tim.TabIndex = 1;
            this.btn_Det_Tim.Text = "Detener";
            this.btn_Det_Tim.UseVisualStyleBackColor = true;
            this.btn_Det_Tim.Click += new System.EventHandler(this.btn_Det_Tim_Click);
            // 
            // btn_Ini_Timer
            // 
            this.btn_Ini_Timer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ini_Timer.Enabled = false;
            this.btn_Ini_Timer.Location = new System.Drawing.Point(17, 19);
            this.btn_Ini_Timer.Name = "btn_Ini_Timer";
            this.btn_Ini_Timer.Size = new System.Drawing.Size(75, 23);
            this.btn_Ini_Timer.TabIndex = 0;
            this.btn_Ini_Timer.Text = "Iniciar";
            this.btn_Ini_Timer.UseVisualStyleBackColor = true;
            this.btn_Ini_Timer.Click += new System.EventHandler(this.btn_Ini_Timer_Click);
            // 
            // txt_Salir
            // 
            this.txt_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_Salir.Location = new System.Drawing.Point(443, 317);
            this.txt_Salir.Name = "txt_Salir";
            this.txt_Salir.Size = new System.Drawing.Size(75, 23);
            this.txt_Salir.TabIndex = 1;
            this.txt_Salir.Text = "Salir";
            this.txt_Salir.UseVisualStyleBackColor = true;
            this.txt_Salir.Click += new System.EventHandler(this.txt_Salir_Click);
            // 
            // tim_Crono
            // 
            this.tim_Crono.Tick += new System.EventHandler(this.tim_Crono_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(536, 347);
            this.Controls.Add(this.txt_Salir);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Controles";
            this.Text = "Controles";
            this.tabControl1.ResumeLayout(false);
            this.EcuacionesCuadraticas.ResumeLayout(false);
            this.gr_Informacion_Ecuacion.ResumeLayout(false);
            this.gr_Informacion_Ecuacion.PerformLayout();
            this.gr_Opciones_Ecua.ResumeLayout(false);
            this.RadioButton.ResumeLayout(false);
            this.gr_Sumatoria.ResumeLayout(false);
            this.gr_Sumatoria.PerformLayout();
            this.gr_Control_Radio.ResumeLayout(false);
            this.gr_Control_Radio.PerformLayout();
            this.gr_Opciones_Radio.ResumeLayout(false);
            this.CheckBox.ResumeLayout(false);
            this.gr_Arreglo_Check.ResumeLayout(false);
            this.gr_Arreglo_Check.PerformLayout();
            this.gr_Control_Check.ResumeLayout(false);
            this.gr_Control_Check.PerformLayout();
            this.gr_Opciones_Check.ResumeLayout(false);
            this.Timer.ResumeLayout(false);
            this.gr_Cron_Timer.ResumeLayout(false);
            this.gr_Cron_Timer.PerformLayout();
            this.gr_Opciones_Timer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EcuacionesCuadraticas;
        private System.Windows.Forms.TabPage RadioButton;
        private System.Windows.Forms.TabPage CheckBox;
        private System.Windows.Forms.TabPage Timer;
        private System.Windows.Forms.GroupBox gr_Informacion_Ecuacion;
        private System.Windows.Forms.GroupBox gr_Opciones_Ecua;
        private System.Windows.Forms.Button btn_Limpiar_Ecua;
        private System.Windows.Forms.Button btn_Calcular_Ecua;
        private System.Windows.Forms.TextBox txt_Sol_II;
        private System.Windows.Forms.TextBox txt_Sol_I;
        private System.Windows.Forms.TextBox txt_Discr;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_Sol_I;
        private System.Windows.Forms.Label lab_Discr;
        private System.Windows.Forms.Label lab_C;
        private System.Windows.Forms.Label lab_B;
        private System.Windows.Forms.Label lab_A;
        private System.Windows.Forms.Button txt_Salir;
        private System.Windows.Forms.GroupBox gr_Sumatoria;
        private System.Windows.Forms.GroupBox gr_Opciones_Radio;
        private System.Windows.Forms.Label lab_Num_Lim_Rad;
        private System.Windows.Forms.GroupBox gr_Control_Radio;
        private System.Windows.Forms.Button btn_Limp_Rad;
        private System.Windows.Forms.Button btn_Sum_Rad;
        private System.Windows.Forms.TextBox txt_Resu_Sum_Rad;
        private System.Windows.Forms.TextBox txt_Num_Lim_Rad;
        private System.Windows.Forms.Label lab_Resul_Sum_Rad;
        private System.Windows.Forms.RadioButton rad_Sol_Impar;
        private System.Windows.Forms.RadioButton rad_Sol_Pares;
        private System.Windows.Forms.RadioButton rad_Todos;
        private System.Windows.Forms.GroupBox gr_Arreglo_Check;
        private System.Windows.Forms.Label lab_Cont_Arr_Check;
        private System.Windows.Forms.TextBox txt_Cont_Arr_Check;
        private System.Windows.Forms.TextBox txt_Lim_Random_Check;
        private System.Windows.Forms.TextBox txt_Tam_Arreglo;
        private System.Windows.Forms.Label lab_Lim_Rand_Check;
        private System.Windows.Forms.Label lab_Tam_Arr_Check;
        private System.Windows.Forms.Button btn_Llen_Arr_Check;
        private System.Windows.Forms.GroupBox gr_Control_Check;
        private System.Windows.Forms.CheckBox ch_Rem_Num_May_Cin;
        private System.Windows.Forms.CheckBox ch_Rem_Num_Men_D;
        private System.Windows.Forms.CheckBox ch_Rem_Par;
        private System.Windows.Forms.GroupBox gr_Opciones_Check;
        private System.Windows.Forms.Button btn_Limp_Check;
        private System.Windows.Forms.Button btn_Ver_Arr_Check;
        private System.Windows.Forms.GroupBox gr_Cron_Timer;
        private System.Windows.Forms.TextBox txt_Mili;
        private System.Windows.Forms.TextBox txt_Seg;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.TextBox txt_Tiemp_Timer;
        private System.Windows.Forms.Label lab_Mili_Timer;
        private System.Windows.Forms.Label lab_Seg_Tim;
        private System.Windows.Forms.Label lab_Min_Tim_II;
        private System.Windows.Forms.Label lab_Min_Timer;
        private System.Windows.Forms.Label lab_Tiemp_Timer;
        private System.Windows.Forms.GroupBox gr_Opciones_Timer;
        private System.Windows.Forms.Button btn_Limp_Timer;
        private System.Windows.Forms.Button btn_Det_Tim;
        private System.Windows.Forms.Button btn_Ini_Timer;
        private System.Windows.Forms.Timer tim_Crono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}