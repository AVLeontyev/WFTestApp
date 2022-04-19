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
        string[] rowName;

        /// <summary>
        /// Запуск старта панели
        /// </summary>
        /// <param name="obj">Объект, инициировавший событие</param>
        /// <param name="ev">Аргумент события</param>
        private void FormMain_Load(object obj, EventArgs ev)
        {
            getData = new GetDataFromDB();
            getData.InitConnection();
            List<List<object>> DataTable = new List<List<object>>();

            DataTable = getData.GetDataFromTable();
            UpdateDataTаble(DataTable);
        }

        private void m_btnAdd_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < m_dgvValues.Columns.Count; j++)
            {
                //Значения ячеек хряняться в типе object
                m_insValues[j, 0].Value = m_dgvValues.SelectedRows[0].Cells[j].Value;
            }
            //this.m_listInput.Visible = true;
            //this.m_dgvValues.Size = new System.Drawing.Size(m_dgvValues.Size.Width, m_dgvValues.Size.Height-150);
            //this.m_btnLoad.Visible = true;
            //this.m_btnAdd.Visible = false;
            this.m_btnSave.Visible = true; 
            this.m_btnAdd.Visible = false;

            //m_listInput.Controls.Clear();
            //InitAddingPanel(0);
        }

        private void m_btnSave_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < m_dgvValues.Columns.Count; j++)
            {
                //Значения ячеек хряняться в типе object
                m_insValues[j, 0].Value = m_dgvValues.SelectedRows[0].Cells[j].Value;
            }
            //this.m_listInput.Visible = true;
            //this.m_dgvValues.Size = new System.Drawing.Size(m_dgvValues.Size.Width, m_dgvValues.Size.Height-150);
            //this.m_btnLoad.Visible = true;
            //this.m_btnAdd.Visible = false;
            this.m_btnSave.Visible = false;
            this.m_btnAdd.Visible = true;

            getData.UpdateDataFromTable((int)(m_dgvValues.SelectedRows[0].Cells[0].Value), m_insValues[1, 0].Value.ToString(), m_insValues[2, 0].Value.ToString(), m_insValues[3, 0].Value.ToString());

            m_dgvValues.Rows.Clear();
            m_dgvValues.Columns.Clear();
            m_insValues.Rows.Clear();
            m_insValues.Columns.Clear();

            List<List<object>> DataTable = new List<List<object>>();
            DataTable = getData.GetDataFromTable();
            UpdateDataTаble(DataTable);
        }

        private void m_btnLoad_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();

            for (int i = 0; i < m_dgvValues.Columns.Count; i++)
            {
                //Значения ячеек хряняться в типе object
                //это позволяет хранить любые данные в таблице
                list.Add(m_insValues[i, 0].Value);
            }

            getData.SetDataToTable(list);

            m_dgvValues.Rows.Clear();
            m_dgvValues.Columns.Clear();
            m_insValues.Rows.Clear();
            m_insValues.Columns.Clear();

            List<List<object>> DataTable = new List<List<object>>();
            DataTable = getData.GetDataFromTable();
            UpdateDataTаble(DataTable);
        }

        private void m_btnDelete_Click(object sender, EventArgs e)
        {
            getData.DeleteDataFromTable((int)(m_dgvValues.SelectedRows[0].Cells[0].Value));

            m_dgvValues.Rows.Clear();
            m_dgvValues.Columns.Clear();
            m_insValues.Rows.Clear();
            m_insValues.Columns.Clear();

            List<List<object>> DataTable = new List<List<object>>();
            DataTable = getData.GetDataFromTable();
            UpdateDataTаble(DataTable);
        }

        public void UpdateDataTаble(List<List<object>> DataTable)
        {
            m_dgvValues.Columns.Clear();
            m_dgvValues.Rows.Clear();

            rowName = new string[] { "ID", "Номер ТС", "Тип ТС", "Предприятие", "Гр/П", "Н/расх", "Дата списания" };

            int rowLenght = rowName.Length;
            
            int columnWidth = (m_dgvValues.Size.Width) / rowLenght;

            for (int i = 0; i < rowName.Length; i++)
            {
                var column = new DataGridViewColumn();
                column.HeaderText = rowName[i]; //текст в шапке
                column.Width = columnWidth; //ширина колонки
                column.ReadOnly = true; //значение в этой колонке нельзя править
                column.Name = "name" + i; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                column.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
                column.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

                if (i == 6)
                    column.DefaultCellStyle.Format = "dd.MM.yyyy";

                m_dgvValues.Columns.Add(column);

            }

            for (int i = 0; i < rowName.Length; i++)
            {
                var column = new DataGridViewColumn();
                column.HeaderText = rowName[i]; //текст в шапке
                column.Width = columnWidth + 10; //ширина колонки
                column.ReadOnly = false; //значение в этой колонке нельзя править
                column.Name = "name" + i; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                column.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
                column.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
                if (i == 0)
                    column.Visible = false;


                m_insValues.Columns.Add(column);

            }
            m_insValues.Rows.Add(1);

            if (DataTable.Count > 0)
            {

                m_insValues.ClearSelection();
                m_insValues.Columns[0].ReadOnly = false;
                m_insValues.EditMode = DataGridViewEditMode.EditOnEnter;
                m_insValues.MultiSelect = false;
                //m_insValues.CurrentCell = m_insValues.Rows[0].Cells[0];
                m_insValues.Focus();

                m_dgvValues.Rows.Add(DataTable.Count);
                //m_insValues.Rows.Add(1);
                //m_insValues[1, 0].Value = m_listUnits.SelectedItem;
                //m_insValues[2, 0].Value = m_listObjects.SelectedItem;

                for (int i = 0; i < m_dgvValues.Rows.Count; i++)
                {
                    for (int j = 0; j < m_dgvValues.Columns.Count; j++)
                    {
                        //Значения ячеек хряняться в типе object
                        m_dgvValues[j, i].Value = DataTable[i][j];
                    }
                }
            }
        }

    }
}
