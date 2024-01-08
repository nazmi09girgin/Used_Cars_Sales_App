namespace Used_Cars_Sales_App
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(194, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 31);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 63);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 1;
            label1.Text = "Araç Türü:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 431);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlan Ara";
            // 
            // button1
            // 
            button1.Location = new Point(194, 270);
            button1.Name = "button1";
            button1.Size = new Size(151, 58);
            button1.TabIndex = 6;
            button1.Text = "Araç Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 30);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 30);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 177);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 3;
            label3.Text = "Model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 124);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 2;
            label2.Text = "Marka:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ScrollBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1089, 219);
            dataGridView1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Used_Cars_Sales_App.Properties.Resources.search;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(40, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 379);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(595, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 431);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(32, 499);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1124, 268);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Arama Sonuçları";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Used_Cars_Sales_App.Properties.Resources.N_logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1195, 785);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}