namespace WFA24092502
{
    public partial class FrmTextDecoration : Form
    {
        public FrmTextDecoration()
        {
            InitializeComponent();
            textbox.TextChanged += TextboxTextChanged;
        }

        private void TextboxTextChanged(object? sender, EventArgs e) =>
            label.Text = textbox.Text;
    }
}
