namespace w69825___Projekt
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


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
            loadKlientButton = new Button();
            Title = new Label();
            dataGridView1 = new DataGridView();
            LoadRezerwacjaButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // loadKlientButton
            // 
            loadKlientButton.Location = new Point(184, 336);
            loadKlientButton.Name = "loadKlientButton";
            loadKlientButton.Size = new Size(96, 41);
            loadKlientButton.TabIndex = 0;
            loadKlientButton.Text = "Wyświetl klientów";
            loadKlientButton.UseVisualStyleBackColor = true;
            loadKlientButton.Click += loadKlientButton_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(332, 31);
            Title.Name = "Title";
            Title.Size = new Size(141, 15);
            Title.TabIndex = 1;
            Title.Text = "Salon Barberski \"Brzytwa\"";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(184, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(671, 281);
            dataGridView1.TabIndex = 2;
            // 
            // LoadRezerwacjaButton
            // 
            LoadRezerwacjaButton.Location = new Point(286, 336);
            LoadRezerwacjaButton.Name = "LoadRezerwacjaButton";
            LoadRezerwacjaButton.Size = new Size(96, 41);
            LoadRezerwacjaButton.TabIndex = 3;
            LoadRezerwacjaButton.Text = "Wyświetl rezerwacje";
            LoadRezerwacjaButton.UseVisualStyleBackColor = true;
            LoadRezerwacjaButton.Click += LoadRezerwacjaButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 491);
            Controls.Add(LoadRezerwacjaButton);
            Controls.Add(dataGridView1);
            Controls.Add(Title);
            Controls.Add(loadKlientButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadKlientButton;
        private Label Title;
        private DataGridView dataGridView1;
        private Button LoadRezerwacjaButton;
    }
}
