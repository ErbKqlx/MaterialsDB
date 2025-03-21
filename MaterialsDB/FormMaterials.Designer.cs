namespace MaterialsDB
{
    partial class FormMaterials
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonHistory = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            buttonAdd.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonAdd.FlatAppearance.MouseOverBackColor = Color.Black;
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
            buttonUpdate.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonUpdate.FlatAppearance.MouseOverBackColor = Color.Black;
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
            buttonDelete.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonDelete.FlatAppearance.MouseOverBackColor = Color.Black;
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
            buttonHistory.FlatAppearance.MouseDownBackColor = Color.Black;
            buttonHistory.FlatAppearance.MouseOverBackColor = Color.Black;
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
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 484);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(984, 484);
            dataGridView1.TabIndex = 0;
            // 
            // FormMaterials
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1004, 576);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormMaterials";
            Padding = new Padding(10);
            Text = "Материалы";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonHistory;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}
