namespace EEditor
{
    partial class NewDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDialogForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSizeList = new System.Windows.Forms.Button();
            this.nUHeight = new System.Windows.Forms.NumericUpDown();
            this.lHeight = new System.Windows.Forms.Label();
            this.nUWidth = new System.Windows.Forms.NumericUpDown();
            this.lWidth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbowner = new System.Windows.Forms.TextBox();
            this.tbtitle = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.ltitle = new System.Windows.Forms.Label();
            this.lblMade = new System.Windows.Forms.Label();
            this.rbEEOEditor = new System.Windows.Forms.RadioButton();
            this.rbEEOffline = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSizeList);
            this.groupBox1.Controls.Add(this.nUHeight);
            this.groupBox1.Controls.Add(this.lHeight);
            this.groupBox1.Controls.Add(this.nUWidth);
            this.groupBox1.Controls.Add(this.lWidth);
            this.groupBox1.Location = new System.Drawing.Point(11, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // btnSizeList
            // 
            this.btnSizeList.Location = new System.Drawing.Point(139, 38);
            this.btnSizeList.Name = "btnSizeList";
            this.btnSizeList.Size = new System.Drawing.Size(75, 26);
            this.btnSizeList.TabIndex = 4;
            this.btnSizeList.Text = "Size List";
            this.btnSizeList.UseVisualStyleBackColor = true;
            this.btnSizeList.Click += new System.EventHandler(this.btnSizeList_Click);
            // 
            // nUHeight
            // 
            this.nUHeight.Location = new System.Drawing.Point(56, 49);
            this.nUHeight.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nUHeight.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUHeight.Name = "nUHeight";
            this.nUHeight.Size = new System.Drawing.Size(77, 20);
            this.nUHeight.TabIndex = 3;
            this.nUHeight.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(12, 51);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(38, 13);
            this.lHeight.TabIndex = 2;
            this.lHeight.Text = "Height";
            // 
            // nUWidth
            // 
            this.nUWidth.Location = new System.Drawing.Point(56, 25);
            this.nUWidth.Maximum = new decimal(new int[] {
            636,
            0,
            0,
            0});
            this.nUWidth.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUWidth.Name = "nUWidth";
            this.nUWidth.Size = new System.Drawing.Size(77, 20);
            this.nUWidth.TabIndex = 1;
            this.nUWidth.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(12, 27);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(38, 13);
            this.lWidth.TabIndex = 0;
            this.lWidth.Text = "Width:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 26);
            this.button2.TabIndex = 21;
            this.button2.Text = "Background color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEEOffline);
            this.groupBox2.Controls.Add(this.rbEEOEditor);
            this.groupBox2.Controls.Add(this.lblMade);
            this.groupBox2.Controls.Add(this.tbowner);
            this.groupBox2.Controls.Add(this.tbtitle);
            this.groupBox2.Controls.Add(this.lname);
            this.groupBox2.Controls.Add(this.ltitle);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 158);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // tbowner
            // 
            this.tbowner.Location = new System.Drawing.Point(15, 81);
            this.tbowner.Name = "tbowner";
            this.tbowner.Size = new System.Drawing.Size(139, 20);
            this.tbowner.TabIndex = 3;
            this.tbowner.Text = "Player";
            // 
            // tbtitle
            // 
            this.tbtitle.Location = new System.Drawing.Point(15, 41);
            this.tbtitle.Name = "tbtitle";
            this.tbtitle.Size = new System.Drawing.Size(190, 20);
            this.tbtitle.TabIndex = 2;
            this.tbtitle.Text = "Untitled World";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(12, 65);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(41, 13);
            this.lname.TabIndex = 1;
            this.lname.Text = "Owner:";
            // 
            // ltitle
            // 
            this.ltitle.AutoSize = true;
            this.ltitle.Location = new System.Drawing.Point(12, 25);
            this.ltitle.Name = "ltitle";
            this.ltitle.Size = new System.Drawing.Size(30, 13);
            this.ltitle.TabIndex = 0;
            this.ltitle.Text = "Title:";
            // 
            // lblMade
            // 
            this.lblMade.AutoSize = true;
            this.lblMade.Location = new System.Drawing.Point(13, 109);
            this.lblMade.Name = "lblMade";
            this.lblMade.Size = new System.Drawing.Size(62, 13);
            this.lblMade.TabIndex = 4;
            this.lblMade.Text = "Made With:";
            // 
            // rbEEOEditor
            // 
            this.rbEEOEditor.AutoSize = true;
            this.rbEEOEditor.Location = new System.Drawing.Point(93, 128);
            this.rbEEOEditor.Name = "rbEEOEditor";
            this.rbEEOEditor.Size = new System.Drawing.Size(67, 17);
            this.rbEEOEditor.TabIndex = 5;
            this.rbEEOEditor.Text = "EEOditor";
            this.rbEEOEditor.UseVisualStyleBackColor = true;
            // 
            // rbEEOffline
            // 
            this.rbEEOffline.AutoSize = true;
            this.rbEEOffline.Checked = true;
            this.rbEEOffline.Location = new System.Drawing.Point(15, 128);
            this.rbEEOffline.Name = "rbEEOffline";
            this.rbEEOffline.Size = new System.Drawing.Size(72, 17);
            this.rbEEOffline.TabIndex = 6;
            this.rbEEOffline.TabStop = true;
            this.rbEEOffline.Text = "EE Offline";
            this.rbEEOffline.UseVisualStyleBackColor = true;
            // 
            // NewDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New World";
            this.Load += new System.EventHandler(this.NewDialogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nUHeight;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.NumericUpDown nUWidth;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbowner;
        private System.Windows.Forms.TextBox tbtitle;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label ltitle;
        private System.Windows.Forms.Button btnSizeList;
        private System.Windows.Forms.Label lblMade;
        private System.Windows.Forms.RadioButton rbEEOffline;
        private System.Windows.Forms.RadioButton rbEEOEditor;
    }
}