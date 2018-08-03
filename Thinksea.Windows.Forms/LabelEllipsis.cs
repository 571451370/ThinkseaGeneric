using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Thinksea.Windows.Forms
{
    /// <summary>
    /// һ������ʹ��ʡ�Ժ���������ı����ı���ʾ�ؼ���
    /// </summary>
	public class LabelEllipsis : Label
	{
        /// <summary>
        /// 
        /// </summary>
        [
        Browsable(false),
        ReadOnly(true),
        EditorBrowsable(EditorBrowsableState.Never),
        System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        ]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

		private string longText;
		private string shortText;

        /// <summary>
        /// ���� System.Windows.Forms.Control.Resize �¼���
        /// </summary>
        /// <param name="e">�����¼����ݵ� System.EventArgs��</param>
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
            this.FullText = FullText;
		}

		#region AutoEllipsis property

        /// <summary>
        /// ��ȡ�������ı���
        /// </summary>
        [DefaultValue(null)]
        [Description("�ڿؼ�����ʾ���ı�")]
        public virtual string FullText
		{
            get
            {
                return longText;
            }
            set
            {
                longText = value;
                shortText = Ellipsis.Compact(longText, this, AutoEllipsis);

                tooltip.SetToolTip(this, longText);
                base.Text = shortText;
            }
        }

		private EllipsisFormat _ellipsis;

        /// <summary>
        /// �Ƿ�ʹ��ʡ��ģʽ�����ı���
        /// </summary>
		[Category("Behavior")]
		[Description("�Ƿ�ʹ��ʡ��ģʽ�����ı���")]
		public new EllipsisFormat AutoEllipsis
		{
			get { return _ellipsis; }
			set
			{
				if (_ellipsis != value)
				{
					_ellipsis = value;
					// ellipsis type changed, recalculate ellipsis text
					this.FullText = FullText;
					OnAutoEllipsisChanged(EventArgs.Empty);
				}
			}
		}

        /// <summary>
        /// ���������ԡ�AutoEllipsis��֮���������¼���
        /// </summary>
        [Category("Property Changed")]
        [Description("���������ԡ�AutoEllipsis��֮���������¼���")]
		public event EventHandler AutoEllipsisChanged;

        /// <summary>
        /// ���� AutoEllipsisChanged �¼���
        /// </summary>
        /// <param name="e">�����¼����ݵ� System.EventArgs��</param>
        protected void OnAutoEllipsisChanged(EventArgs e)
		{
			if (AutoEllipsisChanged != null)
			{
				AutoEllipsisChanged(this, e);
			}
		}

		#endregion

		#region Tooltip

		ToolTip tooltip = new ToolTip();

		#endregion
	}
}
