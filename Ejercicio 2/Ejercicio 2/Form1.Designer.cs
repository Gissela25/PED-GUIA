namespace Ejercicio_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrdenamiento = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnEliminarNodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboOrdenamiento);
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1872, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarNodo.Enabled = false;
            this.btnEliminarNodo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarNodo.Location = new System.Drawing.Point(1212, 71);
            this.btnEliminarNodo.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(250, 71);
            this.btnEliminarNodo.TabIndex = 5;
            this.btnEliminarNodo.Text = "Eliminar";
            this.btnEliminarNodo.UseVisualStyleBackColor = false;
            this.btnEliminarNodo.Click += new System.EventHandler(this.btnEliminarNodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1554, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Heap";
            // 
            // cboOrdenamiento
            // 
            this.cboOrdenamiento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboOrdenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenamiento.FormattingEnabled = true;
            this.cboOrdenamiento.Items.AddRange(new object[] {
            "Maximizante",
            "Minimizante"});
            this.cboOrdenamiento.Location = new System.Drawing.Point(1544, 110);
            this.cboOrdenamiento.Margin = new System.Windows.Forms.Padding(6);
            this.cboOrdenamiento.Name = "cboOrdenamiento";
            this.cboOrdenamiento.Size = new System.Drawing.Size(238, 33);
            this.cboOrdenamiento.TabIndex = 3;
            this.cboOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cboOrdenamiento_SelectedIndexChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOrdenar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrdenar.Location = new System.Drawing.Point(908, 71);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(6);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(250, 71);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(600, 71);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(250, 71);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(288, 71);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(250, 71);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(32, 83);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(196, 31);
            this.txtNumero.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(54, 269);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1795, 682);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1779, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Heap";
            this.tabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2064, 989);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOrdenamiento;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

