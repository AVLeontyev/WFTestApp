using System.Windows.Forms;
using System.Drawing;
using System;

namespace WindowsFormsTestApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_labelCompany = new System.Windows.Forms.Label();
            this.m_labelTp = new System.Windows.Forms.Label();
            this.m_labelVd = new System.Windows.Forms.Label();

            this.m_listCompanyLB = new System.Windows.Forms.ComboBox();
            this.m_listTpLB = new System.Windows.Forms.ComboBox();
            this.m_listVdLB = new System.Windows.Forms.ComboBox();

            this.m_dgvValues = new System.Windows.Forms.DataGridView();
            this.m_insValues = new System.Windows.Forms.DataGridView();

            this.m_btnLoad = new System.Windows.Forms.Button();
            this.m_btnAdd = new System.Windows.Forms.Button();
            this.m_btnDelete = new System.Windows.Forms.Button();
            this.m_btnSave = new System.Windows.Forms.Button();

            {
                this.MainMenuStrip = new MenuStrip();
                this.MainMenuStrip.Items.AddRange(
                  new ToolStripMenuItem[] {
                    new ToolStripMenuItem (@"Файл")
                    , new ToolStripMenuItem (@"Вспомогательные формы")
                    , new ToolStripMenuItem (@"О программе")
                    }
                );

                (this.MainMenuStrip.Items[0] as ToolStripMenuItem).DropDownItems.Add(new ToolStripMenuItem(@"Выход"));

                (this.MainMenuStrip.Items[1] as ToolStripMenuItem).DropDownItems.Add(new ToolStripMenuItem(@"Типы ТС"));
                (this.MainMenuStrip.Items[1] as ToolStripMenuItem).DropDownItems.Add(new ToolStripMenuItem(@"Виды ТС"));
            }


            // 
            // m_listCompanyLB
            // 
            this.m_listCompanyLB.Location = new System.Drawing.Point(100, 65);
            this.m_listCompanyLB.Size = new System.Drawing.Size(100, 20);
            this.m_listCompanyLB.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // m_listTpLB
            // 
            this.m_listTpLB.Location = new System.Drawing.Point(200, 65);
            this.m_listTpLB.Size = new System.Drawing.Size(100, 20);
            this.m_listTpLB.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // m_listVdLB
            // 
            this.m_listVdLB.Location = new System.Drawing.Point(300, 65);
            this.m_listVdLB.Size = new System.Drawing.Size(100, 20);
            this.m_listVdLB.DropDownStyle = ComboBoxStyle.DropDownList;
            //this.m_listCompanyLB.SelectedIndexChanged += new EventHandler(unitsListCheckedChange);
            // 
            // m_labelCompany
            // 
            this.m_labelCompany.AutoSize = true;
            this.m_labelCompany.Location = new System.Drawing.Point(100, 35);
            this.m_labelCompany.Name = "m_labelCompany";
            this.m_labelCompany.Size = new System.Drawing.Size(40, 15);
            this.m_labelCompany.TabIndex = 2;
            this.m_labelCompany.Text = "Кампания: ";
            // 
            // m_labelTp
            // 
            this.m_labelTp.AutoSize = true;
            this.m_labelTp.Location = new System.Drawing.Point(200, 35);
            this.m_labelTp.Name = "m_labelTp";
            this.m_labelTp.Size = new System.Drawing.Size(40, 15);
            this.m_labelTp.TabIndex = 2;
            this.m_labelTp.Text = "Тип техники: ";
            // 
            // m_labelVd
            // 
            this.m_labelVd.AutoSize = true;
            this.m_labelVd.Location = new System.Drawing.Point(300, 35);
            this.m_labelVd.Name = "m_labelVd";
            this.m_labelVd.Size = new System.Drawing.Size(40, 15);
            this.m_labelVd.TabIndex = 2;
            this.m_labelVd.Text = "Вид техники: ";
            // 
            // m_btnLoad
            // 
            this.m_btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnLoad.Location = new System.Drawing.Point(0, 210);
            this.m_btnLoad.Name = "m_btnLoad";
            this.m_btnLoad.Size = new System.Drawing.Size(75, 33);
            this.m_btnLoad.TabIndex = 10;
            this.m_btnLoad.Text = "Добавить";
            this.m_btnLoad.UseVisualStyleBackColor = true;
            this.m_btnLoad.Click += new System.EventHandler(this.m_btnLoad_Click);
            this.m_btnLoad.Visible = true;
            //this.m_btnLoad.BringToFront();
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnAdd.Location = new System.Drawing.Point(100, 210);
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.Size = new System.Drawing.Size(75, 33);
            this.m_btnAdd.TabIndex = 10;
            this.m_btnAdd.Text = "Изменить";
            this.m_btnAdd.UseVisualStyleBackColor = true;
            this.m_btnAdd.Click += new System.EventHandler(this.m_btnAdd_Click);
            this.m_btnAdd.Visible = true;
            // 
            // m_btnDelete
            // 
            this.m_btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnDelete.Location = new System.Drawing.Point(200, 210);
            this.m_btnDelete.Name = "m_btnDelete";
            this.m_btnDelete.Size = new System.Drawing.Size(75, 33);
            this.m_btnDelete.TabIndex = 10;
            this.m_btnDelete.Text = "Удалить";
            this.m_btnDelete.UseVisualStyleBackColor = true;
            this.m_btnDelete.Click += new System.EventHandler(this.m_btnDelete_Click);
            this.m_btnDelete.Visible = true;

            // 
            // m_btnSave
            // 
            this.m_btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnSave.Location = new System.Drawing.Point(100, 210);
            this.m_btnSave.Name = "m_btnSave";
            this.m_btnSave.Size = new System.Drawing.Size(75, 33);
            this.m_btnSave.TabIndex = 10;
            this.m_btnSave.Text = "Сохранить";
            this.m_btnSave.UseVisualStyleBackColor = true;
            this.m_btnSave.Click += new System.EventHandler(this.m_btnSave_Click);
            this.m_btnSave.Visible = false;

            // 
            // m_dgvValues
            // 
            this.m_dgvValues.AllowUserToAddRows = false;
            this.m_dgvValues.AllowUserToDeleteRows = false;
            this.m_dgvValues.AllowUserToOrderColumns = true;
            this.m_dgvValues.AllowUserToResizeColumns = true;
            this.m_dgvValues.AllowUserToResizeRows = false;
            this.m_dgvValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dgvValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            //this.m_dgvValues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.m_dgvValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvValues.Location = new System.Drawing.Point(15, 100);
            this.m_dgvValues.Name = "m_dgvValues";
            this.m_dgvValues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.m_dgvValues.RowTemplate.ReadOnly = true;
            this.m_dgvValues.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.m_dgvValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvValues.Size = new System.Drawing.Size(250, 200);
            this.m_dgvValues.TabIndex = 4;
            this.m_dgvValues.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            //this.m_dgvValues.RowTemplate.Height = 30;
            this.m_dgvValues.RowHeadersVisible = false;
            // 
            // m_insValues
            // 
            this.m_insValues.AllowUserToAddRows = false;
            this.m_insValues.AllowUserToDeleteRows = false;
            this.m_insValues.AllowUserToOrderColumns = true;
            this.m_insValues.AllowUserToResizeColumns = false;
            this.m_insValues.AllowUserToResizeRows = false;
            this.m_insValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_insValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.m_insValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_insValues.Location = new System.Drawing.Point(15, 160);
            this.m_insValues.MultiSelect = false;
            this.m_insValues.Name = "m_insValues";
            this.m_insValues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.m_insValues.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.m_insValues.Size = new System.Drawing.Size(250, 50);
            this.m_insValues.TabIndex = 4;
            this.m_insValues.Visible = true;

            {
                this.Controls.Add(MainMenuStrip);
                this.Controls.Add(this.m_labelCompany);
                this.Controls.Add(this.m_labelTp);
                this.Controls.Add(this.m_labelVd);
                this.Controls.Add(this.m_listCompanyLB);
                this.Controls.Add(this.m_listTpLB);
                this.Controls.Add(this.m_listVdLB);
                this.Controls.Add(this.m_dgvValues);
                this.Controls.Add(this.m_insValues);
                this.Controls.Add(this.m_btnLoad);
                this.Controls.Add(this.m_btnDelete);
                this.Controls.Add(this.m_btnAdd);
                this.Controls.Add(this.m_btnSave);
            }

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Форма учета транспорта (?)";
            this.Load += new System.EventHandler(this.FormMain_Load);
        }

        #endregion

        private System.Windows.Forms.Label m_labelCompany;
        private System.Windows.Forms.Label m_labelVd;
        private System.Windows.Forms.Label m_labelTp;

        private System.Windows.Forms.ComboBox m_listCompanyLB;
        private System.Windows.Forms.ComboBox m_listVdLB;
        private System.Windows.Forms.ComboBox m_listTpLB;

        private System.Windows.Forms.Button m_btnLoad;
        private System.Windows.Forms.Button m_btnAdd;
        private System.Windows.Forms.Button m_btnDelete;
        private System.Windows.Forms.Button m_btnSave;

        private DataGridView m_dgvValues;
        private DataGridView m_insValues;
    }
}

