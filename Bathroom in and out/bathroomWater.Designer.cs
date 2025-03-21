namespace Bathroom_in_and_out
{
    partial class bathroomWater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bathroomWater));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(488, 74);
            label1.TabIndex = 0;
            label1.Text = "Are you going to the bathroom or\r\n are you getting water?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(69, 155);
            button1.Name = "button1";
            button1.Size = new Size(180, 64);
            button1.TabIndex = 1;
            button1.Text = "Bathroom";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Azure;
            button2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(317, 155);
            button2.Name = "button2";
            button2.Size = new Size(172, 64);
            button2.TabIndex = 2;
            button2.Text = "Water";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // bathroomWater
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(559, 288);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "bathroomWater";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}