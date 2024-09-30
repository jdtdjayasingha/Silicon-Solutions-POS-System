using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiliconSolutions
{
    public partial class Brand : DevExpress.XtraEditors.XtraForm
    {
        private String con = Connection.ConnectionString;
        public Brand()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String name = textEditName.Text;
            String description = textEditDescription.Text;

            SqlConnection myCon = new SqlConnection(con);

            String query = @"INSERT INTO BrandTB (
                                    brand_name, 
                                    brand_description) 
                                VALUES (
                                    @bName, 
                                    @bDescription)";

            SqlCommand cmd = new SqlCommand(query, myCon);
                
            cmd.Parameters.AddWithValue("@bName", name);
            cmd.Parameters.AddWithValue("@bDescription", description);

            try
            {
                myCon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
                
           
        }
    }
}
