
namespace SonicRemakeGP43D
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnInfiniteGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(167, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sonic MiniGame ";
            // 
            // btnLevel1
            // 
            this.btnLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLevel1.Location = new System.Drawing.Point(218, 116);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(132, 36);
            this.btnLevel1.TabIndex = 1;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = true;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnQuit.Location = new System.Drawing.Point(218, 242);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(132, 36);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.Enabled = false;
            this.btnLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLevel2.Location = new System.Drawing.Point(218, 158);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(132, 36);
            this.btnLevel2.TabIndex = 3;
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = true;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.Enabled = false;
            this.btnLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLevel3.Location = new System.Drawing.Point(218, 200);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(132, 36);
            this.btnLevel3.TabIndex = 4;
            this.btnLevel3.Text = "Level 3";
            this.btnLevel3.UseVisualStyleBackColor = true;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel3_Click);
            // 
            // btnInfiniteGame
            // 
            this.btnInfiniteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnInfiniteGame.Location = new System.Drawing.Point(218, 74);
            this.btnInfiniteGame.Name = "btnInfiniteGame";
            this.btnInfiniteGame.Size = new System.Drawing.Size(132, 36);
            this.btnInfiniteGame.TabIndex = 5;
            this.btnInfiniteGame.Text = "Infinite Game";
            this.btnInfiniteGame.UseVisualStyleBackColor = true;
            this.btnInfiniteGame.Click += new System.EventHandler(this.btnInfiniteGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "v1.0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SonicRemakeGP43D.Properties.Resources.mainBg;
            this.ClientSize = new System.Drawing.Size(602, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInfiniteGame);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonic MiniGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnInfiniteGame;
        private System.Windows.Forms.Label label2;
    }
}