namespace Thinksea.Windows.Forms.MdiTabControl
{
    partial class TabPage
    {
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region �����������ɵĴ���

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(Tab_MouseDown);
            this.MouseEnter += new System.EventHandler(Tab_MouseEnter);
            this.MouseLeave += new System.EventHandler(Tab_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Tab_MouseMove);
        }

        #endregion
    }

}
