partial class InputDialog
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label promptLabel;
    private System.Windows.Forms.TextBox inputTextBox;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;

    private void InitializeComponent()
    {
        this.promptLabel = new System.Windows.Forms.Label();
        this.inputTextBox = new System.Windows.Forms.TextBox();
        this.okButton = new System.Windows.Forms.Button();
        this.cancelButton = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // promptLabel
        this.promptLabel.AutoSize = true;
        this.promptLabel.Location = new System.Drawing.Point(12, 20);
        this.promptLabel.Name = "promptLabel";
        this.promptLabel.Size = new System.Drawing.Size(98, 17);
        this.promptLabel.TabIndex = 0;
        this.promptLabel.Text = "Enter value:";

        // inputTextBox
        this.inputTextBox.Location = new System.Drawing.Point(15, 50);
        this.inputTextBox.Name = "inputTextBox";
        this.inputTextBox.Size = new System.Drawing.Size(250, 22);
        this.inputTextBox.TabIndex = 1;

        // okButton
        this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.okButton.Location = new System.Drawing.Point(110, 90);
        this.okButton.Name = "okButton";
        this.okButton.Size = new System.Drawing.Size(75, 30);
        this.okButton.TabIndex = 2;
        this.okButton.Text = "OK";
        this.okButton.UseVisualStyleBackColor = true;
        this.okButton.Click += new System.EventHandler(this.okButton_Click);

        // cancelButton
        this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.cancelButton.Location = new System.Drawing.Point(205, 90);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new System.Drawing.Size(75, 30);
        this.cancelButton.TabIndex = 3;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);

        // InputDialog
        this.AcceptButton = this.okButton;
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.cancelButton;
        this.ClientSize = new System.Drawing.Size(280, 140);
        this.Controls.Add(this.cancelButton);
        this.Controls.Add(this.okButton);
        this.Controls.Add(this.inputTextBox);
        this.Controls.Add(this.promptLabel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable; // Разрешение изменения размеров окна
        this.MaximizeBox = true; // Разрешение максимизации окна
        this.MinimizeBox = true; // Разрешение минимизации окна
        this.Name = "InputDialog";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Input Dialog";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}