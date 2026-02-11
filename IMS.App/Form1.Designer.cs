namespace IMS.App
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxSearch = new TextBox();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxDescription = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label4 = new Label();
            buttonSave = new Button();
            buttonDelete = new Button();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(807, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 123;
            dataGridView1.Size = new Size(1361, 1245);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 179);
            label1.Name = "label1";
            label1.Size = new Size(273, 48);
            label1.TabIndex = 1;
            label1.Text = "Search Program";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(71, 259);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(732, 55);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(71, 437);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(732, 55);
            textBoxId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 357);
            label2.Name = "label2";
            label2.Size = new Size(51, 48);
            label2.TabIndex = 3;
            label2.Text = "Id";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(71, 790);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(732, 55);
            textBoxDescription.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 710);
            label3.Name = "label3";
            label3.Size = new Size(201, 48);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(71, 612);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(732, 55);
            textBoxName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 532);
            label4.Name = "label4";
            label4.Size = new Size(115, 48);
            label4.TabIndex = 5;
            label4.Text = "Name";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(71, 904);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(732, 69);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(71, 1026);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(732, 69);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1674, 1006);
            label5.Name = "label5";
            label5.Size = new Size(95, 48);
            label5.TabIndex = 11;
            label5.Text = "Total";
            label5.TextAlign = ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 1245);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 65);
            label6.Name = "label6";
            label6.Size = new Size(216, 48);
            label6.TabIndex = 12;
            label6.Text = "Proponent 1";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.Frozen = true;
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 15;
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 15;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Description";
            Column3.HeaderText = "Description";
            Column3.MinimumWidth = 15;
            Column3.Name = "Column3";
            Column3.Width = 300;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DataPropertyName = "SpecializationName";
            Column4.HeaderText = "Specializations";
            Column4.MinimumWidth = 15;
            Column4.Name = "Column4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(2168, 1245);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxSearch;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxDescription;
        private Label label3;
        private TextBox textBoxName;
        private Label label4;
        private Button buttonSave;
        private Button buttonDelete;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
