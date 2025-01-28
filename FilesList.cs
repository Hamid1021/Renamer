using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_Renamer
{
    public partial class FilesList : Form
    {
        private List<string> files;
        private List<string> bindingList;

        public FilesList(List<string> files)
        {
            InitializeComponent();
            this.files = new List<string>(files);
            bindingList = new List<string>(this.files);
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.DataSource = bindingList.Select(f => new { FileName = f }).ToList();
        }

        public List<string> GetUpdatedFileList()
        {
            return bindingList;
        }

        private void go_up_Click(object sender, EventArgs e)
        {
            MoveSelectedRows(-1);
        }

        private void go_down_Click(object sender, EventArgs e)
        {
            MoveSelectedRows(1);
        }

        private void go_topest_Click(object sender, EventArgs e)
        {
            MoveSelectedRowsToEnd(-1);
        }

        private void go_downest_Click(object sender, EventArgs e)
        {
            MoveSelectedRowsToEnd(1);
        }

        private void MoveSelectedRows(int direction)
        {
            var selectedRow = dataGridView1.SelectedRows.Cast<DataGridViewRow>().OrderBy(r => r.Index).ToList();
            if (selectedRow.Count == 0)
            {
                MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newIndex = -1;
            foreach (var row in selectedRow)
            {
                newIndex = row.Index + direction;
                if (newIndex < 0 || newIndex >= bindingList.Count) continue;

                var file = bindingList[row.Index];
                bindingList.RemoveAt(row.Index);
                bindingList.Insert(newIndex, file);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingList.Select(f => new { FileName = f }).ToList();
            if (!(newIndex < 0 || newIndex >= dataGridView1.Rows.Count))
                dataGridView1.Rows[newIndex].Selected = true;
        }

        private void MoveSelectedRowsToEnd(int direction)
        {
            var selectedRow = dataGridView1.SelectedRows.Cast<DataGridViewRow>().OrderBy(r => r.Index).ToList();
            if (selectedRow.Count == 0)
            {
                MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (direction == -1)
            {
                foreach (var row in selectedRow)
                {
                    var file = bindingList[row.Index];
                    bindingList.RemoveAt(row.Index);
                    bindingList.Insert(0, file);
                    dataGridView1.Rows[0].Selected = true;
                }
            }
            else if (direction == 1)
            {
                for (int i = selectedRow.Count - 1; i >= 0; i--)
                {
                    var row = selectedRow[i];
                    var file = bindingList[row.Index];
                    bindingList.RemoveAt(row.Index);
                    bindingList.Add(file);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bindingList.Select(f => new { FileName = f }).ToList();
            switch (direction)
            {
                case 1:
                    dataGridView1.Rows[bindingList.Count - 1].Selected = true;
                    break;
                case 2:
                    dataGridView1.Rows[0].Selected = true;
                    break;
            }
        }
    }

}


