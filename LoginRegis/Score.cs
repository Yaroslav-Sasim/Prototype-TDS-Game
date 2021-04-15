using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginRegis
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void tbBannedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbBannedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseGameDataSet);

        }

        private void Score_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseGameDataSet.tbBanned". При необходимости она может быть перемещена или удалена.
            this.tbBannedTableAdapter.Fill(this.baseGameDataSet.tbBanned);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseGameDataSet.tbScore". При необходимости она может быть перемещена или удалена.
            this.tbScoreTableAdapter.Fill(this.baseGameDataSet.tbScore);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseGameDataSet.tbUser". При необходимости она может быть перемещена или удалена.
            this.tbUserTableAdapter.Fill(this.baseGameDataSet.tbUser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseGameDataSet.tbUser". При необходимости она может быть перемещена или удалена.
            this.tbUserTableAdapter.Fill(this.baseGameDataSet.tbUser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseGameDataSet.tbScore". При необходимости она может быть перемещена или удалена.
            this.tbScoreTableAdapter.Fill(this.baseGameDataSet.tbScore);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseGameDataSet.tbBanned". При необходимости она может быть перемещена или удалена.
            this.tbBannedTableAdapter.Fill(this.baseGameDataSet.tbBanned);

        }

        private void tbBannedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbUserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseGameDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
