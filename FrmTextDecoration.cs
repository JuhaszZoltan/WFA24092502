namespace WFA24092502
{
    public partial class FrmTextDecoration : Form
    {
        public FrmTextDecoration()
        {
            InitializeComponent();
            textbox.TextChanged += TextboxTextChanged;
            btnExit.Click += BtnExitClick;
            btnBluTxt.Click += BtnBluTxtClick;
            btnWhtBG.Click += BtnWhtBGClick;
            btnDelete.Click += BtnDeleteClick;
            btnMdlLft.Click += BtnMdlLftClick;
            btnMdlCnt.Click += BtnMdlCntClick;
            btnMldRgh.Click += BtnMldRghClick;
            btnUppercase.Click += BtnUppercaseClick;
            btnZoomIn.Click += BtnZoomInClick;
            btnZoomOut.Click += BtnZoomOutClick;
            btnDefault.Click += BtnDefaultClick;
        }

        private void BtnDefaultClick(object? sender, EventArgs e)
        {
            label.BackColor = Color.LightGray;
            label.Font = new("Consolas", 20.25F);
            label.ForeColor = Color.Black;
            label.Text = "Hello, World!";
            label.TextAlign = ContentAlignment.TopLeft;
        }

        private void BtnZoomOutClick(object? sender, EventArgs e)
        {
            if (label.Font.Size - 2 > 0)
                label.Font = new(label.Font.FontFamily, label.Font.Size - 2F);
        }
            

        private void BtnZoomInClick(object? sender, EventArgs e) => 
            label.Font = new(label.Font.FontFamily, label.Font.Size + 2F);

        private void BtnUppercaseClick(object? sender, EventArgs e) =>
            label.Text = label.Text.ToUpper();

        private void BtnMldRghClick(object? sender, EventArgs e) =>
            label.TextAlign = ContentAlignment.MiddleRight;

        private void BtnMdlCntClick(object? sender, EventArgs e) =>
            label.TextAlign = ContentAlignment.MiddleCenter;

        private void BtnMdlLftClick(object? sender, EventArgs e) =>
            label.TextAlign = ContentAlignment.MiddleLeft;

        private void BtnDeleteClick(object? sender, EventArgs e) =>
            label.Text = label.Text[..^1];

        private void BtnWhtBGClick(object? sender, EventArgs e) =>
            label.BackColor = Color.White;

        private void BtnBluTxtClick(object? sender, EventArgs e) =>
            label.ForeColor = Color.Blue;

        private void BtnExitClick(object? sender, EventArgs e) =>
            Application.Exit();

        private void TextboxTextChanged(object? sender, EventArgs e) =>
            label.Text = textbox.Text;
    }
}
