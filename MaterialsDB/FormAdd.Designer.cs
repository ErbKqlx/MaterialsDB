namespace MaterialsDB
{
    partial class FormAdd
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            name = new TextBox();
            inn = new TextBox();
            active = new CheckBox();
            typesOfSupplier = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 267);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(631, 71);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(497, 3);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 0;
            button1.Text = "Отменить";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(360, 3);
            button2.Name = "button2";
            button2.Size = new Size(131, 45);
            button2.TabIndex = 1;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 1;
            label1.Text = "Тип поставщика:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 2;
            label2.Text = "Наименование:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 164);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 3;
            label3.Text = "Действующий:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 121);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 4;
            label4.Text = "ИНН:";
            // 
            // name
            // 
            name.Location = new Point(191, 72);
            name.Name = "name";
            name.Size = new Size(190, 33);
            name.TabIndex = 6;
            // 
            // inn
            // 
            inn.Location = new Point(191, 122);
            inn.Name = "inn";
            inn.Size = new Size(190, 33);
            inn.TabIndex = 7;
            // 
            // active
            // 
            active.AutoSize = true;
            active.Location = new Point(191, 173);
            active.Name = "active";
            active.Size = new Size(15, 14);
            active.TabIndex = 8;
            active.UseVisualStyleBackColor = true;
            // 
            // typesOfSupplier
            // 
            typesOfSupplier.FormattingEnabled = true;
            typesOfSupplier.Location = new Point(191, 24);
            typesOfSupplier.Name = "typesOfSupplier";
            typesOfSupplier.Size = new Size(190, 33);
            typesOfSupplier.TabIndex = 9;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(631, 338);
            Controls.Add(typesOfSupplier);
            Controls.Add(active);
            Controls.Add(inn);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAdd";
            Text = "Добавление поставщика";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox name;
        public TextBox inn;
        public CheckBox active;
        public ComboBox typesOfSupplier;
    }
}