using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControlsApp
{
    public partial class FrmMain : Form
    {
        Random random = new Random(37);
        public FrmMain()
        {
            InitializeComponent();
        }
        #region 이벤트 핸들러 영역
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LsvDummy.Columns.Add("Name");
            LsvDummy.Columns.Add("Depth");

            var FontList = FontFamily.Families;
            foreach (var font in FontList)
            {
                CboFont.Items.Add(font.Name);
            }
        }
        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = TrbHandle.Value;
        }
        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Height = 100;
            frm.Width = 300;
            frm.BackColor = Color.Coral;
            frm.ShowDialog(); //Modal창 띄우는 것, showdialog : modal창 실행 시 아래 부모창은 비활성화
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form
            {
                Text = "Modaless Form",
                Height = 100,
                Width = 300,
                BackColor = Color.YellowGreen
            };
            frm.Show(); //Modaless창 띄우는 것, show : modaless창 실행 중에도 부모창 실행 가능
        }
        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            //modal창 messagebox
            MessageBox.Show(TextResult.Text, "타이틀", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(random.Next().ToString());
            
            DisplayTreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            TrvDummy.SelectedNode.Expand();

            DisplayTreeToList();
        }
        #endregion

        #region 사용자 메서드 영역
        //콤보박스, 체크박스 값변경으로 글자체 변경 메서드
        private void ChangeFont()
        {
            if (CboFont.SelectedIndex < 0) return; //콤보박스에 아무것도 선택하지 않았으면(-1) 메소드 탈출
            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold; //00000001
            if (ChkItalic.Checked) style |= FontStyle.Italic; //00000002
            //000000001 | 00000010 = 00000011 => bold + italic

            TextResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }

        //트리뷰 내용을 리스트뷰에 표시
        private void DisplayTreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                DisplayTreeToList(node);
            }
        }

        private void DisplayTreeToList(TreeNode node)
        {
            LsvDummy.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath }));
            foreach (TreeNode item in node.Nodes)
            {
                DisplayTreeToList();
            }
        }
        #endregion


    }
}
