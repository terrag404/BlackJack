
namespace BlackJack
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
            this.mainBox = new System.Windows.Forms.TextBox();
            this.mainWorker = new System.ComponentModel.BackgroundWorker();
            this.closeWorker = new System.ComponentModel.BackgroundWorker();
            this.startBttn = new System.Windows.Forms.Button();
            this.statBttn = new System.Windows.Forms.Button();
            this.PlayerBox = new System.Windows.Forms.TextBox();
            this.DealerBox = new System.Windows.Forms.TextBox();
            this.hitBttn = new System.Windows.Forms.Button();
            this.standBttn = new System.Windows.Forms.Button();
            this.statsBox = new System.Windows.Forms.TextBox();
            this.playerLbl = new System.Windows.Forms.Label();
            this.dealerLbl = new System.Windows.Forms.Label();
            this.statsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Location = new System.Drawing.Point(12, 12);
            this.mainBox.Multiline = true;
            this.mainBox.Name = "mainBox";
            this.mainBox.ReadOnly = true;
            this.mainBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainBox.Size = new System.Drawing.Size(767, 131);
            this.mainBox.TabIndex = 0;
            // 
            // mainWorker
            // 
            this.mainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mainWorker_DoWork);
            // 
            // closeWorker
            // 
            this.closeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.closeWorker_DoWork);
            // 
            // startBttn
            // 
            this.startBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBttn.Location = new System.Drawing.Point(332, 246);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(134, 59);
            this.startBttn.TabIndex = 1;
            this.startBttn.Text = "Start Game";
            this.startBttn.UseVisualStyleBackColor = true;
            this.startBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // statBttn
            // 
            this.statBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statBttn.Location = new System.Drawing.Point(332, 311);
            this.statBttn.Name = "statBttn";
            this.statBttn.Size = new System.Drawing.Size(134, 54);
            this.statBttn.TabIndex = 2;
            this.statBttn.Text = "Statistics";
            this.statBttn.UseVisualStyleBackColor = true;
            this.statBttn.Click += new System.EventHandler(this.statBttn_Click);
            // 
            // PlayerBox
            // 
            this.PlayerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerBox.Location = new System.Drawing.Point(12, 188);
            this.PlayerBox.Multiline = true;
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.ReadOnly = true;
            this.PlayerBox.Size = new System.Drawing.Size(203, 79);
            this.PlayerBox.TabIndex = 3;
            this.PlayerBox.Visible = false;
            // 
            // DealerBox
            // 
            this.DealerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerBox.Location = new System.Drawing.Point(575, 188);
            this.DealerBox.Multiline = true;
            this.DealerBox.Name = "DealerBox";
            this.DealerBox.ReadOnly = true;
            this.DealerBox.Size = new System.Drawing.Size(204, 79);
            this.DealerBox.TabIndex = 4;
            this.DealerBox.Visible = false;
            // 
            // hitBttn
            // 
            this.hitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitBttn.Location = new System.Drawing.Point(332, 181);
            this.hitBttn.Name = "hitBttn";
            this.hitBttn.Size = new System.Drawing.Size(134, 59);
            this.hitBttn.TabIndex = 5;
            this.hitBttn.Text = "Hit";
            this.hitBttn.UseVisualStyleBackColor = true;
            this.hitBttn.Visible = false;
            this.hitBttn.Click += new System.EventHandler(this.hitBttn_Click);
            // 
            // standBttn
            // 
            this.standBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standBttn.Location = new System.Drawing.Point(332, 371);
            this.standBttn.Name = "standBttn";
            this.standBttn.Size = new System.Drawing.Size(134, 59);
            this.standBttn.TabIndex = 6;
            this.standBttn.Text = "Stand";
            this.standBttn.UseVisualStyleBackColor = true;
            this.standBttn.Visible = false;
            this.standBttn.Click += new System.EventHandler(this.standBttn_Click);
            // 
            // statsBox
            // 
            this.statsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsBox.Location = new System.Drawing.Point(575, 328);
            this.statsBox.Multiline = true;
            this.statsBox.Name = "statsBox";
            this.statsBox.ReadOnly = true;
            this.statsBox.Size = new System.Drawing.Size(204, 79);
            this.statsBox.TabIndex = 7;
            this.statsBox.Visible = false;
            // 
            // playerLbl
            // 
            this.playerLbl.AutoSize = true;
            this.playerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLbl.Location = new System.Drawing.Point(12, 165);
            this.playerLbl.Name = "playerLbl";
            this.playerLbl.Size = new System.Drawing.Size(129, 20);
            this.playerLbl.TabIndex = 9;
            this.playerLbl.Text = "Player\'s Hand: ";
            this.playerLbl.Visible = false;
            // 
            // dealerLbl
            // 
            this.dealerLbl.AutoSize = true;
            this.dealerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerLbl.Location = new System.Drawing.Point(571, 165);
            this.dealerLbl.Name = "dealerLbl";
            this.dealerLbl.Size = new System.Drawing.Size(133, 20);
            this.dealerLbl.TabIndex = 10;
            this.dealerLbl.Text = "Dealer\'s Hand: ";
            this.dealerLbl.Visible = false;
            // 
            // statsLbl
            // 
            this.statsLbl.AutoSize = true;
            this.statsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLbl.Location = new System.Drawing.Point(571, 305);
            this.statsLbl.Name = "statsLbl";
            this.statsLbl.Size = new System.Drawing.Size(57, 20);
            this.statsLbl.TabIndex = 11;
            this.statsLbl.Text = "Stats:";
            this.statsLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statsLbl);
            this.Controls.Add(this.dealerLbl);
            this.Controls.Add(this.playerLbl);
            this.Controls.Add(this.statsBox);
            this.Controls.Add(this.standBttn);
            this.Controls.Add(this.hitBttn);
            this.Controls.Add(this.DealerBox);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.statBttn);
            this.Controls.Add(this.startBttn);
            this.Controls.Add(this.mainBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainBox;
        private System.ComponentModel.BackgroundWorker mainWorker;
        private System.ComponentModel.BackgroundWorker closeWorker;
        private System.Windows.Forms.Button startBttn;
        private System.Windows.Forms.Button statBttn;
        private System.Windows.Forms.TextBox PlayerBox;
        private System.Windows.Forms.TextBox DealerBox;
        private System.Windows.Forms.Button hitBttn;
        private System.Windows.Forms.Button standBttn;
        private System.Windows.Forms.TextBox statsBox;
        private System.Windows.Forms.Label playerLbl;
        private System.Windows.Forms.Label dealerLbl;
        private System.Windows.Forms.Label statsLbl;
    }
}

