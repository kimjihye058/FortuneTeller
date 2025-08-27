using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTeller
{
    public partial class Form1 : Form
    {
        List<string> results;

        public Form1()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            try
            {
                string filename = "results.csv";
                results = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일을 불러올 수 없습니다.\n{ex.Message}", "파일이 없는 오류!");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"파일에 접근권환이 없습니다.\n{ex.Message}", "파일 권한 오류!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다.\n{ex.Message}", "알 수 없는 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 상담내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if(form != null)
            {
                form.Activate();
            }
            else             
            {
                form = new FormHistory(this);
                form.Show();
            }
        }

        private string GetFortune()
        {
            Random random = new Random();
            int index = random.Next(0, results.Count);
            return results[index];
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void 포츈텔러정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            string birthDay = tbBirthDay.Text;
            string birthTime = tbBirthTime.Text;
            string result = GetFortune();
            string saju = result.Split('|')[0];
            string message = result.Split('|')[1];
            tbResult.Text = birthDay + " " + birthTime + "시" + Environment.NewLine
                + saju + Environment.NewLine
                + message;

            // 저장
            SaveHistory($"{birthDay} {birthTime} | {result}");
        }

        private void SaveHistory(string history)
        {
            try
            {
                string filename = "history.csv";
                File.AppendAllText(filename, history + Environment.NewLine);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"파일에 접근권환이 없습니다.\n{ex.Message}", "파일 권한 오류!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다.\n{ex.Message}", "알 수 없는 오류!");
            }
        }

        internal void LoadHistory(string history)
        {
            string birthDay = history.Split('|')[0].Split(' ')[0];
            tbBirthDay.Text = birthDay;
            string birthTime = history.Split('|')[0].Split(' ')[1];
            tbBirthTime.Text = birthTime;
            string saju = history.Split('|')[1];
            string message = history.Split('|')[2];
            tbResult.Text = birthDay + " " + birthTime + "시" + Environment.NewLine
                + saju + Environment.NewLine
                + message;
        }
    }
}
