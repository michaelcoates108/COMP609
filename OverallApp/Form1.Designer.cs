
namespace OverallApp
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
            this.BrowseButton = new System.Windows.Forms.Button();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.outBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profButton = new System.Windows.Forms.Button();
            this.MonthlyTaxButton = new System.Windows.Forms.Button();
            this.TotalMilkButton = new System.Windows.Forms.Button();
            this.AverageAgeButton = new System.Windows.Forms.Button();
            this.GoatsCowsVsSheepButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DogRatioButton = new System.Windows.Forms.Button();
            this.RedRatioButton = new System.Windows.Forms.Button();
            this.JerseyTaxButton = new System.Windows.Forms.Button();
            this.JerseyCowProfButton = new System.Windows.Forms.Button();
            this.SearchAgeButton = new System.Windows.Forms.Button();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.animalInfoBox = new System.Windows.Forms.TextBox();
            this.searchByIDButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileLocationButton = new System.Windows.Forms.Button();
            this.FileChosenBox = new System.Windows.Forms.TextBox();
            this.GenerateFileButton = new System.Windows.Forms.Button();
            this.SearchClearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.Location = new System.Drawing.Point(16, 43);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(84, 19);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse Files";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // filenameBox
            // 
            this.filenameBox.Location = new System.Drawing.Point(17, 67);
            this.filenameBox.Margin = new System.Windows.Forms.Padding(2);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(231, 20);
            this.filenameBox.TabIndex = 1;
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(495, 146);
            this.outBox.Margin = new System.Windows.Forms.Padding(2);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.ReadOnly = true;
            this.outBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outBox.Size = new System.Drawing.Size(360, 439);
            this.outBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Database:";
            // 
            // profButton
            // 
            this.profButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profButton.Location = new System.Drawing.Point(324, 146);
            this.profButton.Margin = new System.Windows.Forms.Padding(2);
            this.profButton.Name = "profButton";
            this.profButton.Size = new System.Drawing.Size(167, 33);
            this.profButton.TabIndex = 4;
            this.profButton.Text = "Total Daily Profits";
            this.profButton.UseVisualStyleBackColor = true;
            this.profButton.Click += new System.EventHandler(this.profButton_Click);
            // 
            // MonthlyTaxButton
            // 
            this.MonthlyTaxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonthlyTaxButton.Location = new System.Drawing.Point(324, 184);
            this.MonthlyTaxButton.Margin = new System.Windows.Forms.Padding(2);
            this.MonthlyTaxButton.Name = "MonthlyTaxButton";
            this.MonthlyTaxButton.Size = new System.Drawing.Size(167, 33);
            this.MonthlyTaxButton.TabIndex = 5;
            this.MonthlyTaxButton.Text = "Monthly Tax Paid";
            this.MonthlyTaxButton.UseVisualStyleBackColor = true;
            this.MonthlyTaxButton.Click += new System.EventHandler(this.MonthlyTaxButton_Click);
            // 
            // TotalMilkButton
            // 
            this.TotalMilkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TotalMilkButton.Location = new System.Drawing.Point(324, 223);
            this.TotalMilkButton.Margin = new System.Windows.Forms.Padding(2);
            this.TotalMilkButton.Name = "TotalMilkButton";
            this.TotalMilkButton.Size = new System.Drawing.Size(167, 33);
            this.TotalMilkButton.TabIndex = 6;
            this.TotalMilkButton.Text = "Daily Milk Production:";
            this.TotalMilkButton.UseVisualStyleBackColor = true;
            this.TotalMilkButton.Click += new System.EventHandler(this.TotalMilkButton_Click);
            // 
            // AverageAgeButton
            // 
            this.AverageAgeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AverageAgeButton.Location = new System.Drawing.Point(324, 261);
            this.AverageAgeButton.Margin = new System.Windows.Forms.Padding(2);
            this.AverageAgeButton.Name = "AverageAgeButton";
            this.AverageAgeButton.Size = new System.Drawing.Size(167, 33);
            this.AverageAgeButton.TabIndex = 7;
            this.AverageAgeButton.Text = "Average Age (excl dogs)";
            this.AverageAgeButton.UseVisualStyleBackColor = true;
            this.AverageAgeButton.Click += new System.EventHandler(this.AverageAgeButton_Click);
            // 
            // GoatsCowsVsSheepButton
            // 
            this.GoatsCowsVsSheepButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoatsCowsVsSheepButton.Location = new System.Drawing.Point(324, 299);
            this.GoatsCowsVsSheepButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoatsCowsVsSheepButton.Name = "GoatsCowsVsSheepButton";
            this.GoatsCowsVsSheepButton.Size = new System.Drawing.Size(167, 33);
            this.GoatsCowsVsSheepButton.TabIndex = 8;
            this.GoatsCowsVsSheepButton.Text = "Profits: Goats + Cows vs Sheep";
            this.GoatsCowsVsSheepButton.UseVisualStyleBackColor = true;
            this.GoatsCowsVsSheepButton.Click += new System.EventHandler(this.GoatsCowsVsSheepButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Location = new System.Drawing.Point(495, 589);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(56, 19);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DogRatioButton
            // 
            this.DogRatioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DogRatioButton.Location = new System.Drawing.Point(324, 337);
            this.DogRatioButton.Margin = new System.Windows.Forms.Padding(2);
            this.DogRatioButton.Name = "DogRatioButton";
            this.DogRatioButton.Size = new System.Drawing.Size(167, 33);
            this.DogRatioButton.TabIndex = 10;
            this.DogRatioButton.Text = "Cost ratio: Dogs vs Total";
            this.DogRatioButton.UseVisualStyleBackColor = true;
            this.DogRatioButton.Click += new System.EventHandler(this.DogRatioButton_Click);
            // 
            // RedRatioButton
            // 
            this.RedRatioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedRatioButton.Location = new System.Drawing.Point(324, 375);
            this.RedRatioButton.Margin = new System.Windows.Forms.Padding(2);
            this.RedRatioButton.Name = "RedRatioButton";
            this.RedRatioButton.Size = new System.Drawing.Size(167, 33);
            this.RedRatioButton.TabIndex = 11;
            this.RedRatioButton.Text = "Colour ratio: Red vs All";
            this.RedRatioButton.UseVisualStyleBackColor = true;
            this.RedRatioButton.Click += new System.EventHandler(this.RedRatioButton_Click);
            // 
            // JerseyTaxButton
            // 
            this.JerseyTaxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JerseyTaxButton.Location = new System.Drawing.Point(324, 414);
            this.JerseyTaxButton.Margin = new System.Windows.Forms.Padding(2);
            this.JerseyTaxButton.Name = "JerseyTaxButton";
            this.JerseyTaxButton.Size = new System.Drawing.Size(167, 33);
            this.JerseyTaxButton.TabIndex = 12;
            this.JerseyTaxButton.Text = "Daily Tax for Jersey Cows";
            this.JerseyTaxButton.UseVisualStyleBackColor = true;
            this.JerseyTaxButton.Click += new System.EventHandler(this.JerseyTaxButton_Click);
            // 
            // JerseyCowProfButton
            // 
            this.JerseyCowProfButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JerseyCowProfButton.Location = new System.Drawing.Point(324, 452);
            this.JerseyCowProfButton.Margin = new System.Windows.Forms.Padding(2);
            this.JerseyCowProfButton.Name = "JerseyCowProfButton";
            this.JerseyCowProfButton.Size = new System.Drawing.Size(167, 33);
            this.JerseyCowProfButton.TabIndex = 13;
            this.JerseyCowProfButton.Text = "Profits for Jersey Cows";
            this.JerseyCowProfButton.UseVisualStyleBackColor = true;
            this.JerseyCowProfButton.Click += new System.EventHandler(this.JerseyCowProfButton_Click);
            // 
            // SearchAgeButton
            // 
            this.SearchAgeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchAgeButton.Location = new System.Drawing.Point(324, 490);
            this.SearchAgeButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchAgeButton.Name = "SearchAgeButton";
            this.SearchAgeButton.Size = new System.Drawing.Size(103, 33);
            this.SearchAgeButton.TabIndex = 14;
            this.SearchAgeButton.Text = "Search by Age";
            this.SearchAgeButton.UseVisualStyleBackColor = true;
            this.SearchAgeButton.Click += new System.EventHandler(this.SearchAgeButton_Click);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(468, 497);
            this.ageBox.Margin = new System.Windows.Forms.Padding(2);
            this.ageBox.Multiline = true;
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(24, 22);
            this.ageBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search animal by ID:";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(19, 189);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(76, 20);
            this.IDBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter ID here:";
            // 
            // animalInfoBox
            // 
            this.animalInfoBox.Location = new System.Drawing.Point(18, 213);
            this.animalInfoBox.Margin = new System.Windows.Forms.Padding(2);
            this.animalInfoBox.Multiline = true;
            this.animalInfoBox.Name = "animalInfoBox";
            this.animalInfoBox.ReadOnly = true;
            this.animalInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.animalInfoBox.Size = new System.Drawing.Size(232, 261);
            this.animalInfoBox.TabIndex = 20;
            // 
            // searchByIDButton
            // 
            this.searchByIDButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchByIDButton.Location = new System.Drawing.Point(99, 189);
            this.searchByIDButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchByIDButton.Name = "searchByIDButton";
            this.searchByIDButton.Size = new System.Drawing.Size(58, 20);
            this.searchByIDButton.TabIndex = 21;
            this.searchByIDButton.Text = "Search";
            this.searchByIDButton.UseVisualStyleBackColor = true;
            this.searchByIDButton.Click += new System.EventHandler(this.searchByIDButton_Click);
            // 
            // FileLocationButton
            // 
            this.FileLocationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileLocationButton.Location = new System.Drawing.Point(383, 44);
            this.FileLocationButton.Margin = new System.Windows.Forms.Padding(2);
            this.FileLocationButton.Name = "FileLocationButton";
            this.FileLocationButton.Size = new System.Drawing.Size(106, 19);
            this.FileLocationButton.TabIndex = 22;
            this.FileLocationButton.Text = "Choose Folder";
            this.FileLocationButton.UseVisualStyleBackColor = true;
            this.FileLocationButton.Click += new System.EventHandler(this.FileLocationButton_Click);
            // 
            // FileChosenBox
            // 
            this.FileChosenBox.Location = new System.Drawing.Point(495, 44);
            this.FileChosenBox.Margin = new System.Windows.Forms.Padding(2);
            this.FileChosenBox.Name = "FileChosenBox";
            this.FileChosenBox.ReadOnly = true;
            this.FileChosenBox.Size = new System.Drawing.Size(311, 20);
            this.FileChosenBox.TabIndex = 23;
            // 
            // GenerateFileButton
            // 
            this.GenerateFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateFileButton.Location = new System.Drawing.Point(383, 67);
            this.GenerateFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateFileButton.Name = "GenerateFileButton";
            this.GenerateFileButton.Size = new System.Drawing.Size(106, 19);
            this.GenerateFileButton.TabIndex = 24;
            this.GenerateFileButton.Text = "Create File";
            this.GenerateFileButton.UseVisualStyleBackColor = true;
            this.GenerateFileButton.Click += new System.EventHandler(this.GenerateFileButton_Click);
            // 
            // SearchClearButton
            // 
            this.SearchClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchClearButton.Location = new System.Drawing.Point(19, 478);
            this.SearchClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchClearButton.Name = "SearchClearButton";
            this.SearchClearButton.Size = new System.Drawing.Size(58, 20);
            this.SearchClearButton.TabIndex = 25;
            this.SearchClearButton.Text = "Clear";
            this.SearchClearButton.UseVisualStyleBackColor = true;
            this.SearchClearButton.Click += new System.EventHandler(this.SearchClearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Reports";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "  Cows:   10XX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = " Goats:   11XX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sheep:   3XXX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "  Dogs:   5XXX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Animal IDs Ranked by Profitability";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(881, 662);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchClearButton);
            this.Controls.Add(this.GenerateFileButton);
            this.Controls.Add(this.FileChosenBox);
            this.Controls.Add(this.FileLocationButton);
            this.Controls.Add(this.searchByIDButton);
            this.Controls.Add(this.animalInfoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.SearchAgeButton);
            this.Controls.Add(this.JerseyCowProfButton);
            this.Controls.Add(this.JerseyTaxButton);
            this.Controls.Add(this.RedRatioButton);
            this.Controls.Add(this.DogRatioButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GoatsCowsVsSheepButton);
            this.Controls.Add(this.AverageAgeButton);
            this.Controls.Add(this.TotalMilkButton);
            this.Controls.Add(this.MonthlyTaxButton);
            this.Controls.Add(this.profButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.BrowseButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Farm Information App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profButton;
        private System.Windows.Forms.Button MonthlyTaxButton;
        private System.Windows.Forms.Button TotalMilkButton;
        private System.Windows.Forms.Button AverageAgeButton;
        private System.Windows.Forms.Button GoatsCowsVsSheepButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DogRatioButton;
        private System.Windows.Forms.Button RedRatioButton;
        private System.Windows.Forms.Button JerseyTaxButton;
        private System.Windows.Forms.Button JerseyCowProfButton;
        private System.Windows.Forms.Button SearchAgeButton;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox animalInfoBox;
        private System.Windows.Forms.Button searchByIDButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button FileLocationButton;
        private System.Windows.Forms.TextBox FileChosenBox;
        private System.Windows.Forms.Button GenerateFileButton;
        private System.Windows.Forms.Button SearchClearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

