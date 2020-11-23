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
    public partial class FormMDITest : Form
    {
        //線分情報登録コンテナ
        ShapeContainer shapeContainer;

        //MDIアクティブフォーム
        ChildForm activateForm;

        //MDIリレーションFromフォーム
        ChildForm relationFromForm;

        //MDIリレーションToフォーム
        ChildForm relationToForm;

        //MDIフォームインデックス
        int mdiFormIndex = 1;

        public FormMDITest()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MDIウインドウ追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MDIウインドウ追加
            addObject(new Point(100 + mdiFormIndex * 50, 100 + mdiFormIndex * 50));
        }

        /// <summary>
        /// MDIフォームリレーション追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRelationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.activateForm != null)
            {
                //MDIフォームがアクティブ時のみ実施
                relationFromForm = activateForm;

                this.Text = " is relataion mode ";
            }
        }

        /// <summary>
        /// LineShape選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lineShape_MouseClick(object sender, MouseEventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("線分が選択されました","ボタンアクション",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //----------------------

        //親フォームのMdiChildActivateイベントハンドラ
        private void ParentForm_MdiChildActivate(object sender, EventArgs e)
        {
            //アクティブMDIフォームのインスタンスを取得
            activateForm = (ChildForm)this.ActiveMdiChild;

            //MDIフォームリレーション追加
            if (this.relationFromForm != null && this.activateForm != null && relationFromForm != activateForm)
            {
                addRelation(relationFromForm, activateForm);
            }

            relationFromForm = null;
            this.Text = " is nomal mode ";

            this.Refresh();
        }

        /// <summary>
        /// オブジェクトを追加
        /// </summary>
        private void addObject(Point objectLocation)
        {
            //子フォームを作成
            ChildForm frm = new ChildForm(this);
            //親フォームを指定
            frm.MdiParent = this;
            
            //フォーム名設定
            frm.Text = "MDI Form" + mdiFormIndex;
            mdiFormIndex++;

            //フォームの初期表示位置を指定
            frm.Left = objectLocation.X;
            frm.Top = objectLocation.Y;
            frm.StartPosition = FormStartPosition.Manual;

            //子フォームを表示
            frm.Show();
        }

        /// <summary>
        /// リレーションを追加
        /// </summary>
        private LineShape addRelation(ChildForm relatinoFromForm, ChildForm relatinoToForm)
        {
            LineShape ls = new LineShape();
            ls.Name = "lineShape";

            //線分From座標を設定
            ls.X1 = relatinoFromForm.Location.X + relatinoFromForm.Width / 2;
            ls.Y1 = relatinoFromForm.Location.Y + relatinoFromForm.Height / 2;
            //線分To座標を設定
            ls.X2 = relatinoToForm.Location.X + relatinoToForm.Width / 2;
            ls.Y2 = relatinoToForm.Location.Y + relatinoToForm.Height / 2;

            //線分スタイルを定義
            ls.BorderColor = Color.Blue;
            ls.SelectionColor = Color.Red;
            ls.BorderWidth = 4;
            ls.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

            //アクション追加
            ls.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lineShape_MouseClick);

            //線分コンテナに追加
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { ls });

            //フォームにリレーションのインスタンスを設定
            relatinoFromForm.addRelationFromLineShape(ls);
            relatinoToForm.addRelationToLineShape(ls);

            return ls;
        }

        /// <summary>
        /// 画面全リフレッシュ
        /// MDIフォームから呼ばれる
        /// </summary>
        public void updateDisp()
        {
            this.Refresh();
        }
    }
}
