﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MarAdjustment
{
    public partial class MarAdjustmentMainForm : Form
    {
        #region Constructor
        public MarAdjustmentMainForm()
        {
            InitializeComponent();
            LoadLookupLists();
            suggestedComments = new StringBuilder();
            SetDefaultValues();

        }
        #endregion

        #region Constants

        const string MOVEMENT_UP_COMMENT = "You can not resolve this by adjusting the adjustments on the printer group and will have to \r\nadjust the layout height.";
        const string MOVEMENT_DOWN_COMMENT = "Have you tried adding a vertical adjustment on the printer group? \r\nNote: This will shift all contents (header, footer, details) down";

        #endregion

        #region Enums
        public enum MovementType
        {
            Down = 1,
            Up = 2      
        }
        #endregion

        #region Properties and Fields

        public decimal pageHeight { get; set; }

        public int rowsPerDetail { get; set; }
        public int detailsPerPage { get; set; }

        public MovementType desiredMovement { get; set; }

        public decimal topMarginOG { get; set; }
        public decimal headerHeightOG { get; set; }
        public decimal detailHeightOG { get; set; }
        public decimal footerHeightOG { get; set; }
        public decimal bottomMarginHeightOG { get; set; }
        public decimal numberLinesToMoveBy { get; set; }
        public decimal headerHeightSug { get; set; }
        public decimal footerHeightSug { get; set; }
        public decimal topMarginSug { get; set; }
        public decimal bottomMarginSug { get; set; }

        private StringBuilder suggestedComments { get; set; }
        private bool sectionHtExceeded { get; set; }
        private bool isFirstClick = true;
        private bool isValid = true;
        private bool isClearPressed = false;

        #endregion

        #region Methods

        #region LookUpLists
        private void LoadLookupLists()
        {
            LoadDesiredMovementList();
        }

        private void LoadDesiredMovementList()
        {
            Dictionary<MovementType, string> list = new Dictionary<MovementType, string>();
            list.Add(MovementType.Down, "Down");
            list.Add(MovementType.Up, "Up");

            uxDesiredMovement.DisplayMember = "Value";
            uxDesiredMovement.ValueMember = "Key";
            uxDesiredMovement.DataSource = list.ToList();
        }
        #endregion

        private void SetValues()
        {
             desiredMovement = (MovementType)uxDesiredMovement.SelectedValue;

             topMarginOG = uxTopMarginOG.Text.Trim() != string.Empty? decimal.Parse(uxTopMarginOG.Text.Trim()):0;
             headerHeightOG = uxHeaderHeightOG.Text.Trim() != string.Empty? decimal.Parse(uxHeaderHeightOG.Text.Trim()):0;
             detailHeightOG = uxDetailHeightOG.Text.Trim() != string.Empty? decimal.Parse(uxDetailHeightOG.Text.Trim()):0;
             footerHeightOG = uxPageFooterHeightOG.Text.Trim() != string.Empty ? decimal.Parse(uxPageFooterHeightOG.Text.Trim()) : 0;
             bottomMarginHeightOG = uxBottomMarginOG.Text.Trim() != string.Empty ? decimal.Parse(uxBottomMarginOG.Text.Trim()) : 0;
             numberLinesToMoveBy = uxNumberLinesToMoveBy.Text.Trim() != string.Empty ? decimal.Parse(uxNumberLinesToMoveBy.Text.Trim()) : 0;              
        }

        private void SetDefaultValues()
        {
            rtbCommentTextSuggestions.Text = MOVEMENT_DOWN_COMMENT;
            uxDesiredMovement.SelectedValue = MovementType.Down;
            uxNumberLinesToMoveBy.Text = "1";
            uxDetailHeightOG.Text = ".167";
        }

        private string calculateHeaderHeight(decimal headerHeight, decimal detailHeight, MovementType Movement, decimal numberLinesToMoveBy)
        {
            decimal calculatedHeight;
            decimal inchesToMove = (detailHeight * numberLinesToMoveBy);

            if (Movement == MovementType.Up)
            {
                calculatedHeight = headerHeight - inchesToMove;
                if (calculatedHeight <= 0)
                {
                    sectionHtExceeded = true;
                    calculatedHeight = 0;
                }
            }
            else
            {
                calculatedHeight = headerHeight + inchesToMove;
            }        
            
            return calculatedHeight.ToString("0.000");
        }
        private string calculateFooterHeight(decimal footerHeight, decimal detailHeight, MovementType Movement, decimal numberLinesToMoveBy)
        {
            decimal calculatedHeight;
            decimal inchesToMove = (detailHeight * numberLinesToMoveBy);

            if (Movement == MovementType.Up)
            {
                calculatedHeight = footerHeight + inchesToMove;
                clearCommentBox();
                if (!sectionHtExceeded)
                {
                    suggestedComments.AppendLine("Select all contents of the footer except the red Reminder Textbox (if there is one)");
                    suggestedComments.AppendLine("and move everything DOWN by: " + inchesToMove.ToString("0.00") + " inches");
                    suggestedComments.AppendLine("Note that 1 hit of the up or down arrow key is .01 inches each time pressed");
                    setCommentBox(suggestedComments);
                    setIssueNotes(Movement, inchesToMove, calculatedHeight);
                }
                else
                {
                    suggestedComments.AppendLine("Your Header height has been exceeded!");
                    suggestedComments.AppendLine("You may want to consider tweaking your top margin instead");  
                    setCommentBox(suggestedComments);
                    rtbCommentTextSuggestions.SelectAll();
                    rtbCommentTextSuggestions.SelectionColor = Color.Red; 
                    sectionHtExceeded = false;
                }
            }
            else
            {
                calculatedHeight = footerHeight - inchesToMove;
                if (calculatedHeight <= 0)
                {
                    sectionHtExceeded = true;
                    calculatedHeight = 0;
                }

                clearCommentBox();

                if (!sectionHtExceeded)
                {
                    suggestedComments.AppendLine("Select all contents of the footer except the red Reminder Textbox (if there is one)");
                    suggestedComments.AppendLine("and move everything UP by: " + inchesToMove.ToString("0.00") + " inches");
                    suggestedComments.AppendLine("Note that 1 hit of the up or down arrow key is .01 inches each time pressed");
                    setCommentBox(suggestedComments);
                    setIssueNotes(Movement, inchesToMove, calculatedHeight);
                }
                else
                {
                    suggestedComments.AppendLine("Your Footer height has been exceeded!");
                    suggestedComments.AppendLine("You may want to consider tweaking your bottom margin instead");
                    setCommentBox(suggestedComments);
                    rtbCommentTextSuggestions.SelectAll();
                    rtbCommentTextSuggestions.SelectionColor = Color.Red;   
                    sectionHtExceeded = false;
                }
            }

            return calculatedHeight.ToString("0.000");
        }

        private void setCommentBox(StringBuilder comment)
        {
            rtbCommentTextSuggestions.Text = comment.ToString();
        }
        private void clearCommentBox()
        {
            suggestedComments.Clear();
            setCommentBox(suggestedComments);
            uxIssueNotes.Text = string.Empty;
        }

        private void setIssueNotes(MovementType Movement, decimal inchesToMove, decimal newFooterHeight)
        {
            MovementType MovementOfShift = Movement == MovementType.Up ? MovementType.Down : MovementType.Up;

            uxIssueNotes.Text = "Shifted details on the MAR " + Movement.ToString() + " by " + inchesToMove.ToString()
                + " inches by changing the header from " + uxHeaderHeightOG.Text.Trim() + " to " + uxHeaderHeightSug.Text.Trim()
                + " and the footer from " + uxPageFooterHeightOG.Text.Trim() + " to " + newFooterHeight.ToString("0.000")
                + ", moving all contents in the footer " + MovementOfShift.ToString() + " by " + inchesToMove.ToString("0.00")
                + " inches to compensate";
                
        }

        private void ClearAllControls()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
            }
            SetDefaultValues();
        }


        #endregion

        #region events

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (isFirstClick)
            {
                SetValues();
                uxHeaderHeightSug.Text = calculateHeaderHeight(headerHeightOG, detailHeightOG, desiredMovement, numberLinesToMoveBy);
                uxPageFooterHeightSug.Text = calculateFooterHeight(footerHeightOG, detailHeightOG, desiredMovement, numberLinesToMoveBy);
                btnCalculate.Text = "Calculate Using Margins";

                isFirstClick = false;
            }
            else
            {
                SetValues();
                isFirstClick = true;
                btnCalculate.Text = "Calculate Using Section Heights";
            }

        }

        private void uxDesiredMovement_Leave(object sender, EventArgs e)
        {
            if ((MovementType)uxDesiredMovement.SelectedValue == MovementType.Up)
            {
                clearCommentBox();
                suggestedComments.AppendLine(MOVEMENT_UP_COMMENT);
                setCommentBox(suggestedComments);

            }
            else if ((MovementType)uxDesiredMovement.SelectedValue == MovementType.Down)
            {
                clearCommentBox();
                suggestedComments.AppendLine(MOVEMENT_DOWN_COMMENT);
                setCommentBox(suggestedComments);
            }
        }
        private void uxDetailHeightOG_Leave(object sender, EventArgs e)
        {
            SetValues();
            if (detailHeightOG < .166M || detailHeightOG > .169M)
            {
                clearCommentBox();
                suggestedComments.AppendLine("Typical values for detail height are between .166 and .169");
                suggestedComments.AppendLine("Have you compared the original MAR form's detail height to your current copy?");
                setCommentBox(suggestedComments);
                //bug not highlighting correct text
                Debug.WriteLine(rtbCommentTextSuggestions.Text.IndexOf(".166") + " To " + rtbCommentTextSuggestions.Text.IndexOf("and"));
                rtbCommentTextSuggestions.Select(rtbCommentTextSuggestions.Text.IndexOf(".166"), rtbCommentTextSuggestions.Text.IndexOf(".169") + 3);
                rtbCommentTextSuggestions.SelectionColor = Color.Red;
            }
            else
            {
                clearCommentBox();
            }

        }

        private void Control_Validation(object sender, EventArgs e)
        {
            TextBox ControlToValidate = sender as TextBox;
            if (ControlToValidate.Text.Length > 0)
            {
                float result;
                isValid = float.TryParse(ControlToValidate.Text, out result);
                clearCommentBox();
                if (!isValid)
                {
                    suggestedComments.AppendLine("Please enter a valid number");
                    setCommentBox(suggestedComments);
                }
            }
            else
            {
                clearCommentBox();
            }
        }


        #endregion

        private void btnClearAll(object sender, EventArgs e)
        {
            ClearAllControls();
            rtbCommentTextSuggestions.SelectAll();
            rtbCommentTextSuggestions.SelectionColor = Color.Black;
            if (!isFirstClick)
            {
                btnCalculate.Text = "Calculate Using Section Heights";
                isFirstClick = true;
            }
        }




    }
}
