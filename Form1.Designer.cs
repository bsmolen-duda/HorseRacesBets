
namespace HorsesBets
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
            this.Exit = new System.Windows.Forms.Button();
            this.Add_horse = new System.Windows.Forms.Button();
            this.NewCustomer = new System.Windows.Forms.Button();
            this.RandomRace = new System.Windows.Forms.Button();
            this.AddBet = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.RaceIDBox = new System.Windows.Forms.TextBox();
            this.FinishRace = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Exit.Location = new System.Drawing.Point(482, 347);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(136, 42);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Close_Click);
            // 
            // Add_horse
            // 
            this.Add_horse.Location = new System.Drawing.Point(44, 41);
            this.Add_horse.Name = "Add_horse";
            this.Add_horse.Size = new System.Drawing.Size(116, 55);
            this.Add_horse.TabIndex = 1;
            this.Add_horse.Text = "Add new horse";
            this.Add_horse.UseVisualStyleBackColor = true;
            this.Add_horse.Click += new System.EventHandler(this.Add_horse_Click);
            // 
            // NewCustomer
            // 
            this.NewCustomer.Location = new System.Drawing.Point(45, 129);
            this.NewCustomer.Name = "NewCustomer";
            this.NewCustomer.Size = new System.Drawing.Size(114, 49);
            this.NewCustomer.TabIndex = 2;
            this.NewCustomer.Text = "Add new Customer";
            this.NewCustomer.UseVisualStyleBackColor = true;
            this.NewCustomer.Click += new System.EventHandler(this.NewCustomer_Click);
            // 
            // RandomRace
            // 
            this.RandomRace.Location = new System.Drawing.Point(508, 45);
            this.RandomRace.Name = "RandomRace";
            this.RandomRace.Size = new System.Drawing.Size(110, 47);
            this.RandomRace.TabIndex = 3;
            this.RandomRace.Text = "Random Race";
            this.RandomRace.UseVisualStyleBackColor = true;
            this.RandomRace.Click += new System.EventHandler(this.RandomRace_Click);
            // 
            // AddBet
            // 
            this.AddBet.Location = new System.Drawing.Point(235, 45);
            this.AddBet.Name = "AddBet";
            this.AddBet.Size = new System.Drawing.Size(179, 51);
            this.AddBet.TabIndex = 4;
            this.AddBet.Text = "Add new bet";
            this.AddBet.UseVisualStyleBackColor = true;
            this.AddBet.Click += new System.EventHandler(this.AddBet_Click);
            // 
            // Check
            // 
            this.Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Check.Location = new System.Drawing.Point(173, 71);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(179, 49);
            this.Check.TabIndex = 5;
            this.Check.Text = "Check Bets";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.Controls.Add(this.FinishRace, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RaceIDBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Check, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 262);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 127);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Race ID";
            // 
            // RaceIDBox
            // 
            this.RaceIDBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RaceIDBox.Location = new System.Drawing.Point(200, 21);
            this.RaceIDBox.Name = "RaceIDBox";
            this.RaceIDBox.Size = new System.Drawing.Size(125, 22);
            this.RaceIDBox.TabIndex = 7;
            // 
            // FinishRace
            // 
            this.FinishRace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinishRace.Location = new System.Drawing.Point(23, 71);
            this.FinishRace.Name = "FinishRace";
            this.FinishRace.Size = new System.Drawing.Size(110, 49);
            this.FinishRace.TabIndex = 7;
            this.FinishRace.Text = "Finish Race";
            this.FinishRace.UseVisualStyleBackColor = true;
            this.FinishRace.Click += new System.EventHandler(this.FinishRace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 429);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AddBet);
            this.Controls.Add(this.RandomRace);
            this.Controls.Add(this.NewCustomer);
            this.Controls.Add(this.Add_horse);
            this.Controls.Add(this.Exit);
            this.Name = "Form1";
            this.Text = "HorsesBets";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Add_horse;
        private System.Windows.Forms.Button NewCustomer;
        private System.Windows.Forms.Button RandomRace;
        private System.Windows.Forms.Button AddBet;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RaceIDBox;
        private System.Windows.Forms.Button FinishRace;
    }
}

