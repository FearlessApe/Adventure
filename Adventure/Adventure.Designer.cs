namespace Adventure
{
    partial class Adventure
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblHitPoints = new Label();
            lblGold = new Label();
            lblExperience = new Label();
            lblLevel = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 1;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "Experience:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 140);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 3;
            label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            lblHitPoints.AutoSize = true;
            lblHitPoints.Location = new Point(141, 35);
            lblHitPoints.Margin = new Padding(4, 0, 4, 0);
            lblHitPoints.Name = "lblHitPoints";
            lblHitPoints.Size = new Size(0, 21);
            lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(141, 70);
            lblGold.Margin = new Padding(4, 0, 4, 0);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 21);
            lblGold.TabIndex = 5;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(141, 105);
            lblExperience.Margin = new Padding(4, 0, 4, 0);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(0, 21);
            lblExperience.TabIndex = 6;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(141, 140);
            lblLevel.Margin = new Padding(4, 0, 4, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 21);
            lblLevel.TabIndex = 7;
            lblLevel.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 182);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 8;
            label5.Text = "Mana:";
            label5.Click += label5_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 9;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 168);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 10;
            label7.Text = "label7";
            label7.Click += label7_Click;
            // 
            // Adventure
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 681);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblLevel);
            Controls.Add(lblExperience);
            Controls.Add(lblGold);
            Controls.Add(lblHitPoints);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Adventure";
            Text = "Adventure";
            Load += Adventure_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblHitPoints;
        private Label lblGold;
        private Label lblExperience;
        private Label lblLevel;
        private Label lblMana;
        private Label label6;
        private Label label7;
    }
}
