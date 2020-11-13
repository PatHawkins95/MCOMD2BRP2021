namespace ObjectOrientedProgramming___Recipes
{
    partial class recipePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recipePage));
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientTB = new System.Windows.Forms.TextBox();
            this.recipeTB = new System.Windows.Forms.TextBox();
            this.recipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ingredientTB
            // 
            this.ingredientTB.Location = new System.Drawing.Point(884, 260);
            this.ingredientTB.Multiline = true;
            this.ingredientTB.Name = "ingredientTB";
            this.ingredientTB.Size = new System.Drawing.Size(271, 385);
            this.ingredientTB.TabIndex = 1;
            this.ingredientTB.Text = "Insert Ingredients Here";
            this.ingredientTB.TextChanged += new System.EventHandler(this.ingredientTB_TextChanged);
            // 
            // recipeTB
            // 
            this.recipeTB.Location = new System.Drawing.Point(82, 260);
            this.recipeTB.Multiline = true;
            this.recipeTB.Name = "recipeTB";
            this.recipeTB.Size = new System.Drawing.Size(464, 385);
            this.recipeTB.TabIndex = 1;
            this.recipeTB.Text = "Insert Recipe Here";
            // 
            // recipeButton
            // 
            this.recipeButton.Location = new System.Drawing.Point(679, 372);
            this.recipeButton.Name = "recipeButton";
            this.recipeButton.Size = new System.Drawing.Size(75, 23);
            this.recipeButton.TabIndex = 2;
            this.recipeButton.Text = "Load recipe";
            this.recipeButton.UseVisualStyleBackColor = true;
            this.recipeButton.Click += new System.EventHandler(this.recipeButton_Click);
            // 
            // recipePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.recipeButton);
            this.Controls.Add(this.recipeTB);
            this.Controls.Add(this.ingredientTB);
            this.Controls.Add(this.label1);
            this.Name = "recipePage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingredientTB;
        private System.Windows.Forms.TextBox recipeTB;
        private System.Windows.Forms.Button recipeButton;
    }
}