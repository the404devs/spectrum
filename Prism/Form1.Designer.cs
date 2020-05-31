namespace Prism
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlWheel = new System.Windows.Forms.Panel();
            this.pnlColour = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbGradient = new System.Windows.Forms.PictureBox();
            this.pnlGradient = new System.Windows.Forms.Panel();
            this.arrow = new System.Windows.Forms.PictureBox();
            this.lblCopyHex = new System.Windows.Forms.Label();
            this.lblCopyRGB = new System.Windows.Forms.Label();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGradient)).BeginInit();
            this.pnlGradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Purple;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlWheel
            // 
            this.pnlWheel.BackColor = System.Drawing.Color.Black;
            this.pnlWheel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlWheel.Location = new System.Drawing.Point(5, 34);
            this.pnlWheel.Name = "pnlWheel";
            this.pnlWheel.Size = new System.Drawing.Size(200, 200);
            this.pnlWheel.TabIndex = 1;
            this.pnlWheel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWheel_Paint);
            this.pnlWheel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlWheel_MouseDown);
            this.pnlWheel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlWheel_MouseMove);
            this.pnlWheel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlWheel_MouseUp);
            // 
            // pnlColour
            // 
            this.pnlColour.BackColor = System.Drawing.Color.White;
            this.pnlColour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColour.Location = new System.Drawing.Point(5, 240);
            this.pnlColour.Name = "pnlColour";
            this.pnlColour.Size = new System.Drawing.Size(200, 33);
            this.pnlColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlColour.TabIndex = 2;
            this.pnlColour.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(127, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(95, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "100%";
            // 
            // pbGradient
            // 
            this.pbGradient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGradient.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbGradient.Image = global::Prism.Properties.Resources.gradient;
            this.pbGradient.Location = new System.Drawing.Point(0, 22);
            this.pbGradient.Name = "pbGradient";
            this.pbGradient.Size = new System.Drawing.Size(33, 200);
            this.pbGradient.TabIndex = 8;
            this.pbGradient.TabStop = false;
            this.pbGradient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGradient_MouseDown_1);
            this.pbGradient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGradient_MouseMove_1);
            this.pbGradient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbGradient_MouseUp);
            // 
            // pnlGradient
            // 
            this.pnlGradient.Controls.Add(this.arrow);
            this.pnlGradient.Controls.Add(this.pbGradient);
            this.pnlGradient.Controls.Add(this.label4);
            this.pnlGradient.Location = new System.Drawing.Point(214, 12);
            this.pnlGradient.Name = "pnlGradient";
            this.pnlGradient.Size = new System.Drawing.Size(58, 243);
            this.pnlGradient.TabIndex = 9;
            // 
            // arrow
            // 
            this.arrow.Image = global::Prism.Properties.Resources.triangle;
            this.arrow.Location = new System.Drawing.Point(33, 211);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(10, 20);
            this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow.TabIndex = 10;
            this.arrow.TabStop = false;
            // 
            // lblCopyHex
            // 
            this.lblCopyHex.BackColor = System.Drawing.Color.Black;
            this.lblCopyHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCopyHex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyHex.ForeColor = System.Drawing.Color.White;
            this.lblCopyHex.Location = new System.Drawing.Point(5, 299);
            this.lblCopyHex.Name = "lblCopyHex";
            this.lblCopyHex.Size = new System.Drawing.Size(117, 23);
            this.lblCopyHex.TabIndex = 13;
            this.lblCopyHex.Text = "Copy Hex Value";
            this.lblCopyHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopyHex.Click += new System.EventHandler(this.lblCopyHex_Click);
            this.lblCopyHex.MouseEnter += new System.EventHandler(this.lblCopyHex_MouseEnter);
            this.lblCopyHex.MouseLeave += new System.EventHandler(this.lblCopyHex_MouseLeave);
            // 
            // lblCopyRGB
            // 
            this.lblCopyRGB.BackColor = System.Drawing.Color.Black;
            this.lblCopyRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCopyRGB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRGB.ForeColor = System.Drawing.Color.White;
            this.lblCopyRGB.Location = new System.Drawing.Point(140, 299);
            this.lblCopyRGB.Name = "lblCopyRGB";
            this.lblCopyRGB.Size = new System.Drawing.Size(117, 23);
            this.lblCopyRGB.TabIndex = 14;
            this.lblCopyRGB.Text = "Copy RGB Values";
            this.lblCopyRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopyRGB.Click += new System.EventHandler(this.lblCopyRGB_Click);
            this.lblCopyRGB.MouseEnter += new System.EventHandler(this.lblCopyRGB_MouseEnter);
            this.lblCopyRGB.MouseLeave += new System.EventHandler(this.lblCopyRGB_MouseLeave);
            // 
            // txtHex
            // 
            this.txtHex.BackColor = System.Drawing.Color.Black;
            this.txtHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHex.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtHex.ForeColor = System.Drawing.Color.White;
            this.txtHex.Location = new System.Drawing.Point(5, 277);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(81, 20);
            this.txtHex.TabIndex = 15;
            this.txtHex.Text = "#FFFFFF";
            this.txtHex.TextChanged += new System.EventHandler(this.txtHex_TextChanged);
            // 
            // txtR
            // 
            this.txtR.BackColor = System.Drawing.Color.Black;
            this.txtR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtR.ForeColor = System.Drawing.Color.Red;
            this.txtR.Location = new System.Drawing.Point(159, 277);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(36, 20);
            this.txtR.TabIndex = 16;
            this.txtR.Text = "255";
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtG
            // 
            this.txtG.BackColor = System.Drawing.Color.Black;
            this.txtG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtG.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtG.ForeColor = System.Drawing.Color.Green;
            this.txtG.Location = new System.Drawing.Point(195, 277);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(36, 20);
            this.txtG.TabIndex = 17;
            this.txtG.Text = "255";
            this.txtG.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.Black;
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtB.ForeColor = System.Drawing.Color.Blue;
            this.txtB.Location = new System.Drawing.Point(230, 277);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(36, 20);
            this.txtB.TabIndex = 18;
            this.txtB.Text = "255";
            this.txtB.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(264, 326);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCopyRGB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCopyHex);
            this.Controls.Add(this.pnlColour);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlGradient);
            this.Controls.Add(this.pnlWheel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 365);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 365);
            this.Name = "Form1";
            this.Text = "Spectrum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGradient)).EndInit();
            this.pnlGradient.ResumeLayout(false);
            this.pnlGradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlWheel;
        private System.Windows.Forms.PictureBox pnlColour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbGradient;
        private System.Windows.Forms.Panel pnlGradient;
        private System.Windows.Forms.PictureBox arrow;
        private System.Windows.Forms.Label lblCopyHex;
        private System.Windows.Forms.Label lblCopyRGB;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
    }
}

