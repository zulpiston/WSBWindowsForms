namespace GuiWarsztat
{
    partial class UCKalendarz
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
            panel1 = new Panel();
            btnDodaj = new Button();
            btnUsun = new Button();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            zdarzenieBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zdarzenieBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnDodaj);
            panel1.Controls.Add(btnUsun);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 92);
            panel1.TabIndex = 2;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 1;
            label1.Text = "Kalendarz";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 120);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // zdarzenieBindingSource
            // 
            zdarzenieBindingSource.DataSource = typeof(WarsztatSamochodowy.Dane.Zdarzenie);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = zdarzenieBindingSource;
            dataGridView1.Location = new Point(299, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(791, 432);
            dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(678, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(912, 21);
            button1.Name = "button1";
            button1.Size = new Size(137, 48);
            button1.TabIndex = 5;
            button1.Text = "&FILTRUJ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UCKalendarz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(monthCalendar1);
            Controls.Add(panel1);
            Name = "UCKalendarz";
            Size = new Size(1112, 588);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zdarzenieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnDodaj;
        private Button btnUsun;
        private Label label1;
        private MonthCalendar monthCalendar1;
        public BindingSource zdarzenieBindingSource;
        public DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
    }
}
