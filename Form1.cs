// نویسنده: حمیدرضا رضایی Mr.Hidden
// ایمیل: Hamid1063.1021@gmail.com
// حقوق: تمامی حقوق محفوظ است.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace Serial_Renamer
{
    public partial class Form1 : Form
    {
        private bool _alwayes_on_top;
        private List<string> files;
        private List<string> originalFileNames;
        public Form1()
        {
            InitializeComponent();
            files = new List<string>();
            originalFileNames = new List<string>();
            _alwayes_on_top = false;
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            CreditForm _frmCreditForm = new CreditForm();
            _frmCreditForm.ShowDialog();
        }

        private void alwaysOnTop_Click(object sender, EventArgs e)
        {
            if (_alwayes_on_top)
            {
                _alwayes_on_top = false;
                TopMost = false;
                alwaysOnTop.Text = "غیر فعال";
            }
            else
            {
                _alwayes_on_top = true;
                TopMost = true;
                alwaysOnTop.Text = "فعال";
            }
        }

        private void select_path_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "پوشه حاوی فیلم یا زیر نویس را انتخاب کنید";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                folder_path_txt.Text = selectedFolderPath;
            }
        }

        private void clean_select_path_btn_Click(object sender, EventArgs e)
        {
            folder_path_txt.Text = "";
        }

        private void from_clipboard_path_btn_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                folder_path_txt.Text = clipboardText;
            }
        }

        private void open_folder_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = folder_path_txt.Text,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("هیچ مسیری انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reset_select_type_btn_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }


        // My Functions
        private int NaturalSortComparer(string x, string y)
        {
            var regex = new Regex(@"(\d+)|(\D+)");
            var xMatches = regex.Matches(x);
            var yMatches = regex.Matches(y);

            int i = 0;
            while (i < xMatches.Count && i < yMatches.Count)
            {
                var xPart = xMatches[i].Value;
                var yPart = yMatches[i].Value;

                int xNumber, yNumber;
                bool xIsNumber = int.TryParse(xPart, out xNumber);
                bool yIsNumber = int.TryParse(yPart, out yNumber);

                int result;
                if (xIsNumber && yIsNumber)
                {
                    result = xNumber.CompareTo(yNumber);
                }
                else
                {
                    result = string.Compare(xPart, yPart, StringComparison.OrdinalIgnoreCase);
                }
                if (result != 0)
                {
                    return result;
                }
                i++;
            }

            return xMatches.Count.CompareTo(yMatches.Count);
        }

        private List<string> ListFilesInDirectory(string folderPath, List<string> extensions)
        {
            try
            {
                List<string> fileNames = new List<string>();
                if (extensions == null || extensions.Count == 0)
                {
                    string[] files = Directory.GetFiles(folderPath);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        fileNames.Add(fileName);
                    }
                }
                else
                {
                    foreach (string extension in extensions)
                    {
                        string[] files = Directory.GetFiles(folderPath, $"*.{extension}");
                        foreach (string file in files)
                        {
                            string fileName = Path.GetFileName(file);
                            fileNames.Add(fileName);
                        }
                    }
                }
                fileNames.Sort(NaturalSortComparer);
                foreach (var _f in fileNames)
                {
                    originalFileNames.Add(_f);
                }
                return fileNames;
            }
            catch (Exception ex)
            {
                return new List<string>() { };
            }
        }

        private void submit_path_btn_Click(object sender, EventArgs e)
        {
            if (folder_path_txt.Text != "")
            {
                List<string> extensions = new List<string>();
                if (r_ass.Checked) { extensions.Add(r_ass.Text.ToLower()); }
                else if (r_srt.Checked) { extensions.Add(r_srt.Text.ToLower()); }
                else if (r_srt_ass.Checked) { extensions.Add(r_ass.Text.ToLower()); extensions.Add(r_srt.Text.ToLower()); }
                else if (r_mkv.Checked) { extensions.Add(r_mkv.Text.ToLower()); }
                else if (r_mp4.Checked) { extensions.Add(r_mp4.Text.ToLower()); }
                else if (r_mkv_mp4.Checked) { extensions.Add(r_mkv.Text.ToLower()); extensions.Add(r_mp4.Text.ToLower()); }
                files = ListFilesInDirectory(folder_path_txt.Text, extensions);
                if (files.Count > 0)
                {
                    PathState(true);
                }
                else
                {
                    MessageBox.Show("این نوع فایل در این پوشه وجود ندارد",
                        "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ابتدا باید یک مسیر انتخاب نمایید",
                    "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PathState(bool status)
        {
            foreach (Control control in groupBox3.Controls)
            {
                control.Enabled = status;
                if (control is TextBox _txt)
                {
                    _txt.ReadOnly = !status;
                }

                if (control is NumericUpDown _chk)
                {
                    _chk.ReadOnly = !status;
                }
            }
            redo_rename_btn.Enabled = false;
            check_sort_list_btn.Enabled = true;
        }

        private void from_clipboard_befor_name_btn_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                before_name_txt.Text = clipboardText;
            }
        }

        private void from_clipboard_after_name_btn_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                after_name_txt.Text = clipboardText;
            }
        }

        private void clean_befor_name_btn_Click(object sender, EventArgs e)
        {
            before_name_txt.Text = "";
        }

        private void clean_after_name_btn_Click(object sender, EventArgs e)
        {
            after_name_txt.Text = "";
        }

        private void start_renam_btn_Click(object sender, EventArgs e)
        {
            if (before_name_txt.Text != "" && start_number_from_txt.Value > 0)
            {
                string beforeName = before_name_txt.Text;
                string afterName = after_name_txt.Text;
                int startNumber = (int)start_number_from_txt.Value;
                string folderPath = folder_path_txt.Text;

                SerialRenamer renamer = new SerialRenamer(beforeName, afterName, startNumber, folderPath);
                files = renamer.StartRename(files);
                PathState(false);
                redo_rename_btn.Enabled = true;
                start_renam_btn.Enabled = false;
                check_sort_list_btn.Enabled = false;
                MessageBox.Show("فایل‌ها با موفقیت تغییر نام یافتند", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لطفا فیلدهای لازم را پر نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void redo_rename_btn_Click(object sender, EventArgs e)
        {
            PathState(false);
            check_sort_list_btn.Enabled = false;
            SerialRenamer renamer = new SerialRenamer("", "", 0, folder_path_txt.Text);
            renamer.RedoRename(originalFileNames, files);

            MessageBox.Show("فایل‌ها به نام‌های اصلی خود بازگردانده شدند", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void check_sort_list_btn_Click(object sender, EventArgs e)
        {
            FilesList _filesList = new FilesList(files);
            if (_filesList.ShowDialog() == DialogResult.Cancel)
            {
                files = _filesList.GetUpdatedFileList();
                originalFileNames = new List<string>(files);
            }
        }
    }
}
