
namespace Yamy_Desktop.Views
{
    partial class PreciosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Aplicar = new System.Windows.Forms.Button();
            this.gb_Confirmar = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btb_Cancelar = new System.Windows.Forms.Button();
            this.gb_Confirmar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajuste de Precios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de ajuste";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aumento",
            "Reducción"});
            this.comboBox1.Location = new System.Drawing.Point(318, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese el porcentaje";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(318, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "%     (Solo números)";
            // 
            // btn_Aplicar
            // 
            this.btn_Aplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aplicar.Location = new System.Drawing.Point(218, 233);
            this.btn_Aplicar.Name = "btn_Aplicar";
            this.btn_Aplicar.Size = new System.Drawing.Size(181, 46);
            this.btn_Aplicar.TabIndex = 6;
            this.btn_Aplicar.Text = "Aplicar Ajuste";
            this.btn_Aplicar.UseVisualStyleBackColor = true;
            this.btn_Aplicar.Click += new System.EventHandler(this.btn_Aplicar_Click);
            // 
            // gb_Confirmar
            // 
            this.gb_Confirmar.Controls.Add(this.btb_Cancelar);
            this.gb_Confirmar.Controls.Add(this.btnConfirmar);
            this.gb_Confirmar.Controls.Add(this.label11);
            this.gb_Confirmar.Controls.Add(this.label10);
            this.gb_Confirmar.Controls.Add(this.lbl_porcentaje);
            this.gb_Confirmar.Controls.Add(this.label8);
            this.gb_Confirmar.Controls.Add(this.label7);
            this.gb_Confirmar.Controls.Add(this.lbl_tipo);
            this.gb_Confirmar.Controls.Add(this.label5);
            this.gb_Confirmar.Location = new System.Drawing.Point(4, 314);
            this.gb_Confirmar.Name = "gb_Confirmar";
            this.gb_Confirmar.Size = new System.Drawing.Size(616, 175);
            this.gb_Confirmar.TabIndex = 7;
            this.gb_Confirmar.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(255, 101);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 46);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estás practicando un/a ";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_tipo.Location = new System.Drawing.Point(251, 25);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(104, 24);
            this.lbl_tipo.TabIndex = 5;
            this.lbl_tipo.Text = "reduccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "a tus precios de costo.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Este ajuste será del ";
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_porcentaje.Location = new System.Drawing.Point(238, 65);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(32, 24);
            this.lbl_porcentaje.TabIndex = 8;
            this.lbl_porcentaje.Text = "xx";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(344, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "% y cambiará los precios al público.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "¿Confirma el cambio?";
            // 
            // btb_Cancelar
            // 
            this.btb_Cancelar.BackColor = System.Drawing.Color.Crimson;
            this.btb_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_Cancelar.Location = new System.Drawing.Point(401, 101);
            this.btb_Cancelar.Name = "btb_Cancelar";
            this.btb_Cancelar.Size = new System.Drawing.Size(134, 46);
            this.btb_Cancelar.TabIndex = 11;
            this.btb_Cancelar.Text = "Cancelar";
            this.btb_Cancelar.UseVisualStyleBackColor = false;
            this.btb_Cancelar.Click += new System.EventHandler(this.btb_Cancelar_Click);
            // 
            // PreciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.gb_Confirmar);
            this.Controls.Add(this.btn_Aplicar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreciosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste de Precios";
            this.Load += new System.EventHandler(this.PreciosForm_Load);
            this.gb_Confirmar.ResumeLayout(false);
            this.gb_Confirmar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Aplicar;
        private System.Windows.Forms.GroupBox gb_Confirmar;
        private System.Windows.Forms.Button btb_Cancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label label5;
    }
}