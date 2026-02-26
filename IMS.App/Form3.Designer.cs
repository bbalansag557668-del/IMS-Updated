namespace IMS.App
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            textBoxId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxDescription = new TextBox();
            label4 = new Label();
            comboBoxPrograms = new ComboBox();
            programServiceBindingSource = new BindingSource(components);
            buttonConfirm = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)programServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(43, 152);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(690, 55);
            textBoxId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 63);
            label1.Name = "label1";
            label1.Size = new Size(51, 48);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 248);
            label2.Name = "label2";
            label2.Size = new Size(115, 48);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(43, 337);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(690, 55);
            textBoxName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 433);
            label3.Name = "label3";
            label3.Size = new Size(201, 48);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(43, 522);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(690, 55);
            textBoxDescription.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 618);
            label4.Name = "label4";
            label4.Size = new Size(262, 48);
            label4.TabIndex = 6;
            label4.Text = "Select Program";
            // 
            // comboBoxPrograms
            // 
            comboBoxPrograms.DataSource = programServiceBindingSource;
            comboBoxPrograms.FormattingEnabled = true;
            comboBoxPrograms.Location = new Point(43, 707);
            comboBoxPrograms.Name = "comboBoxPrograms";
            comboBoxPrograms.Size = new Size(690, 56);
            comboBoxPrograms.TabIndex = 7;
            // 
            // programServiceBindingSource
            // 
            programServiceBindingSource.DataSource = typeof(Service.Repositories.ProgramService);
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(43, 804);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(690, 69);
            buttonConfirm.TabIndex = 8;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(771, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 123;
            dataGridView1.Size = new Size(870, 833);
            dataGridView1.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1676, 948);
            Controls.Add(dataGridView1);
            Controls.Add(buttonConfirm);
            Controls.Add(comboBoxPrograms);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxDescription);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Name = "Form3";
            Text = "Specialization Information";
            ((System.ComponentModel.ISupportInitialize)programServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxDescription;
        private Label label4;
        private ComboBox comboBoxPrograms;
        private Button buttonConfirm;
        private DataGridView dataGridView1;
        private BindingSource programServiceBindingSource;
    }
}