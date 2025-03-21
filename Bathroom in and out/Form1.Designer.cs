namespace Bathroom_in_and_out
{
    partial class MainFromm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFromm));
            timer1 = new System.Windows.Forms.Timer(components);
            NamesListBox = new ListBox();
            Amnamelist = new Button();
            pmnamelist = new Button();
            SignoutButton = new Button();
            persons2signin = new Button();
            persons1signin = new Button();
            button1 = new Button();
            Timelabel = new Label();
            label3 = new Label();
            label1 = new Label();
            persons2 = new Label();
            persons1 = new Label();
            timelabel1 = new Label();
            timelabel2 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // NamesListBox
            // 
            NamesListBox.Anchor = AnchorStyles.None;
            NamesListBox.BackColor = Color.Azure;
            NamesListBox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            NamesListBox.FormattingEnabled = true;
            NamesListBox.ItemHeight = 24;
            NamesListBox.Location = new Point(179, 221);
            NamesListBox.Name = "NamesListBox";
            NamesListBox.Size = new Size(330, 724);
            NamesListBox.TabIndex = 0;
            // 
            // Amnamelist
            // 
            Amnamelist.Anchor = AnchorStyles.None;
            Amnamelist.BackColor = Color.Azure;
            Amnamelist.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            Amnamelist.Location = new Point(388, 174);
            Amnamelist.Name = "Amnamelist";
            Amnamelist.Size = new Size(89, 41);
            Amnamelist.TabIndex = 1;
            Amnamelist.Text = "AM";
            Amnamelist.UseVisualStyleBackColor = false;
            Amnamelist.Click += Amnamelist_Click;
            // 
            // pmnamelist
            // 
            pmnamelist.Anchor = AnchorStyles.None;
            pmnamelist.BackColor = Color.Azure;
            pmnamelist.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            pmnamelist.Location = new Point(201, 174);
            pmnamelist.Name = "pmnamelist";
            pmnamelist.Size = new Size(89, 41);
            pmnamelist.TabIndex = 2;
            pmnamelist.Text = "PM";
            pmnamelist.UseVisualStyleBackColor = false;
            pmnamelist.Click += pmnamelist_Click;
            // 
            // SignoutButton
            // 
            SignoutButton.Anchor = AnchorStyles.None;
            SignoutButton.BackColor = Color.Azure;
            SignoutButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            SignoutButton.Location = new Point(243, 951);
            SignoutButton.Name = "SignoutButton";
            SignoutButton.Size = new Size(188, 51);
            SignoutButton.TabIndex = 3;
            SignoutButton.Text = "Sign-Out";
            SignoutButton.UseVisualStyleBackColor = false;
            SignoutButton.Click += SignoutButton_Click;
            // 
            // persons2signin
            // 
            persons2signin.Anchor = AnchorStyles.None;
            persons2signin.BackColor = Color.Azure;
            persons2signin.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            persons2signin.ForeColor = Color.Black;
            persons2signin.Location = new Point(1112, 363);
            persons2signin.Name = "persons2signin";
            persons2signin.Size = new Size(162, 50);
            persons2signin.TabIndex = 8;
            persons2signin.Text = "Sign-in";
            persons2signin.UseVisualStyleBackColor = false;
            persons2signin.Click += persons2signin_Click;
            // 
            // persons1signin
            // 
            persons1signin.Anchor = AnchorStyles.None;
            persons1signin.BackColor = Color.Azure;
            persons1signin.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            persons1signin.Location = new Point(1112, 297);
            persons1signin.Name = "persons1signin";
            persons1signin.Size = new Size(162, 50);
            persons1signin.TabIndex = 9;
            persons1signin.Text = "Sign-in";
            persons1signin.UseVisualStyleBackColor = false;
            persons1signin.Click += persons1signin_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Azure;
            button1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(1329, 951);
            button1.Name = "button1";
            button1.Size = new Size(150, 82);
            button1.TabIndex = 11;
            button1.Text = "Log";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Timelabel
            // 
            Timelabel.Anchor = AnchorStyles.None;
            Timelabel.AutoEllipsis = true;
            Timelabel.BackColor = Color.Azure;
            Timelabel.BorderStyle = BorderStyle.FixedSingle;
            Timelabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            Timelabel.Location = new Point(234, 112);
            Timelabel.Name = "Timelabel";
            Timelabel.Size = new Size(211, 50);
            Timelabel.TabIndex = 12;
            Timelabel.TextAlign = ContentAlignment.MiddleCenter;
            Timelabel.Click += Timelabel_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Azure;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(849, 245);
            label3.Name = "label3";
            label3.Size = new Size(125, 31);
            label3.TabIndex = 14;
            label3.Text = "Time Out";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(583, 245);
            label1.Name = "label1";
            label1.Size = new Size(149, 31);
            label1.TabIndex = 4;
            label1.Text = "People Out";
            // 
            // persons2
            // 
            persons2.Anchor = AnchorStyles.None;
            persons2.BorderStyle = BorderStyle.FixedSingle;
            persons2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            persons2.Location = new Point(583, 363);
            persons2.Name = "persons2";
            persons2.Size = new Size(235, 50);
            persons2.TabIndex = 6;
            persons2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // persons1
            // 
            persons1.Anchor = AnchorStyles.None;
            persons1.BorderStyle = BorderStyle.FixedSingle;
            persons1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            persons1.Location = new Point(583, 297);
            persons1.Name = "persons1";
            persons1.Size = new Size(235, 50);
            persons1.TabIndex = 5;
            persons1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timelabel1
            // 
            timelabel1.Anchor = AnchorStyles.None;
            timelabel1.BorderStyle = BorderStyle.FixedSingle;
            timelabel1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            timelabel1.Location = new Point(849, 297);
            timelabel1.Name = "timelabel1";
            timelabel1.Size = new Size(235, 50);
            timelabel1.TabIndex = 7;
            timelabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timelabel2
            // 
            timelabel2.Anchor = AnchorStyles.None;
            timelabel2.BorderStyle = BorderStyle.FixedSingle;
            timelabel2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            timelabel2.Location = new Point(849, 363);
            timelabel2.Name = "timelabel2";
            timelabel2.Size = new Size(235, 50);
            timelabel2.TabIndex = 8;
            timelabel2.TextAlign = ContentAlignment.MiddleCenter;
            timelabel2.Click += timelabel2_Click;
            // 
            // MainFromm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Azure;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1491, 1061);
            Controls.Add(label1);
            Controls.Add(timelabel2);
            Controls.Add(timelabel1);
            Controls.Add(label3);
            Controls.Add(persons1);
            Controls.Add(persons2);
            Controls.Add(Timelabel);
            Controls.Add(button1);
            Controls.Add(persons1signin);
            Controls.Add(persons2signin);
            Controls.Add(SignoutButton);
            Controls.Add(pmnamelist);
            Controls.Add(Amnamelist);
            Controls.Add(NamesListBox);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainFromm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = " Sign In And Sign Out";
            Load += MainFromm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ListBox NamesListBox;
        private Button Amnamelist;
        private Button pmnamelist;
        private Button persons2signin;
        private Button persons1signin;
        private Button button1;
        private Label Timelabel;
        public Button SignoutButton;
        private Label label3;
        private Label label1;
        private Label persons2;
        private Label persons1;
        private Label timelabel1;
        private Label timelabel2;
    }
}