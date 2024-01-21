using System;
using System.Windows.Forms;

public partial class InputDialog : Form
{
    public string InputValue { get; private set; }

    public InputDialog(string prompt)
    {
        InitializeComponent();
        promptLabel.Text = prompt;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        InputValue = inputTextBox.Text;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}