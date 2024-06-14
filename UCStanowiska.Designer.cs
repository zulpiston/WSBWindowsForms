namespace GuiWarsztat
{
    partial class UCStanowiska
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            numericUpDown1 = new NumericUpDown();
            panel1 = new Panel();
            btnDodaj = new Button();
            btnUsun = new Button();
            label1 = new Label();
            stanowiskoBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            txtStanowisko = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stanowiskoBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            numericUpDown1.Location = new Point(139, 31);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 29);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(btnDodaj);
            panel1.Controls.Add(btnUsun);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(19, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 92);
            panel1.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(239, 21);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(173, 48);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "&DODAJ";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(439, 21);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(173, 48);
            btnUsun.TabIndex = 2;
            btnUsun.Text = "&USUŃ";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 1;
            label1.Text = "Stanowiska";
            // 
            // stanowiskoBindingSource
            // 
            stanowiskoBindingSource.DataSource = typeof(WarsztatSamochodowy.Dane.Stanowisko);
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(19, 172);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(640, 172);
            listBox1.TabIndex = 2;
            // 
            // txtStanowisko
            // 
            txtStanowisko.Location = new Point(11, 15);
            txtStanowisko.Name = "txtStanowisko";
            txtStanowisko.Size = new Size(472, 23);
            txtStanowisko.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(506, 14);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtStanowisko);
            panel2.Location = new Point(19, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 52);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            // 
            // UCStanowiska
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "UCStanowiska";
            Size = new Size(679, 385);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stanowiskoBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Panel panel1;
        private Button btnUsun;
        private Label label1;
        private BindingSource stanowiskoBindingSource;
        private ListBox listBox1;
        private Button btnDodaj;
        private TextBox txtStanowisko;
        private Button button1;
        private Panel panel2;
    }
}
