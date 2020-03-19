using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal class Defines
        {
            internal class CriteriaDefines
            {
                internal static string criterium_stock_number = "stock_number";
                internal static string criterium_tank_name = "tank_name";
                internal static string criterium_location = "id_location";
                internal static string criterium_valid_from = "valid_from";
                internal static string criterium_valid_to = "valid_to";
                internal static string criterium_include_cancelled = "include_cancelled";
            }
        }

        internal class SearchResultDefines
        {
            internal static string column_id_tank = "id_tank";
            internal static string column_id_stock = "id_stock";
            internal static string column_id_location = "id_location";
            internal static string column_stock_number = "stock_number";
            internal static string column_tank_name = "tank_name";
            internal static string column_stock_location = "stock_location";
            internal static string column_stock_capacity = "stock_capacity";
            internal static string column_quantity = "quantity";
            internal static string column_valid_from = "tank_valid_from";
            internal static string column_valid_to = "tank_valid_to";


        }
        public class DBTools
        {
            private string m_sConnection = "Data Source=.\\SQLEXPRESSEFILM;" +
                                           "User Instance=true;" +
                                           "User Id=sa-admin;" +
                                           "Password=@dm1n;" +
                                           "AttachDbFilename=|DataDirectory|StockDB.mdf;";
            private DataTable m_dtSearchResult = null;
            private DataTable m_dtCriteria = null;
            public string SearchResult { get; set; }
            public string Criteria { get; set; }
        }

        public class CreateTableCriteria
        {

        }

        public class AddLineTableCriteria
        {

        }

        public class Search
        {

        }


        DateTimePickerFormat m_defaultDateTimePickerFormat = DateTimePickerFormat.Short;

        private void ClearCriteria()
        {
            m_tbStockNumber.Text = string.Empty;
            m_tbTankName.Text = string.Empty;
            m_cbLocation.SelectedValue = null;
            m_dtValidFrom.Format = DateTimePickerFormat.Custom;
            m_dtValidTo.Format = DateTimePickerFormat.Custom;
            m_ckIncludingCancelledCnt.Checked = false;
        }

        private void InitDatePickerFormat()
        {
            m_dtValidFrom.Format = m_defaultDateTimePickerFormat;
            m_dtValidFrom.CustomFormat = " ";
            m_dtValidTo.Format = m_defaultDateTimePickerFormat;
            m_dtValidTo.CustomFormat = " ";
        }

        private void m_dtValidFrom_ValueChanged(object sender, EventArgs e)
        {
            m_dtValidFrom.Format = m_defaultDateTimePickerFormat;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void m_bClearCriteria_Click(object sender, EventArgs e)
        {
            ClearCriteria();
        }
    }
}
