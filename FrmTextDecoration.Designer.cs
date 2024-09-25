namespace WFA24092502
{
    partial class FrmTextDecoration
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
            label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBluTxt = new Button();
            btnWhtBG = new Button();
            btnDelete = new Button();
            btnMldRgh = new Button();
            btnMdlCnt = new Button();
            btnMdlLft = new Button();
            btnUppercase = new Button();
            btnZoomIn = new Button();
            btnZoomOut = new Button();
            btnExit = new Button();
            btnDefault = new Button();
            textbox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.BackColor = Color.LightGray;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label.Location = new Point(19, 51);
            label.Margin = new Padding(10);
            label.Name = "label";
            label.Padding = new Padding(10);
            label.Size = new Size(462, 202);
            label.TabIndex = 0;
            label.Text = "Hello, World!";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnBluTxt, 0, 0);
            tableLayoutPanel1.Controls.Add(btnWhtBG, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel1.Controls.Add(btnMldRgh, 2, 1);
            tableLayoutPanel1.Controls.Add(btnMdlCnt, 1, 1);
            tableLayoutPanel1.Controls.Add(btnMdlLft, 0, 1);
            tableLayoutPanel1.Controls.Add(btnUppercase, 0, 2);
            tableLayoutPanel1.Controls.Add(btnZoomIn, 1, 2);
            tableLayoutPanel1.Controls.Add(btnZoomOut, 2, 2);
            tableLayoutPanel1.Controls.Add(btnExit, 2, 3);
            tableLayoutPanel1.Controls.Add(btnDefault, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 266);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(476, 222);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnBluTxt
            // 
            btnBluTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBluTxt.ForeColor = Color.Blue;
            btnBluTxt.Location = new Point(3, 3);
            btnBluTxt.Name = "btnBluTxt";
            btnBluTxt.Size = new Size(152, 49);
            btnBluTxt.TabIndex = 0;
            btnBluTxt.Text = "BLU TXT";
            btnBluTxt.UseVisualStyleBackColor = true;
            // 
            // btnWhtBG
            // 
            btnWhtBG.BackColor = Color.White;
            btnWhtBG.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnWhtBG.Location = new Point(161, 3);
            btnWhtBG.Name = "btnWhtBG";
            btnWhtBG.Size = new Size(152, 49);
            btnWhtBG.TabIndex = 0;
            btnWhtBG.Text = "WHT BG";
            btnWhtBG.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(319, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 49);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnMldRgh
            // 
            btnMldRgh.BackColor = Color.LightSteelBlue;
            btnMldRgh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMldRgh.Location = new Point(319, 58);
            btnMldRgh.Name = "btnMldRgh";
            btnMldRgh.Size = new Size(152, 49);
            btnMldRgh.TabIndex = 0;
            btnMldRgh.Text = "MDL RGH";
            btnMldRgh.TextAlign = ContentAlignment.MiddleRight;
            btnMldRgh.UseVisualStyleBackColor = false;
            // 
            // btnMdlCnt
            // 
            btnMdlCnt.BackColor = Color.LightSteelBlue;
            btnMdlCnt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMdlCnt.Location = new Point(161, 58);
            btnMdlCnt.Name = "btnMdlCnt";
            btnMdlCnt.Size = new Size(152, 49);
            btnMdlCnt.TabIndex = 0;
            btnMdlCnt.Text = "MDL CNT";
            btnMdlCnt.UseVisualStyleBackColor = false;
            // 
            // btnMdlLft
            // 
            btnMdlLft.BackColor = Color.LightSteelBlue;
            btnMdlLft.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMdlLft.Location = new Point(3, 58);
            btnMdlLft.Name = "btnMdlLft";
            btnMdlLft.Size = new Size(152, 49);
            btnMdlLft.TabIndex = 0;
            btnMdlLft.Text = "MDL LFT";
            btnMdlLft.TextAlign = ContentAlignment.MiddleLeft;
            btnMdlLft.UseVisualStyleBackColor = false;
            // 
            // btnUppercase
            // 
            btnUppercase.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUppercase.Location = new Point(3, 113);
            btnUppercase.Name = "btnUppercase";
            btnUppercase.Size = new Size(152, 49);
            btnUppercase.TabIndex = 0;
            btnUppercase.Text = "UPPERCASE";
            btnUppercase.UseVisualStyleBackColor = true;
            // 
            // btnZoomIn
            // 
            btnZoomIn.BackColor = Color.PapayaWhip;
            btnZoomIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnZoomIn.Location = new Point(161, 113);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(152, 49);
            btnZoomIn.TabIndex = 0;
            btnZoomIn.Text = "ZOOM IN";
            btnZoomIn.UseVisualStyleBackColor = false;
            // 
            // btnZoomOut
            // 
            btnZoomOut.BackColor = Color.PapayaWhip;
            btnZoomOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnZoomOut.Location = new Point(319, 113);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(152, 49);
            btnZoomOut.TabIndex = 0;
            btnZoomOut.Text = "ZOOM OUT";
            btnZoomOut.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DimGray;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(319, 168);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 49);
            btnExit.TabIndex = 0;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDefault
            // 
            btnDefault.BackColor = Color.DimGray;
            btnDefault.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDefault.ForeColor = Color.Lime;
            btnDefault.Location = new Point(3, 168);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(152, 49);
            btnDefault.TabIndex = 0;
            btnDefault.Text = "DEFAULT";
            btnDefault.UseVisualStyleBackColor = false;
            // 
            // textbox
            // 
            textbox.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textbox.Location = new Point(19, 12);
            textbox.Name = "textbox";
            textbox.PlaceholderText = "enter raw text here...";
            textbox.Size = new Size(462, 26);
            textbox.TabIndex = 2;
            // 
            // FrmTextDecoration
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 500);
            Controls.Add(textbox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "FrmTextDecoration";
            Text = "\"Szövegszerkesztő\"";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBluTxt;
        private Button btnWhtBG;
        private Button btnDelete;
        private Button btnMldRgh;
        private Button btnMdlCnt;
        private Button btnMdlLft;
        private Button btnUppercase;
        private Button btnZoomIn;
        private Button btnZoomOut;
        private Button btnExit;
        private Button btnDefault;
        private TextBox textbox;
    }
}
