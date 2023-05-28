namespace PPAI_Tarjeta.Vista
{
    partial class PantallaRegistrarRespuesta
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblSubOpc = new System.Windows.Forms.Label();
            this.grillaValidacion = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxRta = new System.Windows.Forms.TextBox();
            this.lblRta = new System.Windows.Forms.Label();
            this.btnResOp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(241, 89);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(86, 15);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "TextoCategoria";
            this.lblCategoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(253, 145);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(74, 15);
            this.lblOpcion.TabIndex = 1;
            this.lblOpcion.Text = "TextoOpcion";
            this.lblOpcion.Click += new System.EventHandler(this.lblOpcion_Click);
            // 
            // lblSubOpc
            // 
            this.lblSubOpc.AutoSize = true;
            this.lblSubOpc.Location = new System.Drawing.Point(253, 185);
            this.lblSubOpc.Name = "lblSubOpc";
            this.lblSubOpc.Size = new System.Drawing.Size(94, 15);
            this.lblSubOpc.TabIndex = 2;
            this.lblSubOpc.Text = "TextoSubOpcion";
            // 
            // grillaValidacion
            // 
            this.grillaValidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaValidacion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.grillaValidacion.Location = new System.Drawing.Point(407, 56);
            this.grillaValidacion.Name = "grillaValidacion";
            this.grillaValidacion.RowTemplate.Height = 25;
            this.grillaValidacion.Size = new System.Drawing.Size(470, 144);
            this.grillaValidacion.TabIndex = 3;
            this.grillaValidacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaValidacion_CellClick);
            this.grillaValidacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaValidacion_CellContentClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(126, 370);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(723, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "La categoria seleccionada es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "La opcion seleccionada es:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "La subopcion seleccionada es:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "El cliente seleccionado es:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(226, 38);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(72, 15);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "TextoCliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(407, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Validaciones pendientes:";
            // 
            // txtBoxRta
            // 
            this.txtBoxRta.Location = new System.Drawing.Point(407, 239);
            this.txtBoxRta.Multiline = true;
            this.txtBoxRta.Name = "txtBoxRta";
            this.txtBoxRta.Size = new System.Drawing.Size(224, 86);
            this.txtBoxRta.TabIndex = 12;
            this.txtBoxRta.Visible = false;
            // 
            // lblRta
            // 
            this.lblRta.AutoSize = true;
            this.lblRta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRta.Location = new System.Drawing.Point(50, 238);
            this.lblRta.Name = "lblRta";
            this.lblRta.Size = new System.Drawing.Size(159, 20);
            this.lblRta.TabIndex = 13;
            this.lblRta.Text = "Respuesta del operador:";
            this.lblRta.Visible = false;
            // 
            // btnResOp
            // 
            this.btnResOp.Location = new System.Drawing.Point(665, 264);
            this.btnResOp.Name = "btnResOp";
            this.btnResOp.Size = new System.Drawing.Size(195, 23);
            this.btnResOp.TabIndex = 14;
            this.btnResOp.Text = "Registrar Respuesta del Operador";
            this.btnResOp.UseVisualStyleBackColor = true;
            this.btnResOp.Visible = false;
            this.btnResOp.Click += new System.EventHandler(this.btnResOp_Click);
            // 
            // PantallaRegistrarRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btnResOp);
            this.Controls.Add(this.lblRta);
            this.Controls.Add(this.txtBoxRta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grillaValidacion);
            this.Controls.Add(this.lblSubOpc);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.lblCategoria);
            this.Name = "PantallaRegistrarRespuesta";
            this.Text = "PantallaRegistrarRespuesta";
            this.Load += new System.EventHandler(this.PantallaRegistrarRespuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCategoria;
        private Label lblOpcion;
        private Label lblSubOpc;
        private DataGridView grillaValidacion;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCliente;
        private Label label5;
        private TextBox txtBoxRta;
        private Label lblRta;
        private Button btnResOp;
    }
}