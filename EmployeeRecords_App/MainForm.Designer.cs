namespace EmployeeRecords_App
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // addButton
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(200, 40);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить сотрудника";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            // deleteButton
            this.deleteButton.Location = new System.Drawing.Point(12, 58);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 40);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить сотрудника";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);

            // displayButton
            this.displayButton.Location = new System.Drawing.Point(12, 104);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(200, 40);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Отобразить список сотрудников";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);

            // getInfoButton
            this.getInfoButton.Location = new System.Drawing.Point(12, 150);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(200, 40);
            this.getInfoButton.TabIndex = 3;
            this.getInfoButton.Text = "Получить информацию по ID";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);

            // exitButton
            this.exitButton.Location = new System.Drawing.Point(12, 196);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выйти из программы";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            // outbox
            this.outbox.Location = new System.Drawing.Point(218, 12);
            this.outbox.Multiline = true;
            this.outbox.Name = "outbox";
            this.outbox.ReadOnly = true;
            this.outbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outbox.Size = new System.Drawing.Size(500, 224);
            this.outbox.TabIndex = 5;
            this.outbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 250); // Updated form size
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Records App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox outbox;
    }
}