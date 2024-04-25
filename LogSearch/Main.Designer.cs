namespace LogSearch
{
    partial class frmSearchLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchLog));
            fbdDirectory = new FolderBrowserDialog();
            txtPath = new TextBox();
            btnFolder = new Button();
            btnSearch = new Button();
            txtString = new TextBox();
            lblPath = new Label();
            lblString = new Label();
            panel1 = new Panel();
            btnExport = new Button();
            btnClear = new Button();
            panel2 = new Panel();
            rhTxt = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Enabled = false;
            txtPath.Location = new Point(25, 38);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(221, 23);
            txtPath.TabIndex = 0;
            // 
            // btnFolder
            // 
            btnFolder.Location = new Point(299, 38);
            btnFolder.Name = "btnFolder";
            btnFolder.Size = new Size(75, 23);
            btnFolder.TabIndex = 1;
            btnFolder.Text = "Procurar";
            btnFolder.UseVisualStyleBackColor = true;
            btnFolder.Click += btnFolder_Click;
            // 
            // btnSearch
            // 
            btnSearch.Enabled = false;
            btnSearch.Location = new Point(299, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 53);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtString
            // 
            txtString.Location = new Point(25, 53);
            txtString.Multiline = true;
            txtString.Name = "txtString";
            txtString.Size = new Size(221, 23);
            txtString.TabIndex = 3;
            txtString.TextChanged += txtString_TextChanged;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(25, 20);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(53, 15);
            lblPath.TabIndex = 4;
            lblPath.Text = "Diretório";
            // 
            // lblString
            // 
            lblString.AutoSize = true;
            lblString.Location = new Point(25, 35);
            lblString.Name = "lblString";
            lblString.Size = new Size(201, 15);
            lblString.TabIndex = 5;
            lblString.Text = "Digite a palavra que deseja encontrar";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblString);
            panel1.Controls.Add(txtString);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(12, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 123);
            panel1.TabIndex = 6;
            // 
            // btnExport
            // 
            btnExport.Enabled = false;
            btnExport.Location = new Point(419, 56);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 7;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnClear
            // 
            btnClear.Enabled = false;
            btnClear.Location = new Point(419, 23);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 27);
            btnClear.TabIndex = 6;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPath);
            panel2.Controls.Add(btnFolder);
            panel2.Controls.Add(txtPath);
            panel2.Location = new Point(12, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 98);
            panel2.TabIndex = 7;
            // 
            // rhTxt
            // 
            rhTxt.Location = new Point(12, 266);
            rhTxt.Name = "rhTxt";
            rhTxt.Size = new Size(507, 225);
            rhTxt.TabIndex = 8;
            rhTxt.Text = "";
            // 
            // frmSearchLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(531, 503);
            Controls.Add(rhTxt);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSearchLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisa Logs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog fbdDirectory;
        private TextBox txtPath;
        private Button btnFolder;
        private Button btnSearch;
        private TextBox txtString;
        private Label lblPath;
        private Label lblString;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox rhTxt;
        private Button btnClear;
        private Button btnExport;
    }
}
