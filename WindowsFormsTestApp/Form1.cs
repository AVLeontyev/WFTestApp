using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GetDataFromDB getData;

        /// <summary>
        /// Запуск старта панели
        /// </summary>
        /// <param name="obj">Объект, инициировавший событие</param>
        /// <param name="ev">Аргумент события</param>
        private void FormMain_Load(object obj, EventArgs ev)
        {
            getData = new GetDataFromDB();
            getData.InitConnection();
        }

        private void m_btnAdd_Click(object sender, EventArgs e)
        {
            //this.m_listInput.Visible = true;
            //this.m_dgvValues.Size = new System.Drawing.Size(m_dgvValues.Size.Width, m_dgvValues.Size.Height-150);
            //this.m_btnLoad.Visible = true;
            //this.m_btnAdd.Visible = false;
            //this.m_btnBack.Visible = true;

            //m_listInput.Controls.Clear();
            //InitAddingPanel(0);
        }


        private void m_btnLoad_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();

      

            m_dgvValues.Rows.Clear();
            m_dgvValues.Columns.Clear();
            m_insValues.Rows.Clear();
            m_insValues.Columns.Clear();

            //List<List<object>> DataTable = new List<List<object>>();
            //DataTable = getData.GetDataFromTable((Int32)(m_btnLoad.Tag));
            //UpdateDataTаble(DataTable, (Int32)(m_btnLoad.Tag));

        }

        private void m_btnDelete_Click(object sender, EventArgs e)
        {
            //getData.DeleteDataFromTable((int)(m_dgvValues.SelectedRows[0].Cells[0].Value), (Int32)(m_btnLoad.Tag));

            m_dgvValues.Rows.Clear();
            m_dgvValues.Columns.Clear();
            m_insValues.Rows.Clear();
            m_insValues.Columns.Clear();

            //List<List<object>> DataTable = new List<List<object>>();
            //DataTable = getData.GetDataFromTable((Int32)(m_btnLoad.Tag));
            //UpdateDataTаble(DataTable, (Int32)(m_btnLoad.Tag));
        }
    }
}
