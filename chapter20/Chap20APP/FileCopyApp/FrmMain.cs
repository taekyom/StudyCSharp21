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

namespace FileCopyApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtSource.Text = dialog.FileName;
            }
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtTarget.Text = dialog.FileName;
            }
        }

        private async void BtnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyASync(TxtSource.Text, TxtTarget.Text);
            MessageBox.Show($"{totalCopied}로 복사했습니다!", "비동기 복사완료!");
        }

        private void BtnSynCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text); //동기 파일 복사(txtsource의 text => txttarget의 text로)
            MessageBox.Show($"{totalCopied}로 복사했습니다!", "동기복사완료");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소!");
        }

        //동기 복사
        private long CopySync(string sourcePath, string targetPath)
        {
            BtnAsyncCopy.Enabled = false; //비동기버튼(async) 비활성화
            long totalCopied = 0; //전부 복사했는지

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))//존재하는 파일
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create)) //새로 생성
                {
                    byte[] buffer = new byte[1024]; //1024(1KB) * 1024 ==> 1MB
                    int nRead = 0;
                    while ((nRead = sourceStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        targetStream.Write(buffer, 0, nRead); //복사위치
                        totalCopied += nRead;

                        //progress bar에 복사 진행 상태 표시
                        PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
                    }
                }
            }
            //copy 끝나면
            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }
        //비동기 복사
        private async Task<long> CopyASync(string sourcePath, string targetPath)
        {
            BtnSynCopy.Enabled = false; //동기버튼(sync) 비활성화
            long totalCopied = 0; //전부 복사했는지

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))//존재하는 파일
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create)) //새로 생성
                {
                    byte[] buffer = new byte[1024]; //1024(1KB) * 1024 ==> 1MB
                    int nRead = 0;
                    while ((nRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await targetStream.WriteAsync(buffer, 0, nRead); //복사위치
                        totalCopied += nRead;

                        //progress bar에 복사 진행 상태 표시
                        PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
                    }
                }
            }
            //copy 끝나면
            BtnSynCopy.Enabled = true;
            return totalCopied;
        }
    }
}

