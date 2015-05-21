/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* This code is generated by a tool and is provided "as is", without warranty of any kind,
* express or implied, including but not limited to the warranties of merchantability,
* fitness for a particular purpose and non-infringement.
* In no event shall the authors or copyright holders be liable for any claim, damages or
* other liability, whether in an action of contract, tort or otherwise, arising from,
* out of or in connection with the software or the use or other dealings in the software.
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PEIMSV3Cs
{
	public partial class frmLocation : Form
	{
		private MySqlDataAdapter ad;
		
		public frmLocation()
		{
			InitializeComponent();
		}
		
		private void frmlocation_Load(object sender, EventArgs e)
		{
			string strConn = "server=localhost;user id=root;database=pharma;password=;";
			ad = new MySqlDataAdapter("select * from `location`", strConn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(ad);
			ad.Fill(this.newDataSet.location);
			ad.DeleteCommand = builder.GetDeleteCommand();
			ad.UpdateCommand = builder.GetUpdateCommand();
			ad.InsertCommand = builder.GetInsertCommand();
			MySqlDataAdapter ad3;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			locationBindingSource.EndEdit();
			ad.Update(this.newDataSet.location);
			
		}
		
		private void frmlocation_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void locationIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( locationIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( locationIDTextBox, "The field locationID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( locationIDTextBox, "" ); } 
		}
		
		private void countryIDTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( countryIDTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( countryIDTextBox, "The field countryID is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( countryIDTextBox, "" ); } 
		}
		
		private void locationNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( locationNameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( locationNameTextBox, "The field locationName is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( locationNameTextBox, "" ); } 
		}
		
		private void storageCapacityTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( storageCapacityTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( storageCapacityTextBox, "The field storageCapacity is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( storageCapacityTextBox, "" ); } 
		}
		
		private void addressTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( addressTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( addressTextBox, "The field address is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( addressTextBox, "" ); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			locationBindingSource.AddNew();
		}

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            locationBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            locationBindingSource.RemoveCurrent();
            MessageBox.Show("Save the changes");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            locationBindingSource.EndEdit();
            ad.Update(this.newDataSet.location);
            MessageBox.Show("Record updated");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            locationBindingSource.EndEdit();
            ad.Update(this.newDataSet.location);
            MessageBox.Show("Record saved");
        }
	}
}