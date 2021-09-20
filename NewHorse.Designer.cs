
namespace HorsesBets
{
    partial class NewHorse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.VictoriesBox = new System.Windows.Forms.TextBox();
            this.CoachBox = new System.Windows.Forms.TextBox();
            this.JockeyBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Victories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coach";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jockey";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(189, 37);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(166, 22);
            this.NameBox.TabIndex = 5;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(189, 77);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(166, 22);
            this.YearBox.TabIndex = 6;
            // 
            // VictoriesBox
            // 
            this.VictoriesBox.Location = new System.Drawing.Point(189, 116);
            this.VictoriesBox.Name = "VictoriesBox";
            this.VictoriesBox.Size = new System.Drawing.Size(166, 22);
            this.VictoriesBox.TabIndex = 7;
            // 
            // CoachBox
            // 
            this.CoachBox.Location = new System.Drawing.Point(189, 157);
            this.CoachBox.Name = "CoachBox";
            this.CoachBox.Size = new System.Drawing.Size(166, 22);
            this.CoachBox.TabIndex = 8;
            // 
            // JockeyBox
            // 
            this.JockeyBox.Location = new System.Drawing.Point(189, 196);
            this.JockeyBox.Name = "JockeyBox";
            this.JockeyBox.Size = new System.Drawing.Size(166, 22);
            this.JockeyBox.TabIndex = 9;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(471, 172);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(142, 46);
            this.Add.TabIndex = 10;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(474, 94);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(138, 43);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // NewHorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 264);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.JockeyBox);
            this.Controls.Add(this.CoachBox);
            this.Controls.Add(this.VictoriesBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewHorse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new horse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox VictoriesBox;
        private System.Windows.Forms.TextBox CoachBox;
        private System.Windows.Forms.TextBox JockeyBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Back;
    }
}