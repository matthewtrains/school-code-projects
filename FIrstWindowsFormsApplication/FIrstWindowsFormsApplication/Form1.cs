using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Web.WebView2.Core;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIrstWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        Stack<string> UndoB = new Stack<string>();
        Stack<string> ForwardB = new Stack<string>();
        //int Undo = 0;
        int Undoclick = 0;
        //int InfoEntered = 0;
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += EnsureHttps;

            Back.Enabled = false;
            Forward.Enabled = false;

        }


        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            goButton.Left = this.ClientSize.Width - goButton.Width;
            addressBar.Width = goButton.Left - addressBar.Left;
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                args.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void goButton_Click_1(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {

                if (Undoclick == 0)
                {
                    webView.CoreWebView2.Navigate(addressBar.Text);
                
                    
                    UndoB.Push(addressBar.Text);
                }
                //InfoEntered = 1;
            }
            checkStackButtons();
        }

        // Undo Button
        private void button1_Click(object sender, EventArgs e)
        {
            //UndoB.Pop();
                Undoclick = 1;
                UndoB.Pop();

            if (UndoB.Count > 0)
            {
                addressBar.Text = UndoB.Peek().ToString();
                webView.CoreWebView2.Navigate(addressBar.Text);
                ForwardB.Push(UndoB.Peek());
                webView.CoreWebView2.Navigate(addressBar.Text);
            }

            checkStackButtons();

            //addressBar.Text. = UndoB.Peek();
            // Gets Rid of the site you just went back to from the undo list

            //webView.CoreWebView2.Navigate(addressBar.Text);

            Undoclick = 0;

                //ForwardB.Push(addressBar.Text);
                //webView.CoreWebView2.Navigate(UndoB.Peek());
                //ForwardB.Push(addressBar.Text);
                //addressBar.Text = UndoB.Peek();

                //UndoB.Pop();
                //Undo--;
            
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
       {
            int once = 0;
            if (once != 1)
            {
                if (e.KeyChar == (char)Keys.Return)
                {

                    goButton_Click_1(sender, e);
                }
            }
            once = 1;
            
        }

        private void addressBar_TextChanged(object sender, EventArgs e)
        {
           // this.addressBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

        }

        private void Forward_Click(object sender, EventArgs e)
        {
            

            if (ForwardB != null)
            {
                ForwardB.Pop();
                // Puts the page your on into the undo stack before you go forward
                if (ForwardB.Count > 0)
                {
                    UndoB.Push(addressBar.Text);

                    addressBar.Text = ForwardB.Peek();
                    webView.CoreWebView2.Navigate(addressBar.Text);
                }

                // Removes the site you just forwarrded to from the stakc


                //webView.CoreWebView2.Navigate(ForwardB.Peek());
                //UndoB.Push(ForwardB.Peek());
                //ForwardB.Pop();

                // Undo--;
            }
        }

        private void checkStackButtons()
        {
            if (UndoB.Count == 0)
            {
                Back.Enabled = false;
            }
            else
            {
                Back.Enabled = true;
            }
            if (ForwardB.Count == 0)
            {
                Forward.Enabled = false;
            }
            else
            {
                Forward.Enabled = true;
            }
        }
    }
}
