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
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            tabControl1 = new TabControl();
            tab_Mascotas = new TabPage();
            flowLayoutPanel_Mascotas = new FlowLayoutPanel();
            tab_Productos = new TabPage();
            tabPage3 = new TabPage();
            tab_Suscripciones = new TabPage();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            tab_Mascotas.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 24);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Titulo: OnlyZoo";
            // 
            // button2
            // 
            button2.Location = new Point(762, 13);
            button2.Name = "button2";
            button2.Size = new Size(78, 31);
            button2.TabIndex = 1;
            button2.Text = "Sing Up";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(675, 12);
            button1.Name = "button1";
            button1.Size = new Size(81, 31);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_Mascotas);
            tabControl1.Controls.Add(tab_Productos);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tab_Suscripciones);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(859, 449);
            tabControl1.TabIndex = 0;
            // 
            // tab_Mascotas
            // 
            tab_Mascotas.Controls.Add(flowLayoutPanel_Mascotas);
            tab_Mascotas.Location = new Point(4, 24);
            tab_Mascotas.Name = "tab_Mascotas";
            tab_Mascotas.Padding = new Padding(3);
            tab_Mascotas.Size = new Size(851, 421);
            tab_Mascotas.TabIndex = 0;
            tab_Mascotas.Text = "Mascotas";
            tab_Mascotas.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_Mascotas
            // 
            flowLayoutPanel_Mascotas.AutoScroll = true;
            flowLayoutPanel_Mascotas.Dock = DockStyle.Fill;
            flowLayoutPanel_Mascotas.Location = new Point(3, 3);
            flowLayoutPanel_Mascotas.Name = "flowLayoutPanel_Mascotas";
            flowLayoutPanel_Mascotas.Size = new Size(845, 415);
            flowLayoutPanel_Mascotas.TabIndex = 0;
            // 
            // tab_Productos
            // 
            tab_Productos.Location = new Point(4, 24);
            tab_Productos.Name = "tab_Productos";
            tab_Productos.Padding = new Padding(3);
            tab_Productos.Size = new Size(851, 421);
            tab_Productos.TabIndex = 1;
            tab_Productos.Text = "Productos";
            tab_Productos.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(851, 421);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Merchandaising";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tab_Suscripciones
            // 
            tab_Suscripciones.Location = new Point(4, 24);
            tab_Suscripciones.Name = "tab_Suscripciones";
            tab_Suscripciones.Padding = new Padding(3);
            tab_Suscripciones.Size = new Size(851, 421);
            tab_Suscripciones.TabIndex = 3;
            tab_Suscripciones.Text = "Suscripciones";
            tab_Suscripciones.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 71);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 520);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "OnlyZoo";
            tabControl1.ResumeLayout(false);
            tab_Mascotas.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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