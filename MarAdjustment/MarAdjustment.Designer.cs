namespace MarAdjustment
{
    partial class MarAdjustmentMainForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxTopMarginOG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxHeaderHeightOG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uxDetailHeightOG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uxPageFooterHeightOG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uxBottomMarginOG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.uxHeaderHeightSug = new System.Windows.Forms.TextBox();
            this.uxPageFooterHeightSug = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uxDesiredMovement = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.uxNumberLinesToMoveBy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.uxIssueNotes = new System.Windows.Forms.TextBox();
            this.rtbCommentTextSuggestions = new System.Windows.Forms.RichTextBox();
            this.uxTopMarginSug = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxBottomMarginSug = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desired Movement:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Top Margin:";
            // 
            // uxTopMarginOG
            // 
            this.uxTopMarginOG.Location = new System.Drawing.Point(116, 82);
            this.uxTopMarginOG.Name = "uxTopMarginOG";
            this.uxTopMarginOG.Size = new System.Drawing.Size(100, 20);
            this.uxTopMarginOG.TabIndex = 6;
            this.uxTopMarginOG.Leave += new System.EventHandler(this.Control_Validation);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Header Height:";
            // 
            // uxHeaderHeightOG
            // 
            this.uxHeaderHeightOG.Location = new System.Drawing.Point(116, 110);
            this.uxHeaderHeightOG.Name = "uxHeaderHeightOG";
            this.uxHeaderHeightOG.Size = new System.Drawing.Size(100, 20);
            this.uxHeaderHeightOG.TabIndex = 7;
            this.uxHeaderHeightOG.Leave += new System.EventHandler(this.Control_Validation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Detail Height:";
            // 
            // uxDetailHeightOG
            // 
            this.uxDetailHeightOG.Location = new System.Drawing.Point(116, 136);
            this.uxDetailHeightOG.Name = "uxDetailHeightOG";
            this.uxDetailHeightOG.Size = new System.Drawing.Size(100, 20);
            this.uxDetailHeightOG.TabIndex = 9;
            this.uxDetailHeightOG.Leave += new System.EventHandler(this.uxDetailHeightOG_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Footer Height:";
            // 
            // uxPageFooterHeightOG
            // 
            this.uxPageFooterHeightOG.Location = new System.Drawing.Point(116, 162);
            this.uxPageFooterHeightOG.Name = "uxPageFooterHeightOG";
            this.uxPageFooterHeightOG.Size = new System.Drawing.Size(100, 20);
            this.uxPageFooterHeightOG.TabIndex = 11;
            this.uxPageFooterHeightOG.Leave += new System.EventHandler(this.Control_Validation);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bottom Margin:";
            // 
            // uxBottomMarginOG
            // 
            this.uxBottomMarginOG.Location = new System.Drawing.Point(116, 188);
            this.uxBottomMarginOG.Name = "uxBottomMarginOG";
            this.uxBottomMarginOG.Size = new System.Drawing.Size(100, 20);
            this.uxBottomMarginOG.TabIndex = 13;
            this.uxBottomMarginOG.Leave += new System.EventHandler(this.Control_Validation);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Suggestions/Comments:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(144, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Original";
            // 
            // uxHeaderHeightSug
            // 
            this.uxHeaderHeightSug.CausesValidation = false;
            this.uxHeaderHeightSug.Location = new System.Drawing.Point(272, 110);
            this.uxHeaderHeightSug.Name = "uxHeaderHeightSug";
            this.uxHeaderHeightSug.Size = new System.Drawing.Size(100, 20);
            this.uxHeaderHeightSug.TabIndex = 8;
            this.uxHeaderHeightSug.TabStop = false;
            // 
            // uxPageFooterHeightSug
            // 
            this.uxPageFooterHeightSug.CausesValidation = false;
            this.uxPageFooterHeightSug.Location = new System.Drawing.Point(272, 162);
            this.uxPageFooterHeightSug.Name = "uxPageFooterHeightSug";
            this.uxPageFooterHeightSug.Size = new System.Drawing.Size(100, 20);
            this.uxPageFooterHeightSug.TabIndex = 12;
            this.uxPageFooterHeightSug.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(293, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Suggested";
            // 
            // uxDesiredMovement
            // 
            this.uxDesiredMovement.CausesValidation = false;
            this.uxDesiredMovement.FormattingEnabled = true;
            this.uxDesiredMovement.Location = new System.Drawing.Point(117, 6);
            this.uxDesiredMovement.Name = "uxDesiredMovement";
            this.uxDesiredMovement.Size = new System.Drawing.Size(121, 21);
            this.uxDesiredMovement.TabIndex = 4;
            this.uxDesiredMovement.Leave += new System.EventHandler(this.uxDesiredMovement_Leave);
            // 
            // btnCalculate
            // 
            this.btnCalculate.CausesValidation = false;
            this.btnCalculate.Location = new System.Drawing.Point(13, 237);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(432, 25);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate Using Section Heights";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "By:";
            // 
            // uxNumberLinesToMoveBy
            // 
            this.uxNumberLinesToMoveBy.Location = new System.Drawing.Point(272, 6);
            this.uxNumberLinesToMoveBy.Name = "uxNumberLinesToMoveBy";
            this.uxNumberLinesToMoveBy.Size = new System.Drawing.Size(100, 20);
            this.uxNumberLinesToMoveBy.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(378, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Lines";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(222, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "inches";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(222, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "inches";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(222, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "inches";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(222, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "inches";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(222, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "inches";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(378, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "inches";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(378, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "inches";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 426);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Issue Notes:";
            // 
            // uxIssueNotes
            // 
            this.uxIssueNotes.CausesValidation = false;
            this.uxIssueNotes.Location = new System.Drawing.Point(13, 443);
            this.uxIssueNotes.Multiline = true;
            this.uxIssueNotes.Name = "uxIssueNotes";
            this.uxIssueNotes.Size = new System.Drawing.Size(430, 66);
            this.uxIssueNotes.TabIndex = 22;
            // 
            // rtbCommentTextSuggestions
            // 
            this.rtbCommentTextSuggestions.BackColor = System.Drawing.SystemColors.Control;
            this.rtbCommentTextSuggestions.CausesValidation = false;
            this.rtbCommentTextSuggestions.Location = new System.Drawing.Point(13, 326);
            this.rtbCommentTextSuggestions.Name = "rtbCommentTextSuggestions";
            this.rtbCommentTextSuggestions.Size = new System.Drawing.Size(430, 97);
            this.rtbCommentTextSuggestions.TabIndex = 23;
            this.rtbCommentTextSuggestions.Text = "";
            this.rtbCommentTextSuggestions.Leave += new System.EventHandler(this.uxDetailHeightOG_Leave);
            // 
            // uxTopMarginSug
            // 
            this.uxTopMarginSug.CausesValidation = false;
            this.uxTopMarginSug.Location = new System.Drawing.Point(272, 82);
            this.uxTopMarginSug.Name = "uxTopMarginSug";
            this.uxTopMarginSug.Size = new System.Drawing.Size(100, 20);
            this.uxTopMarginSug.TabIndex = 8;
            this.uxTopMarginSug.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "inches";
            // 
            // uxBottomMarginSug
            // 
            this.uxBottomMarginSug.CausesValidation = false;
            this.uxBottomMarginSug.Location = new System.Drawing.Point(272, 188);
            this.uxBottomMarginSug.Name = "uxBottomMarginSug";
            this.uxBottomMarginSug.Size = new System.Drawing.Size(100, 20);
            this.uxBottomMarginSug.TabIndex = 8;
            this.uxBottomMarginSug.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "inches";
            // 
            // btnClear
            // 
            this.btnClear.CausesValidation = false;
            this.btnClear.Location = new System.Drawing.Point(13, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(432, 25);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearAll);
            // 
            // MarAdjustmentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 545);
            this.Controls.Add(this.rtbCommentTextSuggestions);
            this.Controls.Add(this.uxIssueNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.uxDesiredMovement);
            this.Controls.Add(this.uxBottomMarginOG);
            this.Controls.Add(this.uxPageFooterHeightSug);
            this.Controls.Add(this.uxPageFooterHeightOG);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxDetailHeightOG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uxBottomMarginSug);
            this.Controls.Add(this.uxTopMarginSug);
            this.Controls.Add(this.uxHeaderHeightSug);
            this.Controls.Add(this.uxHeaderHeightOG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uxTopMarginOG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxNumberLinesToMoveBy);
            this.Controls.Add(this.label15);
            this.Name = "MarAdjustmentMainForm";
            this.Text = "Mar Adjustment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxTopMarginOG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxHeaderHeightOG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxDetailHeightOG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uxPageFooterHeightOG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uxBottomMarginOG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox uxHeaderHeightSug;
        private System.Windows.Forms.TextBox uxPageFooterHeightSug;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox uxDesiredMovement;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uxNumberLinesToMoveBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox uxIssueNotes;
        private System.Windows.Forms.RichTextBox rtbCommentTextSuggestions;
        private System.Windows.Forms.TextBox uxTopMarginSug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxBottomMarginSug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
    }
}

