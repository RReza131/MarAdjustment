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
        }
        #endregion

        #region Enums
        public enum MovementType
        {
            Down = 0,
            Up = 1      
        }
        #endregion

        #region Properties and Fields

        private decimal _headerHeightSug;
        private decimal _footerHeighSug;
        private decimal _headerHeightSug;

        public decimal pageHeight { get; set; }

        public int rowsPerDetail { get; set; }
        public int detailsPerPage { get; set; }

        public MovementType desiredMovement { get; set; }

        public decimal topMarginOG { get; set; }
        public decimal headerHeightOG { get; set; }
        public decimal detailHeightOG { get; set; }
        public decimal footerHeightOG { get; set; }
        public decimal bottomMarginHeightOG { get; set; }

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

        private string suggestedComments { get; set; }

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
             pageHeight = uxPageHeight.Text.Trim() != string.Empty? decimal.Parse(uxPageHeight.Text.Trim()):0;
             rowsPerDetail = uxRowsPerDetail.Text.Trim() != string.Empty ? int.Parse(uxRowsPerDetail.Text.Trim()) : 0;
             detailsPerPage = uxDetailsPerPage.Text.Trim() != string.Empty ? int.Parse(uxDetailsPerPage.Text.Trim()) : 0;

             desiredMovement = (MovementType)uxDesiredMovement.SelectedValue;

             topMarginOG = uxTopMarginOG.Text.Trim() != string.Empty? decimal.Parse(uxTopMarginOG.Text.Trim()):0;
             headerHeightOG = uxHeaderHeightOG.Text.Trim() != string.Empty? decimal.Parse(uxHeaderHeightOG.Text.Trim()):0;
             detailHeightOG = uxDetailHeightOG.Text.Trim() != string.Empty? decimal.Parse(uxDetailHeightOG.Text.Trim()):0;
             footerHeightOG = uxPageFooterHeightOG.Text.Trim() != string.Empty ? decimal.Parse(uxPageFooterHeightOG.Text.Trim()) : 0;
             bottomMarginHeightOG = uxBottomMarginOG.Text.Trim() != string.Empty ? decimal.Parse(uxBottomMarginOG.Text.Trim()) : 0;

             //topMarginSug = uxTopMarginSug.Text.Trim() != string.Empty ? decimal.Parse(uxTopMarginSug.Text.Trim()) : 0;
             //headerHeightSug = uxHeaderHeightSug.Text.Trim() != string.Empty ? decimal.Parse(uxHeaderHeightSug.Text.Trim()) : 0;
             //detailHeightSug = uxDetailHeightSug.Text.Trim() != string.Empty ? decimal.Parse(uxDetailHeightSug.Text.Trim()) : 0;
             //footerHeightSug = uxPageFooterHeightSug.Text.Trim() != string.Empty ? decimal.Parse(uxPageFooterHeightSug.Text.Trim()) : 0;
             //bottomMarginHeightSug = uxBottomMarginSug.Text.Trim() != string.Empty ? decimal.Parse(uxBottomMarginSug.Text.Trim()) : 0; 
        }

        private string calculateHeaderHeight(decimal headerHeight, decimal detailHeight, MovementType Movement)
        {
            decimal calculatedHeight;

            if (Movement == MovementType.Up)
            {
                calculatedHeight = headerHeight - detailHeight;
            }
            else
            {
                calculatedHeight = headerHeight + detailHeight;
            }        
            
            return calculatedHeight.ToString("0.00");
        }
        private string calculateFooterHeight(decimal footerHeight, decimal detailHeight, MovementType Movement)
        {
            decimal calculatedHeight;

            if (Movement == MovementType.Up)
            {
                calculatedHeight = footerHeight + detailHeight;
            }
            else
            {
                calculatedHeight = footerHeight - detailHeight;
            }

            return calculatedHeight.ToString("0.00");
        }



        #endregion

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SetValues();
            uxHeaderHeightSug.Text = calculateHeaderHeight(headerHeightOG, detailHeightOG, desiredMovement);
            uxPageFooterHeightSug.Text = calculateHeaderHeight(footerHeightOG, detailHeightOG, desiredMovement);

        }




    }
}
