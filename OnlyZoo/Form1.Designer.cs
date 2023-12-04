namespace OnlyZoo
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Mascotas = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_Mascotas = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_Productos = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tab_Suscripciones = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tab_Mascotas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo: OnlyZoo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(762, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sing Up";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(675, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Mascotas);
            this.tabControl1.Controls.Add(this.tab_Productos);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tab_Suscripciones);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Mascotas
            // 
            this.tab_Mascotas.Controls.Add(this.flowLayoutPanel_Mascotas);
            this.tab_Mascotas.Location = new System.Drawing.Point(4, 24);
            this.tab_Mascotas.Name = "tab_Mascotas";
            this.tab_Mascotas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Mascotas.Size = new System.Drawing.Size(851, 421);
            this.tab_Mascotas.TabIndex = 0;
            this.tab_Mascotas.Text = "Mascotas";
            this.tab_Mascotas.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_Mascotas
            // 
            this.flowLayoutPanel_Mascotas.AutoScroll = true;
            this.flowLayoutPanel_Mascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Mascotas.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_Mascotas.Name = "flowLayoutPanel_Mascotas";
            this.flowLayoutPanel_Mascotas.Size = new System.Drawing.Size(845, 415);
            this.flowLayoutPanel_Mascotas.TabIndex = 0;
            // 
            // tab_Productos
            // 
            this.tab_Productos.Location = new System.Drawing.Point(4, 24);
            this.tab_Productos.Name = "tab_Productos";
            this.tab_Productos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Productos.Size = new System.Drawing.Size(851, 421);
            this.tab_Productos.TabIndex = 1;
            this.tab_Productos.Text = "Productos";
            this.tab_Productos.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(851, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Merchandaising";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tab_Suscripciones
            // 
            this.tab_Suscripciones.Location = new System.Drawing.Point(4, 24);
            this.tab_Suscripciones.Name = "tab_Suscripciones";
            this.tab_Suscripciones.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Suscripciones.Size = new System.Drawing.Size(851, 421);
            this.tab_Suscripciones.TabIndex = 3;
            this.tab_Suscripciones.Text = "Suscripciones";
            this.tab_Suscripciones.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(97)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 71);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 520);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "OnlyZoo";
            this.tabControl1.ResumeLayout(false);
            this.tab_Mascotas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl1;
        private TabPage tab_Mascotas;
        private TabPage tab_Productos;
        private TabPage tabPage3;
        private Button button2;
        private Button button1;
        private TabPage tab_Suscripciones;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel_Mascotas;
        private Panel panel1;
    }
}