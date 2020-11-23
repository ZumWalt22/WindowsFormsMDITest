using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMDITest
{
    public partial class ChildForm : Form
    {
        //親フォームインスタンス
        FormMDITest formMDITest;

        List<LineShape> relationFromLineShapeList = new List<LineShape>();

        List<LineShape> relationToLineShapeList = new List<LineShape>();

        public ChildForm(FormMDITest formMDITest)
        {
            InitializeComponent();

            this.formMDITest = formMDITest;
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// フォームがMove時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChildForm_Move(object sender, EventArgs e)
        {
            label1.Text = "X:" + this.Location.X + "Y:" + this.Location.Y;

            //関連リレーション座標も更新
            foreach (LineShape lineShape in relationFromLineShapeList) {
                lineShape.X1 = this.Location.X + this.Width / 2;
                lineShape.Y1 = this.Location.Y + this.Height / 2;
            }

            foreach (LineShape lineShape in relationToLineShapeList)
            {
                lineShape.X2 = this.Location.X + this.Width / 2;
                lineShape.Y2 = this.Location.Y + this.Height / 2;
            }

            formMDITest.updateDisp();
        }

        /// <summary>
        /// リレーションFromを追加
        /// </summary>
        public void addRelationFromLineShape(LineShape lineShape)
        {
            relationFromLineShapeList.Add(lineShape);
        }

        /// <summary>
        /// リレーションToを追加
        /// </summary>
        public void addRelationToLineShape(LineShape lineShape)
        {
            relationToLineShapeList.Add(lineShape);
        }
    }
}
