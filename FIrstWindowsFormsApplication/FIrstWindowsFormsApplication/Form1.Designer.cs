namespace FIrstWindowsFormsApplication
{
    partial class Form1
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
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.goButton = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(-1, 38);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(807, 446);
            this.webView.Source = new System.Uri("https://microsoft.com", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            this.webView.Click += new System.EventHandler(this.webView21_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(727, 10);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(61, 20);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "GO!!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click_1);
            // 
            // addressBar
            // 
            this.addressBar.Location = new System.Drawing.Point(145, 10);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(576, 20);
            this.addressBar.TabIndex = 2;
            this.addressBar.TextChanged += new System.EventHandler(this.addressBar_TextChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 7);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(59, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(77, 7);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(62, 23);
            this.Forward.TabIndex = 4;
            this.Forward.Text = "Forward";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.webView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
    }
}

