namespace MaterialsDB
{
    partial class FormSuppliers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonHistory = new Button();
            panel1 = new Panel();
            dataGridViewSuppliers = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Controls.Add(buttonUpdate);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(buttonHistory);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(10, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(984, 72);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.FlatAppearance.BorderColor = Color.Black;
            buttonAdd.FlatAppearance.CheckedBackColor = Color.Black;
            buttonAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Margin = new Padding(0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(175, 51);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.White;
            buttonUpdate.FlatAppearance.BorderColor = Color.Black;
            buttonUpdate.FlatAppearance.CheckedBackColor = Color.Black;
            buttonUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Location = new Point(175, 0);
            buttonUpdate.Margin = new Padding(0);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(264, 51);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Редактировать";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.FlatAppearance.BorderColor = Color.Black;
            buttonDelete.FlatAppearance.CheckedBackColor = Color.Black;
            buttonDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(439, 0);
            buttonDelete.Margin = new Padding(0);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(175, 51);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.White;
            buttonHistory.FlatAppearance.BorderColor = Color.Black;
            buttonHistory.FlatAppearance.CheckedBackColor = Color.Black;
            buttonHistory.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonHistory.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.Location = new Point(614, 0);
            buttonHistory.Margin = new Padding(0);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(370, 51);
            buttonHistory.TabIndex = 3;
            buttonHistory.Text = "История поставок";
            buttonHistory.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewSuppliers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 484);
            panel1.TabIndex = 1;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewSuppliers.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(10, 5, 10, 5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(103, 186, 128);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSuppliers.Dock = DockStyle.Fill;
            dataGridViewSuppliers.Location = new Point(0, 0);
            dataGridViewSuppliers.MultiSelect = false;
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.ReadOnly = true;
            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSuppliers.Size = new Size(984, 484);
            dataGridViewSuppliers.TabIndex = 0;
            // 
            // FormSuppliers
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1004, 576);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormSuppliers";
            Padding = new Padding(10);
            Text = "Поставщики";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonHistory;
        private Panel panel1;
        private DataGridView dataGridViewSuppliers;
    }
}
