namespace nedoDatabase
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPesel = new TextBox();
            btnAdd = new Button();
            labelName = new Label();
            labelSurname = new Label();
            labelPesel = new Label();
            dataGridView1 = new DataGridView();
            columnName = new DataGridViewTextBoxColumn();
            columnSurname = new DataGridViewTextBoxColumn();
            columnPesel = new DataGridViewTextBoxColumn();
            columnWorker = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnSearch = new Button();
            btnClear = new Button();
            checkEmployee = new CheckBox();
            comboBox1 = new ComboBox();
            labelCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(122, 49);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(187, 31);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(122, 95);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(187, 31);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxPesel
            // 
            textBoxPesel.Location = new Point(122, 139);
            textBoxPesel.Name = "textBoxPesel";
            textBoxPesel.Size = new Size(187, 31);
            textBoxPesel.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(11, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += buttonAdd_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(12, 50);
            labelName.Name = "labelName";
            labelName.Size = new Size(76, 30);
            labelName.TabIndex = 4;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSurname.Location = new Point(12, 94);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(104, 30);
            labelSurname.TabIndex = 5;
            labelSurname.Text = "Surname:";
            // 
            // labelPesel
            // 
            labelPesel.AutoSize = true;
            labelPesel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPesel.Location = new Point(12, 140);
            labelPesel.Name = "labelPesel";
            labelPesel.Size = new Size(67, 30);
            labelPesel.TabIndex = 6;
            labelPesel.Text = "Pesel:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnName, columnSurname, columnPesel, columnWorker });
            dataGridView1.Location = new Point(12, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(817, 268);
            dataGridView1.TabIndex = 7;
            // 
            // columnName
            // 
            columnName.HeaderText = "Name";
            columnName.MinimumWidth = 10;
            columnName.Name = "columnName";
            columnName.ReadOnly = true;
            columnName.Width = 200;
            // 
            // columnSurname
            // 
            columnSurname.HeaderText = "Surname";
            columnSurname.MinimumWidth = 3;
            columnSurname.Name = "columnSurname";
            columnSurname.ReadOnly = true;
            columnSurname.Width = 250;
            // 
            // columnPesel
            // 
            columnPesel.HeaderText = "Pesel";
            columnPesel.MinimumWidth = 11;
            columnPesel.Name = "columnPesel";
            columnPesel.ReadOnly = true;
            columnPesel.Width = 150;
            // 
            // columnWorker
            // 
            columnWorker.HeaderText = "Employee";
            columnWorker.MinimumWidth = 8;
            columnWorker.Name = "columnWorker";
            columnWorker.Width = 150;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(129, 187);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(247, 187);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 40);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(365, 187);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // checkEmployee
            // 
            checkEmployee.AutoSize = true;
            checkEmployee.Location = new Point(365, 94);
            checkEmployee.Name = "checkEmployee";
            checkEmployee.Size = new Size(96, 29);
            checkEmployee.TabIndex = 11;
            checkEmployee.Text = "Teacher";
            checkEmployee.UseVisualStyleBackColor = true;
            checkEmployee.CheckedChanged += checkEmployee_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Teacher", "Student" });
            comboBox1.Location = new Point(618, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "All";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCount.Location = new Point(663, 185);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(100, 30);
            labelCount.TabIndex = 13;
            labelCount.Text = "Count:  0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 520);
            Controls.Add(labelCount);
            Controls.Add(comboBox1);
            Controls.Add(checkEmployee);
            Controls.Add(textBoxName);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(labelPesel);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(btnAdd);
            Controls.Add(textBoxPesel);
            Controls.Add(textBoxSurname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPesel;
        private Button btnAdd;
        private Label labelName;
        private Label labelSurname;
        private Label labelPesel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnSurname;
        private DataGridViewTextBoxColumn columnPesel;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnClear;
        private CheckBox checkEmployee;
        private DataGridViewTextBoxColumn columnWorker;
        private ComboBox comboBox1;
        private Label labelCount;
    }
}