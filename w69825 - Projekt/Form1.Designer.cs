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
            loadDataButton = new Button();
            Title = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // loadDataButton
            // 
            loadDataButton.Location = new Point(184, 336);
            loadDataButton.Name = "loadDataButton";
            loadDataButton.Size = new Size(74, 36);
            loadDataButton.TabIndex = 0;
            loadDataButton.Text = "load data";
            loadDataButton.UseVisualStyleBackColor = true;
            loadDataButton.Click += loadDataButton_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 491);
            Controls.Add(dataGridView1);
            Controls.Add(Title);
            Controls.Add(loadDataButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadDataButton;
        private Label Title;
        private DataGridView dataGridView1;
    }
}
