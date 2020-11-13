namespace ObjectOrientedProgramming___Recipes
{
    partial class homePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.label1 = new System.Windows.Forms.Label();
            this.selectRecipeComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.5F);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(402, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a recipe!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectRecipeComboBox
            // 
            this.selectRecipeComboBox.FormattingEnabled = true;
            this.selectRecipeComboBox.Items.AddRange(new object[] {
            "Chicken Fajitas",
            "Creamy Cajun Chicken and Rice",
            "Home Made Steak And Chips",
            "Chicken and Mushroom Risotto"});
            this.selectRecipeComboBox.Location = new System.Drawing.Point(529, 333);
            this.selectRecipeComboBox.Name = "selectRecipeComboBox";
            this.selectRecipeComboBox.Size = new System.Drawing.Size(189, 21);
            this.selectRecipeComboBox.TabIndex = 1;
            this.selectRecipeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Let\'s get started!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patrick Hawkins - Object Oriented Programming";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.5F);
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(394, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Have your own recipe?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add recipe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectRecipeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "homePage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectRecipeComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

