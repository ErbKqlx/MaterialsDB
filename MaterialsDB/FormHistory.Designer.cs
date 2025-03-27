namespace MaterialsDB
{
    partial class FormHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelName = new Label();
            panel2 = new Panel();
            dataGridViewHistory = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(15, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 73);
            panel1.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(3, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(179, 25);
            labelName.TabIndex = 0;
            labelName.Text = "История поставок: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewHistory);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(15, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(1065, 404);
            panel2.TabIndex = 1;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistory.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(103, 186, 128);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHistory.Dock = DockStyle.Fill;
            dataGridViewHistory.Location = new Point(0, 0);
            dataGridViewHistory.MultiSelect = false;
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.ReadOnly = true;
            dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistory.Size = new Size(1065, 404);
            dataGridViewHistory.TabIndex = 0;
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1095, 507);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormHistory";
            Padding = new Padding(15);
            Text = "История поставок";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewHistory;
        public Label labelName;
    }
}