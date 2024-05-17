namespace pryPeriottiEtapa3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCrearVhiculo = new Button();
            rbMoto = new RadioButton();
            rbAvion = new RadioButton();
            rbAuto = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            lblNombre = new Label();
            lblTipo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearVhiculo);
            groupBox1.Controls.Add(rbMoto);
            groupBox1.Controls.Add(rbAvion);
            groupBox1.Controls.Add(rbAuto);
            groupBox1.Location = new Point(12, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Vehículo";
            // 
            // btnCrearVhiculo
            // 
            btnCrearVhiculo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearVhiculo.Location = new Point(160, 85);
            btnCrearVhiculo.Name = "btnCrearVhiculo";
            btnCrearVhiculo.Size = new Size(223, 35);
            btnCrearVhiculo.TabIndex = 3;
            btnCrearVhiculo.Text = "Crear Vehiculo";
            btnCrearVhiculo.UseVisualStyleBackColor = true;
            btnCrearVhiculo.Click += btnCrearVhiculo_Click;
            // 
            // rbMoto
            // 
            rbMoto.AutoSize = true;
            rbMoto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rbMoto.Location = new Point(231, 33);
            rbMoto.Name = "rbMoto";
            rbMoto.Size = new Size(79, 32);
            rbMoto.TabIndex = 1;
            rbMoto.Text = "Moto";
            rbMoto.UseVisualStyleBackColor = true;
            // 
            // rbAvion
            // 
            rbAvion.AutoSize = true;
            rbAvion.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rbAvion.Location = new Point(400, 33);
            rbAvion.Name = "rbAvion";
            rbAvion.Size = new Size(81, 32);
            rbAvion.TabIndex = 2;
            rbAvion.Text = "Avión";
            rbAvion.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            rbAuto.AutoSize = true;
            rbAuto.Checked = true;
            rbAuto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rbAuto.Location = new Point(65, 33);
            rbAuto.Name = "rbAuto";
            rbAuto.Size = new Size(73, 32);
            rbAuto.TabIndex = 0;
            rbAuto.TabStop = true;
            rbAuto.Text = "Auto";
            rbAuto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 37);
            label1.TabIndex = 1;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(327, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 37);
            label2.TabIndex = 2;
            label2.Text = "TIPO:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(172, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(149, 37);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "____________";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(412, 9);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(149, 37);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "____________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 515);
            Controls.Add(lblTipo);
            Controls.Add(lblNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximumSize = new Size(592, 554);
            MinimumSize = new Size(592, 554);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCrearVhiculo;
        private RadioButton rbMoto;
        private RadioButton rbAvion;
        private RadioButton rbAuto;
        private Label label1;
        private Label label2;
        private Label lblNombre;
        private Label lblTipo;
    }
}
