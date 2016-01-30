using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharma.Utility;

namespace Pharmachy
{
    public partial class FrmUnitConversion : Form
    {
        public string Qry = string.Empty;
        public DataTable dtInfo = new DataTable();

        public FrmUnitConversion()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmUnitConversion_Load);
        }

        void FrmUnitConversion_Load(object sender, EventArgs e)
        {
            Qry = "select UnitGroupName from unit_group";
            dtInfo = DbUtility.GetDataTable(Qry);
            if (dtInfo.Rows.Count > 0)
            {
                cboUnitType.DataSource = dtInfo;
                cboUnitType.DisplayMember = "UnitGroupName";
                cboUnitType.ValueMember = "UnitGroupName";

                this.btnSave.Click += new EventHandler(btnSave_Click);
            }
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            SortedList sl = new SortedList();

            Qry = "delete from Unit_master where UnitGroupName='" + cboUnitType.Text + "'";
            sl.Add(sl.Count + 1, Qry);

            for (int i = 0; i < dgvInfo.Rows.Count - 1; i++)
            {
                Qry = "INSERT INTO [dbo].[Unit_Master] " +
                      " ([UnitGroupName]" +
                      " ,[UnitID]" +
                      " ,[UnitName]" +
                      " ,[RelativeFactor]" +
                      " ,[IsBaseUOM]" +
                      " ,[AddedBy]" +
                      " ,[DateAdded])" +
                 " VALUES " +
                       " ('" + cboUnitType.Text + "'," +
                       "'" + dgvInfo.Rows[i].Cells[0].Value.ToString() + "'," +
                      "'" + dgvInfo.Rows[i].Cells[1].Value.ToString() + "'," +
                       "" + dgvInfo.Rows[i].Cells[2].Value.ToString() + "," +
                       "'" + Convert.ToBoolean(dgvInfo.Rows[i].Cells[3].Value) + "'," +
                      "'" + LoginSession.UserID + "',getdate())";
                sl.Add(sl.Count + 1, Qry);
            }

            DbUtility.ExecuteQuery(sl, "");
            MessageBox.Show("Saved");
        }

        private void cboUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Qry = "select UnitID,UnitName,RelativeFactor,IsBaseUOM from unit_master where UnitGroupName='" + cboUnitType.Text + "'";
            dtInfo = DbUtility.GetDataTable(Qry);
            dgvInfo.Rows.Clear();
            if (dtInfo.Rows.Count > 0)
            {
                foreach (DataRow dr in dtInfo.Rows)
                {
                    dgvInfo.Rows.Add(dr["UnitID"].ToString(), dr["UnitName"].ToString(), dr["RelativeFactor"].ToString(), dr["IsBaseUOM"].ToString(), "Delete");
                }
            }
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colRemove.Index)
            {
                dgvInfo.Rows.RemoveAt(e.RowIndex);
            }
        }

        void btnSave_Click_1(object sender, EventArgs e)
        {
            

        }
        

    }
}
