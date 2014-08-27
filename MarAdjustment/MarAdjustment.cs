using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        #region Enums
        public enum MovementType
        {
            NA = 0,
            Down = 1,
            Up = 2      
        }
        #endregion

        #region Properties and Fields

        private decimal _headerHeightSug;
        private decimal _footerHeighSug;

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

        public decimal headerHeightSug        
        {
            get
            {
                return _headerHeightSug;
            }

            set
            {
                value = value <= 0 ? 0 : value;
                _headerHeightSug = value;
            }
        }
        public decimal footerHeightSug
        {
            get
            {
                return _footerHeighSug;
            }

            set
            {
                value = value <= 0 ? 0 : value;
                _footerHeighSug = value;
            }
        }

        private StringBuilder suggestedComments { get; set; }

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
            list.Add(MovementType.NA, "");
            list.Add(MovementType.Down, "Down");
            list.Add(MovementType.Up, "Up");

            uxDesiredMovement.DisplayMember = "Value";
            uxDesiredMovement.ValueMember = "Key";
            uxDesiredMovement.DataSource = list.ToList();
        }
        #endregion

        private void SetValues()
        {
             pageHeight = uxPageHeight.Text.Trim() != string.Empty? decimal.Parse(uxPageHeight.Text.Trim()):0;
             rowsPerDetail = uxRowsPerDetail.Text.Trim() != string.Empty ? int.Parse(uxRowsPerDetail.Text.Trim()) : 0;
             detailsPerPage = uxDetailsPerPage.Text.Trim() != string.Empty ? int.Parse(uxDetailsPerPage.Text.Trim()) : 0;

             desiredMovement = (MovementType)uxDesiredMovement.SelectedValue;

             topMarginOG = uxTopMarginOG.Text.Trim() != string.Empty? decimal.Parse(uxTopMarginOG.Text.Trim()):0;
             headerHeightOG = uxHeaderHeightOG.Text.Trim() != string.Empty? decimal.Parse(uxHeaderHeightOG.Text.Trim()):0;
             detailHeightOG = uxDetailHeightOG.Text.Trim() != string.Empty? decimal.Parse(uxDetailHeightOG.Text.Trim()):0;
             footerHeightOG = uxPageFooterHeightOG.Text.Trim() != string.Empty ? decimal.Parse(uxPageFooterHeightOG.Text.Trim()) : 0;
             bottomMarginHeightOG = uxBottomMarginOG.Text.Trim() != string.Empty ? decimal.Parse(uxBottomMarginOG.Text.Trim()) : 0;
             numberLinesToMoveBy = uxNumberLinesToMoveBy.Text.Trim() != string.Empty ? decimal.Parse(uxNumberLinesToMoveBy.Text.Trim()) : 0;

             

             //topMarginSug = uxTopMarginSug.Text.Trim() != string.Empty ? decimal.Parse(uxTopMarginSug.Text.Trim()) : 0;
             //headerHeightSug = uxHeaderHeightSug.Text.Trim() != string.Empty ? decimal.Parse(uxHeaderHeightSug.Text.Trim()) : 0;
             //detailHeightSug = uxDetailHeightSug.Text.Trim() != string.Empty ? decimal.Parse(uxDetailHeightSug.Text.Trim()) : 0;
             //footerHeightSug = uxPageFooterHeightSug.Text.Trim() != string.Empty ? decimal.Parse(uxPageFooterHeightSug.Text.Trim()) : 0;
             //bottomMarginHeightSug = uxBottomMarginSug.Text.Trim() != string.Empty ? decimal.Parse(uxBottomMarginSug.Text.Trim()) : 0; 
        }

        private void SetDefaultValues()
        {
            lblCommentTextSuggestions.Text = String.Empty;
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
                suggestedComments.AppendLine("Select all contents of the footer except the red Reminder Textbox (if there is one)");
                suggestedComments.AppendLine("and move everything DOWN by: " + inchesToMove.ToString("0.00") + " inches");
                suggestedComments.AppendLine("Note that 1 hit of the up or down arrow key is .01 inches each time pressed");
                setCommentBox(suggestedComments);
                setIssueNotes(Movement, inchesToMove, calculatedHeight);
            }
            else
            {
                calculatedHeight = footerHeight - inchesToMove;

                clearCommentBox();
                suggestedComments.AppendLine("Select all contents of the footer except the red Reminder Textbox (if there is one)");
                suggestedComments.AppendLine("and move everything UP by: " + inchesToMove.ToString("0.00") + " inches");
                suggestedComments.AppendLine("Note that 1 hit of the up or down arrow key is .01 inches each time pressed");
                setCommentBox(suggestedComments);
                setIssueNotes(Movement, inchesToMove, calculatedHeight);
            }

            return calculatedHeight.ToString("0.000");
        }

        private void setCommentBox(StringBuilder comment)
        {
            lblCommentTextSuggestions.Text = comment.ToString();
        }
        private void clearCommentBox()
        {
            suggestedComments.Clear();
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


        #endregion

        #region events

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SetValues();
            uxHeaderHeightSug.Text = calculateHeaderHeight(headerHeightOG, detailHeightOG, desiredMovement, numberLinesToMoveBy);
            uxPageFooterHeightSug.Text = calculateFooterHeight(footerHeightOG, detailHeightOG, desiredMovement, numberLinesToMoveBy);

        }

        private void uxDesiredMovement_Leave(object sender, EventArgs e)
        {
            if ((MovementType)uxDesiredMovement.SelectedValue == MovementType.Up)
            {
                clearCommentBox();
                suggestedComments.AppendLine("You can not resolve this by adjusting the adjustmens on the printer group and will have to adjust the layout height.");
                setCommentBox(suggestedComments);

            }
            else if ((MovementType)uxDesiredMovement.SelectedValue == MovementType.Down)
            {
                clearCommentBox();
                suggestedComments.AppendLine("Have you tried adding a vertical adjustment on the printer group?");
                suggestedComments.AppendLine("Note: This will shift all contents (header, footer, details) down");
                setCommentBox(suggestedComments);
            }
        }

        #endregion




    }
}
