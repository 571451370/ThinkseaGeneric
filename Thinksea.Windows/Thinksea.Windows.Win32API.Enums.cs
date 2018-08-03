namespace Thinksea.Windows.Win32API
{
    /// <summary>
    /// ���崰�ڳߴ�Ͷ�λ�ı�־��
    /// </summary>
	[System.Flags]
	public enum FlagsSetWindowPos : uint
	{
        /// <summary>
        /// ά�ֵ�ǰ�ߴ磨���� Width �� Height ��������
        /// </summary>
		SWP_NOSIZE          = 0x0001,
        /// <summary>
        /// ά�ֵ�ǰλ�ã�����X��Y��������
        /// </summary>
		SWP_NOMOVE          = 0x0002,
        /// <summary>
        /// ά�ֵ�ǰZ�򣨺���hWndlnsertAfter��������
        /// </summary>
		SWP_NOZORDER        = 0x0004,
        /// <summary>
        /// ���ػ��ı�����ݡ���������������־���򲻷����κ��ػ������������ڿͻ����ͷǿͻ����������������͹����������κ����ڴ����ƶ���¶���ĸ����ڵ����в��֡���������������־��Ӧ�ó��������ȷ��ʹ������Ч�����ػ����ڵ��κβ��ֺ͸�������Ҫ�ػ��Ĳ��֡�
        /// </summary>
		SWP_NOREDRAW        = 0x0008,
        /// <summary>
        /// ������ڡ����δ���ñ�־���򴰿ڱ�����������õ�������߼����ڻ����߼���Ķ��������ݲ��� hWndlnsertAfter ���ã���
        /// </summary>
		SWP_NOACTIVATE      = 0x0010,
        /// <summary>
        /// �����ڷ��� WM_NCCALCSIZE ��Ϣ����ʹ���ڳߴ�û�иı�Ҳ�ᷢ�͸���Ϣ�����δָ�������־��ֻ���ڸı��˴��ڳߴ�ʱ�ŷ��� WM_NCCALCSIZE��
        /// </summary>
		SWP_FRAMECHANGED    = 0x0020,
        /// <summary>
        /// ��ʾ���ڡ�
        /// </summary>
		SWP_SHOWWINDOW      = 0x0040,
        /// <summary>
        /// ���ش��ڡ�
        /// </summary>
		SWP_HIDEWINDOW      = 0x0080,
        /// <summary>
        /// ����ͻ������������ݡ����δ���øñ�־���ͻ�������Ч���ݱ����沢���ڴ��ڳߴ���º��ض�λ�󿽱��ؿͻ�����
        /// </summary>
		SWP_NOCOPYBITS      = 0x0100,
        /// <summary>
        /// ���ı�z���е������ߴ��ڵ�λ�á�
        /// </summary>
		SWP_NOOWNERZORDER   = 0x0200, 
        /// <summary>
        /// ��ֹ���ڽ��� WM_WINDOWPOSCHANGING ��Ϣ��
        /// </summary>
		SWP_NOSENDCHANGING  = 0x0400,
        /// <summary>
        /// �ڴ�����Χ��һ���߿򣨶����ڴ����������У���
        /// </summary>
		SWP_DRAWFRAME       = 0x0020,
        /// <summary>
        /// �� SWP_NOOWNERZORDER ��־��ͬ��
        /// </summary>
		SWP_NOREPOSITION    = 0x0200,
        /// <summary>
        /// ��ֹ���� WM_SYNCPAINT ��Ϣ��
        /// </summary>
		SWP_DEFERERASE      = 0x2000,
        /// <summary>
        /// ������ý��̲�ӵ�д��ڣ�ϵͳ����ӵ�д��ڵ��̷߳���������ͷ�ֹ�����߳��������̴߳��������ʱ����������
        /// </summary>
		SWP_ASYNCWINDOWPOS  = 0x4000
	}

    //public enum ShowWindowStyles : uint
    //{
    //    SW_HIDE = 0,
    //    SW_SHOWNORMAL = 1,
    //    SW_NORMAL = 1,
    //    SW_SHOWMINIMIZED = 2,
    //    SW_SHOWMAXIMIZED = 3,
    //    SW_MAXIMIZE = 3,
    //    SW_SHOWNOACTIVATE = 4,
    //    SW_SHOW = 5,
    //    SW_MINIMIZE = 6,
    //    SW_SHOWMINNOACTIVE = 7,
    //    SW_SHOWNA = 8,
    //    SW_RESTORE = 9,
    //    SW_SHOWDEFAULT = 10,
    //    SW_FORCEMINIMIZE = 11,
    //    SW_MAX = 11
    //}

    /// <summary>
    /// Ԥ���� ShowWindow ��������
    /// </summary>
    public enum ShowWindowStyles : uint
	{
        /// <summary>
        /// ��WindowNT5.0����С�����ڣ���ʹӵ�д��ڵ��̱߳�����Ҳ����С�����ڴ������߳���С������ʱ��ʹ�����������
        /// </summary>
        SW_FORCEMINIMIZE = 0x0,
        /// <summary>
        /// ���ش��ڲ�������������
        /// </summary>
        SW_HIDE = 0x1,
        /// <summary>
        /// ���ָ���Ĵ��ڡ�
        /// </summary>
        SW_MAXIMIZE = 0x2,
        /// <summary>
        /// ��С��ָ���Ĵ��ڲ��Ҽ�����Z���е���һ�����㴰�ڡ�
        /// </summary>
        SW_MINIMIZE = 0x3,
        /// <summary>
        /// �����ʾ���ڡ����������С������󻯣���ϵͳ�����ڻָ���ԭ���ĳߴ��λ�á��ڻָ���С������ʱ��Ӧ�ó���Ӧ��ָ�������־��
        /// </summary>
        SW_RESTORE = 0x4,
        /// <summary>
        /// �ڴ���ԭ����λ����ԭ���ĳߴ缤�����ʾ���ڡ�
        /// </summary>
        SW_SHOW = 0x5,
        /// <summary>
        /// ������STARTUPINFO�ṹ��ָ����SW_FLAG��־�趨��ʾ״̬��STARTUPINFO �ṹ��������Ӧ�ó���ĳ��򴫵ݸ�CreateProcess�����ġ�
        /// </summary>
        SW_SHOWDEFAULT = 0x6,
        /// <summary>
        /// ����ڲ�������󻯡�
        /// </summary>
        SW_SHOWMAXIMIZED = 0x7,
        /// <summary>
        /// ����ڲ�������С����
        /// </summary>
        SW_SHOWMINIMIZED = 0x8,
        /// <summary>
        /// ������С�����������Ȼά�ּ���״̬��
        /// </summary>
        SW_SHOWMINNOACTIVE = 0x9,
        /// <summary>
        /// �Դ���ԭ����״̬��ʾ���ڡ��������Ȼά�ּ���״̬��
        /// </summary>
        SW_SHOWNA = 0xA,
        /// <summary>
        /// �Դ������һ�εĴ�С��״̬��ʾ���ڡ��������Ȼά�ּ���״̬��
        /// </summary>
        SW_SHOWNOACTIVATE = 0xB,
        /// <summary>
        /// �����ʾһ�����ڡ�������ڱ���С������󻯣�ϵͳ����ָ���ԭ���ĳߴ�ʹ�С��Ӧ�ó����ڵ�һ����ʾ���ڵ�ʱ��Ӧ��ָ���˱�־��
        /// </summary>
        SW_SHOWNORMAL = 0xC,
        /// <summary>
        /// ��һ�����ڻ�Ӧ�ó���Ҫ�ر�ʱ����һ���ź�
        /// </summary>
        WM_CLOSE = 0x10,
	}

    /// <summary>
    /// ���ڷ���塣
    /// </summary>
    public enum WindowStyles : uint
	{
        /// <summary>
        /// ����һ������Ĵ��ڡ�һ������Ĵ�����һ����������һ���߿���WS_TILED�����ͬ��
        /// </summary>
		WS_OVERLAPPED       = 0x00000000,
        /// <summary>
        /// ����һ������ʽ���ڡ��÷������WS_CHILD���ͬʱʹ�á�
        /// </summary>
		WS_POPUP            = 0x80000000,
        /// <summary>
        /// ����һ���Ӵ��ڡ�����������WS_POPUP�����á�
        /// </summary>
		WS_CHILD            = 0x40000000,
		WS_MINIMIZE         = 0x20000000,
        /// <summary>
        /// ����һ����ʼ״̬Ϊ�ɼ��Ĵ��ڡ�
        /// </summary>
		WS_VISIBLE          = 0x10000000,
        /// <summary>
        /// ����һ����ʼ״̬Ϊ��ֹ���Ӵ��ڡ�һ����ֹ״̬�Ĵ��ڲ��ܽ��������û���������Ϣ��
        /// </summary>
		WS_DISABLED         = 0x08000000,
        /// <summary>
        /// �ų��Ӵ���֮����������Ҳ���ǣ���һ���ض��Ĵ��ڽ��յ�WM_PAINT��Ϣʱ��WS_CLIPSIBLINGS ������в�������ų��ڻ�ͼ֮�⣬ֻ�ػ�ָ�����Ӵ��ڡ����δָ��WS_CLIPSIBLINGS��񣬲����Ӵ����ǲ���ģ������ػ��Ӵ��ڵĿͻ���ʱ���ͻ��ػ��ڽ����Ӵ��ڡ�
        /// </summary>
		WS_CLIPSIBLINGS     = 0x04000000,
        /// <summary>
        /// ���ڸ������ڻ�ͼʱ���ų��Ӵ��������ڴ���������ʱʹ��������
        /// </summary>
		WS_CLIPCHILDREN     = 0x02000000,
        /// <summary>
        /// ����һ����ʼ״̬Ϊ���״̬�Ĵ��ڡ�
        /// </summary>
		WS_MAXIMIZE         = 0x01000000,
        /// <summary>
        /// ����һ���б����Ĵ��ڣ�����WS_BODER��񣩡�
        /// </summary>
		WS_CAPTION          = 0x00C00000,
        /// <summary>
        /// ����һ�����߿�Ĵ��ڡ�
        /// </summary>
		WS_BORDER           = 0x00800000,
        /// <summary>
        /// ����һ�����Ի���߿���Ĵ��ڡ����ַ��Ĵ��ڲ��ܴ���������
        /// </summary>
		WS_DLGFRAME         = 0x00400000,
        /// <summary>
        /// ����һ���д�ֱ�������Ĵ��ڡ�
        /// </summary>
		WS_VSCROLL          = 0x00200000,
        /// <summary>
        /// ����һ����ˮƽ�������Ĵ��ڡ�
        /// </summary>
		WS_HSCROLL          = 0x00100000,
        /// <summary>
        /// ����һ���ڱ������ϴ��д��ڲ˵��Ĵ��ڣ�����ͬʱ�趨WS_CAPTION���
        /// </summary>
		WS_SYSMENU          = 0x00080000,
        /// <summary>
        /// ����һ�����пɵ��߿�Ĵ��ڣ���WS_SIZEBOX�����ͬ��
        /// </summary>
		WS_THICKFRAME       = 0x00040000,
        /// <summary>
        /// ָ��һ����Ƶĵ�һ�����ơ�����������ɵ�һ�����ƺ������Ŀ�����ɣ��Եڶ������ƿ�ʼÿ�����ƣ�����WS_GROUP���ÿ����ĵ�һ�����ƴ���WS_TABSTOP��񣬴Ӷ�ʹ�û�����������ƶ����û�������ʹ�ù�������ڵĿ��Ƽ�ı���̽��㡣
        /// </summary>
		WS_GROUP            = 0x00020000,
        /// <summary>
        /// ����һ�����ƣ�����������û�����Tab��ʱ���Ի�ü��̽��㡣����Tab����ʹ���̽���ת�Ƶ���һ����WS_TABSTOP���Ŀ��ơ�
        /// </summary>
		WS_TABSTOP          = 0x00010000,
		WS_MINIMIZEBOX      = 0x00020000,
        /// <summary>
        /// ����һ��������󻯰�ť�Ĵ��ڡ��÷������WS_EX_CONTEXTHELP���ͬʱ���֣�ͬʱ����ָ��WS_SYSMENU���
        /// </summary>
		WS_MAXIMIZEBOX      = 0x00010000,
        /// <summary>
        /// ����һ������Ĵ��ڡ�һ������Ĵ�����һ�������һ���߿���WS_OVERLAPPED�����ͬ��
        /// </summary>
		WS_TILED            = 0x00000000,
        /// <summary>
        /// ����һ����ʼ״̬Ϊ��С��״̬�Ĵ��ڡ���WS_MINIMIZE�����ͬ��
        /// </summary>
		WS_ICONIC           = 0x20000000,
        /// <summary>
        /// ����һ���ɵ��߿�Ĵ��ڣ���WS_THICKFRAME�����ͬ��
        /// </summary>
		WS_SIZEBOX          = 0x00040000,
        /// <summary>
        /// ����һ������WS_BORDER��WS_POPUP,WS_SYSMENU���Ĵ��ڣ�WS_CAPTION��WS_POPUPWINDOW����ͬʱ�趨����ʹ����ĳ���ɼ���
        /// </summary>
		WS_POPUPWINDOW      = 0x80880000,
        /// <summary>
        /// ����һ������WS_OVERLAPPED��WS_CAPTION��WS_SYSMENU WS_THICKFRAME��WS_MINIMIZEBOX��WS_MAXIMIZEBOX���Ĳ�����ڣ���WS_TILEDWINDOW�����ͬ��
        /// </summary>
		WS_OVERLAPPEDWINDOW = 0x00CF0000,
        /// <summary>
        /// ����һ������WS_OVERLAPPED��WS_CAPTION��WS_SYSMENU�� WS_THICKFRAME��WS_MINIMIZEBOX��WS_MAXIMIZEBOX���Ĳ�����ڡ���WS_OVERLAPPEDWINDOW�����ͬ��
        /// </summary>
		WS_TILEDWINDOW      = 0x00CF0000,
        /// <summary>
        /// ��WS_CHILD��ͬ��
        /// </summary>
		WS_CHILDWINDOW      = 0x40000000
	}

    /// <summary>
    /// ��չ�Ĵ��ڷ����
    /// </summary>
    public enum WindowExStyles
	{
        /// <summary>
        /// ָ��һ������˫�ر߽�Ĵ��ڣ�������dwStyle������ָ����WS_CAPTION����־ʱ�������Ծ��б���������ѡ���� 
        /// </summary>
		WS_EX_DLGMODALFRAME     = 0x00000001,
        /// <summary>
        /// ָ���������񴴽����Ӵ����ڱ����������ٵ�ʱ�򽫲��򸸴��ڷ���WM_PARENTNOTIFY��Ϣ�� 
        /// </summary>
		WS_EX_NOPARENTNOTIFY    = 0x00000004,
        /// <summary>
        /// ָ���������񴴽��Ĵ��ڱ��뱻�������зǶ��㴰�ڵ����棬��ʹ��������Ѿ������ڼ���״̬�������Ǳ����������档Ӧ�ó��������SetWindowsPos��Ա�����������ȥ��������ԡ�
        /// </summary>
		WS_EX_TOPMOST           = 0x00000008,
        /// <summary>
        /// ָ���ô���ʽ�����Ĵ��ڽ����Ϸ��ļ���
        /// </summary>
		WS_EX_ACCEPTFILES       = 0x00000010,
        /// <summary>
        /// ָ�����������񴴽��Ĵ�����͸���ġ�����ζ�ţ����������������κδ��ڶ����ᱻ������ڵ�ס���������񴴽��Ĵ���ֻ�е�������Ĵ��ڶ����¹��Ժ�Ž���WM_PAINT��Ϣ�� 
        /// </summary>
		WS_EX_TRANSPARENT       = 0x00000020,
        /// <summary>
        /// ����һ��MDI�Ӵ��ڡ�
        /// </summary>
		WS_EX_MDICHILD          = 0x00000040,
        /// <summary>
        /// ����һ�����ߴ��ڣ�Ŀ���Ǳ��������������������ߴ��ھ��б���������ͨ���ı�����Ҫ�̣����ڵı�������С������ʾ�ġ����ߴ��ڲ����������������û�����ALT+TABʱ���ֵĴ����С�
        /// </summary>
		WS_EX_TOOLWINDOW        = 0x00000080,
        /// <summary>
        /// ָ���˾���͹��߿�Ĵ��ڡ� 
        /// </summary>
		WS_EX_WINDOWEDGE        = 0x00000100,
        /// <summary>
        /// ָ�����ھ���3D��ۣ�����ζ�ţ��߿�����³��ı߽硣
        /// </summary>
		WS_EX_CLIENTEDGE        = 0x00000200,
        /// <summary>
        /// �ڴ��ڵı������а����ʺš����û������ʺ�ʱ����������״��Ϊ��ָ����ʺš�����û���󵥻�һ���Ӵ��ڣ��Ӵ��ڽ����յ�һ��WM_HELP��Ϣ��
        /// </summary>
		WS_EX_CONTEXTHELP       = 0x00000400,
        /// <summary>
        /// ���贰���Ҷ������ԡ����봰�����йء�
        /// </summary>
		WS_EX_RIGHT             = 0x00001000,
        /// <summary>
        /// ָ�����ھ�����������ԡ�����ȱʡֵ��
        /// </summary>
		WS_EX_LEFT              = 0x00000000,
        /// <summary>
        /// ���մ��ҵ����˳����ʾ�����ı���
        /// </summary>
		WS_EX_RTLREADING        = 0x00002000,
        /// <summary>
        /// ���մ����ҵķ�ʽ��ʾ�����ı�������ȱʡ��ʽ�� 
        /// </summary>
		WS_EX_LTRREADING        = 0x00000000,
        /// <summary>
        /// ����ֱ���������ڿͻ�������ߡ�
        /// </summary>
		WS_EX_LEFTSCROLLBAR     = 0x00004000,
        /// <summary>
        /// ����ֱ������������У����ڿͻ������ұߡ�����ȱʡ��ʽ�� 
        /// </summary>
		WS_EX_RIGHTSCROLLBAR    = 0x00000000,
        /// <summary>
        /// �����û���TAB���������ڵ��Ӵ��ڡ� 
        /// </summary>
		WS_EX_CONTROLPARENT     = 0x00010000,
        /// <summary>
        /// ����һ��������ά�߽�Ĵ��ڣ����ڲ������û�������
        /// </summary>
		WS_EX_STATICEDGE        = 0x00020000,
        /// <summary>
        /// �����ڿɼ�ʱ����һ�����㴰�ڷ��õ��������ϡ�
        /// </summary>
		WS_EX_APPWINDOW         = 0x00040000,
        /// <summary>
        /// �����WS_EX_CLIENTEDGE��WS_EX_WIND-OWEDGE���
        /// </summary>
		WS_EX_OVERLAPPEDWINDOW  = 0x00000300,
        /// <summary>
        /// �����WS_EX_WINDOWEDGE��WS_EX_TOPMOST��� 
        /// </summary>
		WS_EX_PALETTEWINDOW     = 0x00000188,
        /// <summary>
        /// ������һ�� �ֲ㴰�� ������ھ��� CS_OWNDC �� CS_CLASSDC����һ����class style �������ʽ����ʹ�á� ���ǣ�Windows 8 ֧���Ӵ��ڵ� WS_EX_LAYERED ��ʽ��֮ǰ�� Windows �汾���Զ�������֧�֡�
        /// </summary>
		WS_EX_LAYERED			= 0x00080000
	}

    public enum HitTest
	{
		HTERROR			= -2,
		HTTRANSPARENT   = -1,
		HTNOWHERE		= 0,
		HTCLIENT		= 1,
		HTCAPTION		= 2,
		HTSYSMENU		= 3,
		HTGROWBOX		= 4,
		HTSIZE			= 4,
		HTMENU			= 5,
		HTHSCROLL		= 6,
		HTVSCROLL		= 7,
		HTMINBUTTON		= 8,
		HTMAXBUTTON		= 9,
		HTLEFT			= 10,
		HTRIGHT			= 11,
		HTTOP			= 12,
		HTTOPLEFT		= 13,
		HTTOPRIGHT		= 14,
		HTBOTTOM		= 15,
		HTBOTTOMLEFT	= 16,
		HTBOTTOMRIGHT	= 17,
		HTBORDER		= 18,
		HTREDUCE		= 8,
		HTZOOM			= 9 ,
		HTSIZEFIRST		= 10,
		HTSIZELAST		= 17,
		HTOBJECT		= 19,
		HTCLOSE			= 20,
		HTHELP			= 21
	}

    /// <summary>
    /// ָ���������Ƿ��Ǵ��ڵķǹ������Ŀؼ��򲿼��� 
    /// </summary>
    public enum ScrollBars : uint
	{
        /// <summary>
        /// ��ʾ�����ش���ı�׼��ˮƽ��������
        /// </summary>
		SB_HORZ = 0,
        /// <summary>
        /// ��ʾ�����ش���ı�׼�Ĵ�ֱ��������
        /// </summary>
		SB_VERT = 1,
        /// <summary>
        /// ��ʾ�����ع��������ơ�����hWnd������ָ����������Ƶľ����
        /// </summary>
		SB_CTL = 2,
        /// <summary>
        /// ��ʾ�����ش���ı�׼��ˮƽ��ֱ��������
        /// </summary>
		SB_BOTH = 3
	}

    public enum GetWindowLongIndex : int
    {
        /// <summary>
        /// ��ô��ڷ��
        /// </summary>
        GWL_STYLE = -16,
        /// <summary>
        /// �����չ���շ��
        /// </summary>
        GWL_EXSTYLE = -20,
        /// <summary>
        /// ��ô��ڹ��̵ĵ�ַ��������ڹ��̵ĵ�ַ�ľ��������ʹ��CallWindowProc�������ô��ڹ��̡�
        /// </summary>
        GWL_WNDPROC = -4,
        /// <summary>
        /// ���Ӧ�������ľ����
        /// </summary>
        GWL_HINSTANCE = -6,
        /// <summary>
        /// ��������ڴ��ڣ���ø����ھ����
        /// </summary>
        GWL_HWNDPARENT = -8,
        /// <summary>
        /// ��ô��ڱ�ʶ��
        /// </summary>
        GWL_ID = -12,
        /// <summary>
        /// ����봰���йص�32λֵ��ÿһ�����ھ���һ���ɴ����ô��ڵ�Ӧ�ó���ʹ�õ�32λֵ��
        /// </summary>
        GWL_USERDATA = -21,
        /// <summary>
        /// ��hWnd������ʶ��һ���Ի���ʱ����öԻ�����̵ĵ�ַ����һ������Ի�����̵ĵ�ַ�ľ��������ʹ�ú���CallWindowProc�����öԻ�����̡�
        /// </summary>
        DWL_DLGPROC = 4,
        /// <summary>
        /// ��hWnd������ʶ��һ���Ի���ʱ������ڶԻ��������һ����Ϣ����ķ���ֵ��
        /// </summary>
        DWL_MSGRESULT = 0,
        /// <summary>
        /// ��hWnd������ʶ��һ���Ի���ʱ�����Ӧ�ó���˽�еĶ�����Ϣ������һ�������ָ�롣
        /// </summary>
        DWL_USER = 8,
    }

    /// <summary>
    /// ��������
    /// </summary>
    public enum HookType : int
    {
        /// <summary>
        /// ��װһ���ҹ��������,�Լ�����ϵͳ��Ϣ���е�������Ϣ���м�¼.����μ�JournalRecordProc�ҹ��������.
        /// </summary>
        WH_JOURNALRECORD = 0,
        /// <summary>
        /// ��װһ���ҹ��������,�Դ�ǰ��WH_JOURNALRECORD �ҹ�������̼�¼����Ϣ���м���.����μ� JournalPlaybackProc�ҹ��������
        /// </summary>
        WH_JOURNALPLAYBACK = 1,
        /// <summary>
        /// ��װһ���ҹ�������̶Ի�����Ϣ���м���. ����μ�KeyboardProc�ҹ��������
        /// </summary>
        WH_KEYBOARD = 2,
        /// <summary>
        /// ��װһ���ҹ�������̶Լ�������Ϣ���е���Ϣ���м���,����μ� GetMsgProc �ҹ��������
        /// </summary>
        WH_GETMESSAGE = 3,
        /// <summary>
        /// ��װһ���ҹ��������,��ϵͳ����Ϣ������Ŀ�괰�ڴ������֮ǰ,�Ը���Ϣ���м���,����μ�CallWndProc�ҹ��������
        /// </summary>
        WH_CALLWNDPROC = 4,
        /// <summary>
        /// ��װһ���ҹ��������,���ܶ�CBTӦ�ó������õ���Ϣ ,����μ� CBTProc �ҹ��������
        /// </summary>
        WH_CBT = 5,
        /// <summary>
        /// ��װһ���ҹ��������,�Լ����ɶԻ�����Ϣ�򡢲˵�������������е������¼���������Ϣ.����ҹ�������̶�ϵͳ������Ӧ�ó����������Ϣ�����м���.����μ� SysMsgProc�ҹ��������
        /// </summary>
        WH_SYSMSGFILTER = 6,
        /// <summary>
        /// ��װһ���ҹ��������,�������Ϣ���м���. ����μ� MouseProc�ҹ��������
        /// </summary>
        WH_MOUSE = 7,
        /// <summary>
        /// ������GetMessage �� PeekMessage ������Ϣ�����ֲ�ѯ����ꡢ������Ϣʱ
        /// </summary>
        WH_HARDWARE = 8,
        /// <summary>
        /// ��װһ���ҹ���������Ա�������ҹ�������̽��е���, ����μ�DebugProc�ҹ��������
        /// </summary>
        WH_DEBUG = 9,
        /// <summary>
        /// ��װһ���ҹ���������Խ��ܶ����Ӧ�ó������õ�֪ͨ, ����μ� ShellProc�ҹ��������
        /// </summary>
        WH_SHELL = 10,
        /// <summary>
        /// ��װһ���ҹ��������,�ùҹ�������̵�Ӧ�ó����ǰ̨�̼߳����������״̬ʱ������,���������ڿ���ʱ����ִ�е����ȼ�������
        /// </summary>
        WH_FOREGROUNDIDLE = 11,
        /// <summary>
        /// ��װһ���ҹ��������,�����ѱ�Ŀ�괰�ڴ�����̴�����˵���Ϣ���м���,����μ� CallWndRetProc �ҹ��������
        /// </summary>
        WH_CALLWNDPROCRET = 12,
        /// <summary>
        /// �������빳�ӡ�
        /// </summary>
        WH_KEYBOARD_LL = 13,
        /// <summary>
        /// �˹ҹ�ֻ����Windows NT�б���װ,�����Եײ����������¼����м���.����μ�LowLevelMouseProc�ҹ��������
        /// </summary>
        WH_MOUSE_LL = 14
    }

    /// <summary>
    /// WINDOWS ��Ϣ������ʶ����
    /// </summary>
    /// <remarks>
    /// Windows��һ��Ϣ��Message������ʽϵͳ��Windows��Ϣ�ṩ��Ӧ�ó�����Ӧ�ó���֮�䡢Ӧ�ó�����Windowsϵͳ֮�����ͨѶ���ֶΡ�Ӧ��
    /// ����Ҫʵ�ֵĹ�������Ϣ����������������Ϣ����Ӧ�ʹ�������ɡ�Windowsϵͳ����������Ϣ���У�һ����ϵͳ��Ϣ���У���һ����Ӧ�ó���
    /// ��Ϣ���С�����������������豸�� Windows��أ���һ���¼�����ʱ��Windows�Ƚ��������Ϣ����ϵͳ��Ϣ�����У�Ȼ���ٽ��������Ϣ��
    /// ������Ӧ��Ӧ�ó�������У�Ӧ�ó����е���Ϣѭ����������Ϣ�����м���ÿһ����Ϣ�����͸���Ӧ�Ĵ��ں����С�һ���¼��ķ��������ﴦ
    /// �����Ĵ��ں������뾭���������̡�ֵ��ע�������Ϣ�ķ������ԣ��������¼��ļ��뻺�����ǰ�������Ⱥ��Ŷ�(һЩϵͳ��Ϣ����)�����
    /// ʹ��һЩ�ⲿʵʱ�¼����ܵò�����ʱ�Ĵ��� 
    /// 
    /// ����Windows����������Ϣ�����ģ����Խ���ʱ����һ����Ϣ��õ��൱�ײ�Ĵ𰸡���һ��������˵��������⣬�򿪼��±����򣬸ó�����
    /// һ��File�˵�����ô�������и�Ӧ�ó����ʱ������û�������File�˵���New����ʱ�������������Windows ��������Ӧ�ó���������
    /// ����Windows����������֪�������Ӧ����������˵���Ǹ�Ӧ�ó���ȥ������Ȼ��������Windows�ͷ����˸�����WM_COMMAND����Ϣ��Ӧ��
    /// ���򣬸���Ϣ��������Ϣ����Ӧ�ó���"�û�������New�˵�"��Ӧ�ó����֪��һ��Ϣ֮�󣬲�ȡ��Ӧ�Ķ�������Ӧ����������̳�Ϊ��Ϣ��
    /// ��WindowsΪÿһ��Ӧ�ó���(ȷ�е�˵��ÿһ���߳�)ά������Ӧ����Ϣ���У�Ӧ�ó����������ǲ�ͣ�Ĵ�������Ϣ�����л�ȡ��Ϣ������
    /// ��Ϣ�ʹ�����Ϣ��ֱ��һ���ӵ�����WM_QUIT��ϢΪֹ���������ͨ������һ�ֽ�����Ϣѭ���ĳ���ṹ��ʵ�ֵġ� 
    /// 
    /// ��Ϣ��������Ϊһ����¼���ݸ�Ӧ�ó���ģ������¼�а�������Ϣ�������Լ�������Ϣ�����磬���ڵ����������������Ϣ��˵�������¼
    /// �а����˵������ʱ�����ꡣ�����¼���ͽ���TMsg������Windows��Ԫ�������������ģ� 
    /// type 
    /// TMsg = packed record 
    /// hwnd: HWND; 		//���ھ�� 
    /// message: UINT; 		//��Ϣ������ʶ�� 
    /// wParam: WPA R A M ; 	// 32λ��Ϣ���ض�������Ϣ 
    /// lParam: LPA R A M ; 	// 32λ��Ϣ���ض�������Ϣ 
    /// time: DWORD; 		//��Ϣ����ʱ��ʱ�� 
    /// pt: TPoint; 		//��Ϣ����ʱ�����λ�� 
    /// end; 
    /// 
    /// ��Ϣ����ʲô�� 
    /// �Ƿ����һ����Ϣ��¼�е���Ϣ��ϣ����һ�����������������ô��һ������Ľ��ͣ� 
    /// hwnd		32λ�Ĵ��ھ�������ڿ������κ����͵���Ļ������ΪWin32�ܹ�ά����������Ӷ���ľ��(���ڡ��Ի��򡢰�ť���༭���)�� 
    /// message		��������������Ϣ�ĳ���ֵ����Щ����������Windows��Ԫ��Ԥ����ĳ�����Ҳ�������Զ���ĳ����� 
    /// wParam		ͨ����һ������Ϣ�йصĳ���ֵ��Ҳ�����Ǵ��ڻ�ؼ��ľ���� 
    /// lParam		ͨ����һ��ָ���ڴ������ݵ�ָ�롣����WParm��lParam��Pointer����32λ�ģ���ˣ�����֮������໥ת���� 
    /// </remarks>
    public enum WindowsNumber : int
    {
        WM_NULL                       = 0x0000, // ʮ���ƣ�0 
        /// <summary>
        /// Ӧ�ó��򴴽�һ������
        /// </summary>
        WM_CREATE                     = 0x0001, // ʮ���ƣ�1 
        /// <summary>
        /// һ�����ڱ�����
        /// </summary>
        WM_DESTROY                    = 0x0002, // ʮ���ƣ�2 
        /// <summary>
        /// �ƶ�һ������
        /// </summary>
        WM_MOVE                       = 0x0003, // ʮ���ƣ�3 
        PAGE_READWRITE                = 0x0004,
        /// <summary>
        /// �ı�һ�����ڵĴ�С
        /// </summary>
        WM_SIZE                       = 0x0005, // ʮ���ƣ�5 
        /// <summary>
        /// һ�����ڱ������ʧȥ����״̬
        /// </summary>
        WM_ACTIVATE                   = 0x0006, // ʮ���ƣ�6 
        /// <summary>
        /// ��ý����
        /// </summary>
        WM_SETFOCUS                   = 0x0007, // ʮ���ƣ�7 
        /// <summary>
        /// ʧȥ����
        /// </summary>
        WM_KILLFOCUS                  = 0x0008, // ʮ���ƣ�8 
        /// <summary>
        /// �ı�enable״̬
        /// </summary>
        WM_ENABLE                     = 0x000a, // ʮ���ƣ�10 
        /// <summary>
        /// ���ô����Ƿ����ػ�
        /// </summary>
        WM_SETREDRAW                  = 0x000b, // ʮ���ƣ�11 
        /// <summary>
        /// Ӧ�ó����ʹ���Ϣ������һ�����ڵ��ı�
        /// </summary>
        WM_SETTEXT                    = 0x000c, // ʮ���ƣ�12 
        /// <summary>
        /// Ӧ�ó����ʹ���Ϣ�����ƶ�Ӧ���ڵ��ı���������
        /// </summary>
        WM_GETTEXT                    = 0x000d, // ʮ���ƣ�13 
        /// <summary>
        /// �õ���һ�������йص��ı��ĳ��ȣ����������ַ���
        /// </summary>
        WM_GETTEXTLENGTH              = 0x000e, // ʮ���ƣ�14 
        /// <summary>
        /// Ҫ��һ�������ػ��Լ�
        /// </summary>
        WM_PAINT                      = 0x000f, // ʮ���ƣ�15 
        /// <summary>
        /// ��һ�����ڻ�Ӧ�ó���Ҫ�ر�ʱ����һ���ź�
        /// </summary>
        WM_CLOSE                      = 0x0010, // ʮ���ƣ�16 
        /// <summary>
        /// ���û�ѡ������Ի��������Լ�����ExitWindows����
        /// </summary>
        WM_QUERYENDSESSION            = 0x0011, // ʮ���ƣ�17 
        /// <summary>
        /// ���������������л򵱳������postquitmessage����
        /// </summary>
        WM_QUIT                       = 0x0012, // ʮ���ƣ�18 
        /// <summary>
        /// ���û����ڻָ���ǰ�Ĵ�Сλ��ʱ���Ѵ���Ϣ���͸�ĳ��ͼ��
        /// </summary>
        WM_QUERYOPEN                  = 0x0013, // ʮ���ƣ�19 
        /// <summary>
        /// �����ڱ������뱻����ʱ�����ڴ��ڸı��Сʱ��
        /// </summary>
        WM_ERASEBKGND                 = 0x0014, // ʮ���ƣ�20 
        /// <summary>
        /// ��ϵͳ��ɫ�ı�ʱ�����ʹ���Ϣ�����ж�������
        /// </summary>
        WM_SYSCOLORCHANGE             = 0x0015, // ʮ���ƣ�21 
        /// <summary>
        /// ��ϵͳ���̷���WM_QUERYENDSESSION��Ϣ�󣬴���Ϣ���͸�Ӧ�ó���֪ͨ���Ի��Ƿ����
        /// </summary>
        WM_ENDSESSION                 = 0x0016, // ʮ���ƣ�22 
        /// <summary>
        /// �����ػ���ʾ�����Ƿ��ʹ���Ϣ���������
        /// </summary>
        WM_SHOWWINDOW                 = 0x0018, // ʮ���ƣ�24 
        /// <summary>
        /// 
        /// </summary>
        WM_CTLCOLOR                   = 0x0019, // ʮ���ƣ�25 
        WM_WININICHANGE               = 0x001a, // ʮ���ƣ�26 
		WM_SETTINGCHANGE              = 0x001A, // ʮ���ƣ�26 
        WM_DEVMODECHANGE              = 0x001b, // ʮ���ƣ�27 
        /// <summary>
        /// ������Ϣ��Ӧ�ó����ĸ������Ǽ���ģ��ĸ��ǷǼ����
        /// </summary>
        WM_ACTIVATEAPP                = 0x001c, // ʮ���ƣ�28 
        /// <summary>
        /// ��ϵͳ��������Դ��仯ʱ���ʹ���Ϣ�����ж�������
        /// </summary>
        WM_FONTCHANGE                 = 0x001d, // ʮ���ƣ�29 
        /// <summary>
        /// ��ϵͳ��ʱ��仯ʱ���ʹ���Ϣ�����ж�������
        /// </summary>
        WM_TIMECHANGE                 = 0x001e, // ʮ���ƣ�30 
        /// <summary>
        /// ���ʹ���Ϣ��ȡ��ĳ�����ڽ��е���̬��������
        /// </summary>
        WM_CANCELMODE                 = 0x001f, // ʮ���ƣ�31 
        /// <summary>
        /// ��������������ĳ���������ƶ����������û�б�����ʱ���ͷ���Ϣ��ĳ������
        /// </summary>
        WM_SETCURSOR                  = 0x0020, // ʮ���ƣ�32 
        /// <summary>
        /// �������ĳ���Ǽ���Ĵ����ж��û�����������ĳ�������ʹ���Ϣ����ǰ����
        /// </summary>
        WM_MOUSEACTIVATE              = 0x0021, // ʮ���ƣ�33 
        /// <summary>
        /// ���ʹ���Ϣ��MDI�Ӵ��ڵ��û�����˴��ڵı��������򵱴��ڱ�����ƶ����ı��С
        /// </summary>
        WM_CHILDACTIVATE              = 0x0022, // ʮ���ƣ�34 
        /// <summary>
        /// ����Ϣ�ɻ��ڼ������ѵ�������ͣ�ͨ��WH_JOURNALPALYBACK��hook���������û�������Ϣ
        /// </summary>
        WM_QUEUESYNC                  = 0x0023, // ʮ���ƣ�35 
        /// <summary>
        /// ����Ϣ���͸����ڵ�����Ҫ�ı��С��λ�ã�
        /// </summary>
        WM_GETMINMAXINFO              = 0x0024, // ʮ���ƣ�36 
        /// <summary>
        /// ���͸���С�����ڵ���ͼ�꽫Ҫ���ػ�
        /// </summary>
        WM_PAINTICON                  = 0x0026, // ʮ���ƣ�38 
        /// <summary>
        /// ����Ϣ���͸�ĳ����С�����ڣ��������ڻ�ͼ��ǰ���ı������뱻�ػ�
        /// </summary>
        WM_ICONERASEBKGND             = 0x0027, // ʮ���ƣ�39 
        /// <summary>
        /// ���ʹ���Ϣ��һ���Ի������ȥ���Ľ���λ��
        /// </summary>
        WM_NEXTDLGCTL                 = 0x0028, // ʮ���ƣ�40 
        /// <summary>
        /// ÿ����ӡ�����ж����ӻ����һ����ҵʱ��������Ϣ
        /// </summary>
        WM_SPOOLERSTATUS              = 0x002a, // ʮ���ƣ�42 
        /// <summary>
        /// ��button��combobox��listbox��menu�Ŀ�����۸ı�ʱ����,����Ϣ����Щ�ռ���������
        /// </summary>
        WM_DRAWITEM                   = 0x002b, // ʮ���ƣ�43 
        /// <summary>
        /// ��button, combo box, list box, list view control, or menu item ������ʱ,���ʹ���Ϣ���ؼ���������
        /// </summary>
        WM_MEASUREITEM                = 0x002c, // ʮ���ƣ�44 
        /// <summary>
        /// ��the list box �� combo box ������ �� �� ĳЩ�ɾ��ͨ��LB_DELETESTRING, LB_RESETCONTENT, CB_DELETESTRING, or CB_RESETCONTENT ��Ϣ
        /// </summary>
        WM_DELETEITEM                 = 0x002d, // ʮ���ƣ�45 
        /// <summary>
        /// ����Ϣ��һ��LBS_WANTKEYBOARDINPUT���ķ�������������������ӦWM_KEYDOWN��Ϣ
        /// </summary>
        WM_VKEYTOITEM                 = 0x002e, // ʮ���ƣ�46 
        /// <summary>
        /// ����Ϣ��һ��LBS_WANTKEYBOARDINPUT�����б���͸���������������ӦWM_CHAR��Ϣ 
        /// </summary>
        WM_CHARTOITEM                 = 0x002f, // ʮ���ƣ�47 
        /// <summary>
        /// �������ı�ʱ�����ʹ���Ϣ�õ��ؼ�Ҫ�õ���ɫ
        /// </summary>
        WM_SETFONT                    = 0x0030, // ʮ���ƣ�48 
        /// <summary>
        /// Ӧ�ó����ʹ���Ϣ�õ���ǰ�ؼ������ı�������
        /// </summary>
        WM_GETFONT                    = 0x0031, // ʮ���ƣ�49 
        /// <summary>
        /// Ӧ�ó����ʹ���Ϣ��һ��������һ���ȼ������
        /// </summary>
        WM_SETHOTKEY                  = 0x0032, // ʮ���ƣ�50 
        /// <summary>
        /// Ӧ�ó����ʹ���Ϣ���ж��ȼ���ĳ�������Ƿ��й���
        /// </summary>
        WM_GETHOTKEY                  = 0x0033, // ʮ���ƣ�51 
        /// <summary>
        /// ����Ϣ���͸���С�����ڣ����˴��ڽ�Ҫ���ϷŶ���������û�ж���ͼ�꣬Ӧ�ó����ܷ���һ��ͼ�����ľ�������û��Ϸ�ͼ��ʱϵͳ��ʾ���ͼ�����
        /// </summary>
        WM_QUERYDRAGICON              = 0x0037, // ʮ���ƣ�55 
        /// <summary>
        /// ���ʹ���Ϣ���ж�combobox��listbox�����ӵ�������λ��
        /// </summary>
        WM_COMPAREITEM                = 0x0039, // ʮ���ƣ�57 
        WM_GETOBJECT                  = 0x003d, // ʮ���ƣ�61 
        /// <summary>
        /// ��ʾ�ڴ��Ѿ�������
        /// </summary>
        WM_COMPACTING                 = 0x0041, // ʮ���ƣ�65 
        WM_COMMNOTIFY                 = 0x0044, // ʮ���ƣ�68 
        /// <summary>
        /// ���ʹ���Ϣ���Ǹ����ڵĴ�С��λ�ý�Ҫ���ı�ʱ��������setwindowpos�������������ڹ�����
        /// </summary>
        WM_WINDOWPOSCHANGING          = 0x0046, // ʮ���ƣ�70 
        /// <summary>
        /// ���ʹ���Ϣ���Ǹ����ڵĴ�С��λ���Ѿ����ı�ʱ��������setwindowpos�������������ڹ�����
        /// </summary>
        WM_WINDOWPOSCHANGED           = 0x0047, // ʮ���ƣ�71 
        /// <summary>
        /// ��������16λ��windows����ϵͳ��Ҫ������ͣ״̬ʱ���ʹ���Ϣ
        /// </summary>
        WM_POWER                      = 0x0048, // ʮ���ƣ�72 
        /// <summary>
        /// ��һ��Ӧ�ó��򴫵����ݸ���һ��Ӧ�ó���ʱ���ʹ���Ϣ
        /// </summary>
        WM_COPYDATA                   = 0x004a, // ʮ���ƣ�74 
        /// <summary>
        /// ��ĳ���û�ȡ��������־����״̬���ύ����Ϣ������
        /// </summary>
        WM_CANCELJOURNAL              = 0x004b, // ʮ���ƣ�75 
        /// <summary>
        /// ��ĳ���ؼ���ĳ���¼��Ѿ�����������ؼ���Ҫ�õ�һЩ��Ϣʱ�����ʹ���Ϣ�����ĸ�����
        /// </summary>
        WM_NOTIFY                     = 0x004e, // ʮ���ƣ�78 
        /// <summary>
        /// ���û�ѡ��ĳ���������ԣ����������Ե��ȼ��ı�
        /// </summary>
        WM_INPUTLANGCHANGEREQUEST     = 0x0050, // ʮ���ƣ�80 
        /// <summary>
        /// ��ƽ̨�ֳ��Ѿ����ı���ʹ���Ϣ����Ӱ����������
        /// </summary>
        WM_INPUTLANGCHANGE            = 0x0051, // ʮ���ƣ�81 
        /// <summary>
        /// �������Ѿ���ʼ��windows��������ʱ���ʹ���Ϣ��Ӧ�ó���
        /// </summary>
        WM_TCARD                      = 0x0052, // ʮ���ƣ�82 
        /// <summary>
        /// ����Ϣ��ʾ�û�������F1�����ĳ���˵��Ǽ���ģ��ͷ��ʹ���Ϣ���˴��ڹ����Ĳ˵�������ͷ��͸��н���Ĵ��ڣ������ǰ��û�н��㣬�ͰѴ���Ϣ���͸���ǰ����Ĵ���
        /// </summary>
        WM_HELP                       = 0x0053, // ʮ���ƣ�83 
        /// <summary>
        /// ���û��Ѿ�������˳����ʹ���Ϣ�����еĴ��ڣ����û�������˳�ʱϵͳ�����û��ľ���������Ϣ�����û���������ʱϵͳ���Ϸ��ʹ���Ϣ
        /// </summary>
        WM_USERCHANGED                = 0x0054, // ʮ���ƣ�84 
        /// <summary>
        /// ���ÿؼ����Զ���ؼ������ǵĸ�����ͨ������Ϣ���жϿؼ���ʹ��ANSI����UNICODE�ṹ ��WM_NOTIFY��Ϣ��ʹ�ô˿ؼ���ʹĳ���ؼ������ĸ��ؼ�֮������໥ͨ��
        /// </summary>
        WM_NOTIFYFORMAT               = 0x0055, // ʮ���ƣ�85 
        /// <summary>
        /// ���û�ĳ�������е����һ���Ҽ��ͷ��ʹ���Ϣ���������
        /// </summary>
        WM_CONTEXTMENU                = 0x007b, // ʮ���ƣ�123 
        /// <summary>
        /// ������SETWINDOWLONG������Ҫ�ı�һ������ ���ڵķ��ʱ���ʹ���Ϣ���Ǹ�����
        /// </summary>
        WM_STYLECHANGING              = 0x007c, // ʮ���ƣ�124 
        /// <summary>
        /// ������SETWINDOWLONG����һ������ ���ڵķ����ʹ���Ϣ���Ǹ�����
        /// </summary>
        WM_STYLECHANGED               = 0x007d, // ʮ���ƣ�125 
        /// <summary>
        /// ����ʾ���ķֱ��ʸı���ʹ���Ϣ�����еĴ���
        /// </summary>
        WM_DISPLAYCHANGE              = 0x007e, // ʮ���ƣ�126 
        /// <summary>
        /// ����Ϣ���͸�ĳ��������������ĳ�������й����Ĵ�ͼ���Сͼ��ľ��
        /// </summary>
        WM_GETICON                    = 0x007f, // ʮ���ƣ�127 
        /// <summary>
        /// �����ʹ���Ϣ��һ���µĴ�ͼ���Сͼ����ĳ�����ڹ���
        /// </summary>
        WM_SETICON                    = 0x0080, // ʮ���ƣ�128 
        /// <summary>
        /// ��ĳ�����ڵ�һ�α�����ʱ������Ϣ��WM_CREATE��Ϣ����ǰ����
        /// </summary>
        WM_NCCREATE                   = 0x0081, // ʮ���ƣ�129 
        /// <summary>
        /// ����Ϣ֪ͨĳ�����ڣ��ǿͻ�����������
        /// </summary>
        WM_NCDESTROY                  = 0x0082, // ʮ���ƣ�130 
        /// <summary>
        /// ��ĳ�����ڵĿͻ�������뱻����ʱ���ʹ���Ϣ
        /// </summary>
        WM_NCCALCSIZE                 = 0x0083, // ʮ���ƣ�131 
        /// <summary>
        /// �ƶ���꣬��ס���ͷ����ʱ����
        /// </summary>
        WM_NCHITTEST                  = 0x0084, // ʮ���ƣ�132 
        /// <summary>
        /// �����ʹ���Ϣ��ĳ�����ڵ��������ڣ��Ŀ�ܱ��뱻����ʱ
        /// </summary>
        WM_NCPAINT                    = 0x0085, // ʮ���ƣ�133 
        /// <summary>
        /// ����Ϣ���͸�ĳ������ �������ķǿͻ�����Ҫ���ı�����ʾ�Ǽ���ǷǼ���״̬
        /// </summary>
        WM_NCACTIVATE                 = 0x0086, // ʮ���ƣ�134 
        /// <summary>
        /// ���ʹ���Ϣ��ĳ����Ի����������Ŀؼ���widdows���Ʒ�λ����TAB��ʹ�������˿ؼ�ͨ����ӦWM_GETDLGCODE��Ϣ��Ӧ�ó�����԰�������һ�����������ؼ����ܴ�����
        /// </summary>
        WM_GETDLGCODE                 = 0x0087, // ʮ���ƣ�135 
        WM_SYNCPAINT                  = 0x0088, // ʮ���ƣ�136 
        /// <summary>
        /// �������һ�����ڵķǿͻ������ƶ�ʱ���ʹ���Ϣ��������� //�ǿͻ���Ϊ������ı����������ı߿���
        /// </summary>
        WM_NCMOUSEMOVE                = 0x00a0, // ʮ���ƣ�160 
        /// <summary>
        /// �������һ�����ڵķǿͻ���ͬʱ����������ʱ�ύ����Ϣ
        /// </summary>
        WM_NCLBUTTONDOWN              = 0x00a1, // ʮ���ƣ�161 
        /// <summary>
        /// ���û��ͷ�������ͬʱ���ĳ�������ڷǿͻ���ʮ���ʹ���Ϣ
        /// </summary>
        WM_NCLBUTTONUP                = 0x00a2, // ʮ���ƣ�162 
        /// <summary>
        /// ���û�˫��������ͬʱ���ĳ�������ڷǿͻ���ʮ���ʹ���Ϣ
        /// </summary>
        WM_NCLBUTTONDBLCLK            = 0x00a3, // ʮ���ƣ�163 
        /// <summary>
        /// ���û���������Ҽ�ͬʱ������ڴ��ڵķǿͻ���ʱ���ʹ���Ϣ
        /// </summary>
        WM_NCRBUTTONDOWN              = 0x00a4, // ʮ���ƣ�164 
        /// <summary>
        /// ���û��ͷ�����Ҽ�ͬʱ������ڴ��ڵķǿͻ���ʱ���ʹ���Ϣ
        /// </summary>
        WM_NCRBUTTONUP                = 0x00a5, // ʮ���ƣ�165 
        /// <summary>
        /// ���û�˫������Ҽ�ͬʱ���ĳ�������ڷǿͻ���ʮ���ʹ���Ϣ
        /// </summary>
        WM_NCRBUTTONDBLCLK            = 0x00a6, // ʮ���ƣ�166 
        /// <summary>
        /// ���û���������м�ͬʱ������ڴ��ڵķǿͻ���ʱ���ʹ���Ϣ
        /// </summary>
        WM_NCMBUTTONDOWN              = 0x00a7, // ʮ���ƣ�167 
        /// <summary>
        /// ���û��ͷ�����м�ͬʱ������ڴ��ڵķǿͻ���ʱ���ʹ���Ϣ
        /// </summary>
        WM_NCMBUTTONUP                = 0x00a8, // ʮ���ƣ�168 
        /// <summary>
        /// ���û�˫������м�ͬʱ������ڴ��ڵķǿͻ���ʱ���ʹ���Ϣ
        /// </summary>
        WM_NCMBUTTONDBLCLK            = 0x00a9, // ʮ���ƣ�169 
        WM_NCXBUTTONDOWN              = 0x00ab, // ʮ���ƣ�171 
        WM_NCXBUTTONUP                = 0x00ac, // ʮ���ƣ�172 
        WM_NCXBUTTONDBLCLK            = 0x00ad, // ʮ���ƣ�173 
        WM_INPUT                      = 0x00ff, // ʮ���ƣ�255 
        /// <summary>
        /// ����һ����
        /// </summary>
        WM_KEYDOWN                    = 0x0100, // ʮ���ƣ�256 
        WM_KEYFIRST                   = 0x0100, // ʮ���ƣ�256 
        /// <summary>
        /// �ͷ�һ����
        /// </summary>
        WM_KEYUP                      = 0x0101, // ʮ���ƣ�257 
        /// <summary>
        /// ����ĳ�������ѷ���WM_KEYDOWN�� WM_KEYUP��Ϣ
        /// </summary>
        WM_CHAR                       = 0x0102, // ʮ���ƣ�258 
        /// <summary>
        /// ����translatemessage��������WM_KEYUP��Ϣʱ���ʹ���Ϣ��ӵ�н���Ĵ���
        /// </summary>
        WM_DEADCHAR                   = 0x0103, // ʮ���ƣ�259 
        STILL_ACTIVE                  = 0x0103,
        /// <summary>
        /// ���û���סALT��ͬʱ����������ʱ�ύ����Ϣ��ӵ�н���Ĵ���
        /// </summary>
        WM_SYSKEYDOWN                 = 0x0104, // ʮ���ƣ�260 
        /// <summary>
        /// ���û��ͷ�һ����ͬʱALT ��������ʱ�ύ����Ϣ��ӵ�н���Ĵ���
        /// </summary>
        WM_SYSKEYUP                   = 0x0105, // ʮ���ƣ�261 
        /// <summary>
        /// ��WM_SYSKEYDOWN��Ϣ��TRANSLATEMESSAGE����������ύ����Ϣ��ӵ�н���Ĵ���
        /// </summary>
        WM_SYSCHAR                    = 0x0106, // ʮ���ƣ�262 
        /// <summary>
        /// ��WM_SYSKEYDOWN��Ϣ��TRANSLATEMESSAGE����������ʹ���Ϣ��ӵ�н���Ĵ���
        /// </summary>
        WM_SYSDEADCHAR                = 0x0107, // ʮ���ƣ�263 
        WM_KEYLAST                    = 0x0108, // ʮ���ƣ�264 
        WM_WNT_CONVERTREQUESTEX       = 0x0109, // ʮ���ƣ�265 
        WM_CONVERTREQUEST             = 0x010a, // ʮ���ƣ�266 
        WM_CONVERTRESULT              = 0x010b, // ʮ���ƣ�267 
        WM_INTERIM                    = 0x010c, // ʮ���ƣ�268 
        WM_IME_STARTCOMPOSITION       = 0x010d, // ʮ���ƣ�269 
        WM_IME_ENDCOMPOSITION         = 0x010e, // ʮ���ƣ�270 
        WM_IME_COMPOSITION            = 0x010f, // ʮ���ƣ�271 
        WM_IME_KEYLAST                = 0x010f, // ʮ���ƣ�271 
        /// <summary>
        /// ��һ���Ի��������ʾǰ���ʹ���Ϣ������ͨ���ô���Ϣ��ʼ���ؼ���ִ����������
        /// </summary>
        WM_INITDIALOG                 = 0x0110, // ʮ���ƣ�272 
        /// <summary>
        /// ���û�ѡ��һ���˵��������ĳ���ؼ�����һ����Ϣ�����ĸ����ڣ�һ����ݼ�������
        /// </summary>
        WM_COMMAND                    = 0x0111, // ʮ���ƣ�273 
        /// <summary>
        /// ���û�ѡ�񴰿ڲ˵���һ��������û�ѡ����󻯻���С��ʱ�Ǹ����ڻ��յ�����Ϣ
        /// </summary>
        WM_SYSCOMMAND                 = 0x0112, // ʮ���ƣ�274 
        /// <summary>
        /// �����˶�ʱ���¼�
        /// </summary>
        WM_TIMER                      = 0x0113, // ʮ���ƣ�275 
        /// <summary>
        /// ��һ�����ڱ�׼ˮƽ����������һ�������¼�ʱ���ʹ���Ϣ���Ǹ����ڣ�Ҳ���͸�ӵ�����Ŀؼ�
        /// </summary>
        WM_HSCROLL                    = 0x0114, // ʮ���ƣ�276 
        /// <summary>
        /// ��һ�����ڱ�׼��ֱ����������һ�������¼�ʱ���ʹ���Ϣ���Ǹ�����Ҳ�����͸�ӵ�����Ŀؼ�
        /// </summary>
        WM_VSCROLL                    = 0x0115, // ʮ���ƣ�277 
        /// <summary>
        /// ��һ���˵���Ҫ������ʱ���ʹ���Ϣ�����������û��˵����е�ĳ�����ĳ���˵������������������ʾǰ���Ĳ˵�
        /// </summary>
        WM_INITMENU                   = 0x0116, // ʮ���ƣ�278 
        /// <summary>
        /// ��һ�������˵����Ӳ˵���Ҫ������ʱ���ʹ���Ϣ�����������������ʾǰ���Ĳ˵�������Ҫ�ı�ȫ��
        /// </summary>
        WM_INITMENUPOPUP              = 0x0117, // ʮ���ƣ�279 
        /// <summary>
        /// ���û�ѡ��һ���˵���ʱ���ʹ���Ϣ���˵��������ߣ�һ���Ǵ��ڣ�
        /// </summary>
        WM_MENUSELECT                 = 0x011f, // ʮ���ƣ�287 
        /// <summary>
        /// ���˵��ѱ������û�������ĳ��������ͬ�ڼ��ټ��������ʹ���Ϣ���˵���������
        /// </summary>
        WM_MENUCHAR                   = 0x0120, // ʮ���ƣ�288 
        /// <summary>
        /// ��һ��ģ̬�Ի����˵��������״̬ʱ���ʹ���Ϣ�����������ߣ�һ��ģ̬�Ի����˵��������״̬�����ڴ�����һ��������ǰ����Ϣ��û����Ϣ�����ж��еȴ�
        /// </summary>
        WM_ENTERIDLE                  = 0x0121, // ʮ���ƣ�289 
        WM_MENURBUTTONUP              = 0x0122, // ʮ���ƣ�290 
        WM_MENUDRAG                   = 0x0123, // ʮ���ƣ�291 
        WM_MENUGETOBJECT              = 0x0124, // ʮ���ƣ�292 
        WM_UNINITMENUPOPUP            = 0x0125, // ʮ���ƣ�293 
        WM_MENUCOMMAND                = 0x0126, // ʮ���ƣ�294 
        WM_CHANGEUISTATE              = 0x0127, // ʮ���ƣ�295 
        WM_UPDATEUISTATE              = 0x0128, // ʮ���ƣ�296 
        WM_QUERYUISTATE               = 0x0129, // ʮ���ƣ�297 
        /// <summary>
        /// ��windows������Ϣ��ǰ���ʹ���Ϣ����Ϣ��������ߴ��ڣ�ͨ����Ӧ������Ϣ�������ߴ��ڿ���ͨ��ʹ�ø����������ʾ�豸�ľ����������Ϣ����ı��ͱ�����ɫ
        /// </summary>
        WM_CTLCOLORMSGBOX             = 0x0132, // ʮ���ƣ�306 
        /// <summary>
        /// ��һ���༭�Ϳؼ���Ҫ������ʱ���ʹ���Ϣ�����ĸ����ڣ�ͨ����Ӧ������Ϣ�������ߴ��ڿ���ͨ��ʹ�ø����������ʾ�豸�ľ�������ñ༭����ı��ͱ�����ɫ
        /// </summary>
        WM_CTLCOLOREDIT               = 0x0133, // ʮ���ƣ�307 
        /// <summary>
        /// ��һ���б��ؼ���Ҫ������ǰ���ʹ���Ϣ�����ĸ����ڣ�ͨ����Ӧ������Ϣ�������ߴ��ڿ���ͨ��ʹ�ø����������ʾ�豸�ľ���������б����ı��ͱ�����ɫ
        /// </summary>
        WM_CTLCOLORLISTBOX            = 0x0134, // ʮ���ƣ�308 
        /// <summary>
        /// ��һ����ť�ؼ���Ҫ������ʱ���ʹ���Ϣ�����ĸ����ڣ�ͨ����Ӧ������Ϣ�������ߴ��ڿ���ͨ��ʹ�ø����������ʾ�豸�ľ�������ð�Ŧ���ı��ͱ�����ɫ
        /// </summary>
        WM_CTLCOLORBTN                = 0x0135, // ʮ���ƣ�309 
        /// <summary>
        /// ��һ���Ի���ؼ���Ҫ������ǰ���ʹ���Ϣ�����ĸ����ڣ�ͨ����Ӧ������Ϣ�������ߴ��ڿ���ͨ��ʹ�ø����������ʾ�豸�ľ�������öԻ�����ı�������ɫ
        /// </summary>
        WM_CTLCOLORDLG                = 0x0136, // ʮ���ƣ�310 
        /// <summary>
        /// ��һ���������ؼ���Ҫ������ʱ���ʹ���Ϣ�����ĸ����ڣ�ͨ����Ӧ������Ϣ�������ߴ��ڿ���ͨ��ʹ�ø����������ʾ�豸�ľ�������ù������ı�����ɫ
        /// </summary>
        WM_CTLCOLORSCROLLBAR          = 0x0137, // ʮ���ƣ�311 
        /// <summary>
        /// ��һ����̬�ؼ���Ҫ������ʱ���ʹ���Ϣ�����ĸ����ڣ�ͨ����Ӧ������Ϣ�������ߴ��ڿ���ͨ��ʹ�ø����������ʾ�豸�ľ�������þ�̬�ؼ����ı��ͱ�����ɫ
        /// </summary>
        WM_CTLCOLORSTATIC             = 0x0138, // ʮ���ƣ�312 
        WM_MOUSEFIRST                 = 0x0200, // ʮ���ƣ�512 
        /// <summary>
        /// �ƶ����
        /// </summary>
        WM_MOUSEMOVE                  = 0x0200, // ʮ���ƣ�512 
        /// <summary>
        /// ����������
        /// </summary>
        WM_LBUTTONDOWN                = 0x0201, // ʮ���ƣ�513 
        /// <summary>
        /// �ͷ�������
        /// </summary>
        WM_LBUTTONUP                  = 0x0202, // ʮ���ƣ�514 
        /// <summary>
        /// ˫��������
        /// </summary>
        WM_LBUTTONDBLCLK              = 0x0203, // ʮ���ƣ�515 
        /// <summary>
        /// ��������Ҽ�
        /// </summary>
        WM_RBUTTONDOWN                = 0x0204, // ʮ���ƣ�516 
        /// <summary>
        /// �ͷ�����Ҽ�
        /// </summary>
        WM_RBUTTONUP                  = 0x0205, // ʮ���ƣ�517 
        /// <summary>
        /// ˫������Ҽ�
        /// </summary>
        WM_RBUTTONDBLCLK              = 0x0206, // ʮ���ƣ�518 
        /// <summary>
        /// ��������м�
        /// </summary>
        WM_MBUTTONDOWN                = 0x0207, // ʮ���ƣ�519 
        /// <summary>
        /// �ͷ�����м�
        /// </summary>
        WM_MBUTTONUP                  = 0x0208, // ʮ���ƣ�520 
        /// <summary>
        /// ˫������м�
        /// </summary>
        WM_MBUTTONDBLCLK              = 0x0209, // ʮ���ƣ�521 
        WM_MOUSELAST                  = 0x0209, // ʮ���ƣ�521 
        /// <summary>
        /// ���������ת��ʱ���ʹ���Ϣ����ǰ�н���Ŀؼ�
        /// </summary>
        WM_MOUSEWHEEL                 = 0x020a, // ʮ���ƣ�522 
        WM_XBUTTONDOWN                = 0x020b, // ʮ���ƣ�523 
        WM_XBUTTONUP                  = 0x020c, // ʮ���ƣ�524 
        WM_XBUTTONDBLCLK              = 0x020d, // ʮ���ƣ�525 
        /// <summary>
        /// ��MDI�Ӵ��ڱ����������٣����û�����һ��������������Ӵ�����ʱ���ʹ���Ϣ�����ĸ�����
        /// </summary>
        WM_PARENTNOTIFY               = 0x0210, // ʮ���ƣ�528 
        /// <summary>
        /// ���ʹ���Ϣ֪ͨӦ�ó����������that�Ѿ������˲˵�ѭ��ģʽ
        /// </summary>
        WM_ENTERMENULOOP              = 0x0211, // ʮ���ƣ�529 
        /// <summary>
        /// ���ʹ���Ϣ֪ͨӦ�ó����������that���˳��˲˵�ѭ��ģʽ
        /// </summary>
        WM_EXITMENULOOP               = 0x0212, // ʮ���ƣ�530 
        WM_NEXTMENU                   = 0x0213, // ʮ���ƣ�531 
        /// <summary>
        /// ���û����ڵ������ڴ�Сʱ���ʹ���Ϣ�����ڣ�ͨ������ϢӦ�ó�����Լ��Ӵ��ڴ�С��λ��Ҳ�����޸�����
        /// </summary>
        WM_SIZING                     = 0x0214, // ʮ���ƣ�532 
        /// <summary>
        /// ���ʹ���Ϣ�����ڵ���ʧȥ��������ʱ
        /// </summary>
        WM_CAPTURECHANGED             = 0x0215, // ʮ���ƣ�533 
        /// <summary>
        /// ���û����ƶ�����ʱ���ʹ���Ϣ��ͨ������ϢӦ�ó�����Լ��Ӵ��ڴ�С��λ��Ҳ�����޸�����
        /// </summary>
        WM_MOVING                     = 0x0216, // ʮ���ƣ�534 
        /// <summary>
        /// ����Ϣ���͸�Ӧ�ó�����֪ͨ���йص�Դ�����¼�
        /// </summary>
        WM_POWERBROADCAST             = 0x0218, // ʮ���ƣ�536 
        /// <summary>
        /// ���豸��Ӳ�����øı�ʱ���ʹ���Ϣ��Ӧ�ó�����豸��������
        /// </summary>
        WM_DEVICECHANGE               = 0x0219, // ʮ���ƣ�537 
        /// <summary>
        /// Ӧ�ó����ʹ���Ϣ�����ĵ��Ŀͻ�����������һ��MDI �Ӵ���
        /// </summary>
        WM_MDICREATE                  = 0x0220, // ʮ���ƣ�544 
        /// <summary>
        /// Ӧ�ó����ʹ���Ϣ�����ĵ��Ŀͻ��������ر�һ��MDI �Ӵ���
        /// </summary>
        WM_MDIDESTROY                 = 0x0221, // ʮ���ƣ�545 
        /// <summary>
        /// Ӧ�ó����ʹ���Ϣ�����ĵ��Ŀͻ�����֪ͨ�ͻ����ڼ�����һ��MDI�Ӵ��ڣ����ͻ������յ�����Ϣ��������WM_MDIACTIVE��Ϣ��MDI�Ӵ��ڣ�δ���������
        /// </summary>
        WM_MDIACTIVATE                = 0x0222, // ʮ���ƣ�546 
        /// <summary>
        /// ���� ���ʹ���Ϣ��MDI�ͻ��������Ӵ��ڴ������С���ָ���ԭ����С
        /// </summary>
        WM_MDIRESTORE                 = 0x0223, // ʮ���ƣ�547 
        /// <summary>
        /// �����ʹ���Ϣ��MDI�ͻ����ڼ�����һ����ǰһ������
        /// </summary>
        WM_MDINEXT                    = 0x0224, // ʮ���ƣ�548 
        /// <summary>
        /// �����ʹ���Ϣ��MDI�ͻ����������һ��MDI�Ӵ���
        /// </summary>
        WM_MDIMAXIMIZE                = 0x0225, // ʮ���ƣ�549 
        /// <summary>
        /// ���� ���ʹ���Ϣ��MDI�ͻ�������ƽ�̷�ʽ������������MDI�Ӵ���
        /// </summary>
        WM_MDITILE                    = 0x0226, // ʮ���ƣ�550 
        /// <summary>
        /// �����ʹ���Ϣ��MDI�ͻ������Բ����ʽ������������MDI�Ӵ���
        /// </summary>
        WM_MDICASCADE                 = 0x0227, // ʮ���ƣ�551 
        /// <summary>
        /// �����ʹ���Ϣ��MDI�ͻ�������������������С����MDI�Ӵ���
        /// </summary>
        WM_MDIICONARRANGE             = 0x0228, // ʮ���ƣ�552 
        /// <summary>
        /// �����ʹ���Ϣ��MDI�ͻ��������ҵ�������Ӵ��ڵľ��
        /// </summary>
        WM_MDIGETACTIVE               = 0x0229, // ʮ���ƣ�553 
        /// <summary>
        /// �����ʹ���Ϣ��MDI�ͻ�������MDI�˵������Ӵ��ڵĲ˵�
        /// </summary>
        WM_MDISETMENU                 = 0x0230, // ʮ���ƣ�560 
        WM_ENTERSIZEMOVE              = 0x0231, // ʮ���ƣ�561 
        WM_EXITSIZEMOVE               = 0x0232, // ʮ���ƣ�562 
        WM_DROPFILES                  = 0x0233, // ʮ���ƣ�563 
        WM_MDIREFRESHMENU             = 0x0234, // ʮ���ƣ�564 
        WM_IME_REPORT                 = 0x0280, // ʮ���ƣ�640 
        WM_IME_SETCONTEXT             = 0x0281, // ʮ���ƣ�641 
        WM_IME_NOTIFY                 = 0x0282, // ʮ���ƣ�642 
        WM_IME_CONTROL                = 0x0283, // ʮ���ƣ�643 
        WM_IME_COMPOSITIONFULL        = 0x0284, // ʮ���ƣ�644 
        WM_IME_SELECT                 = 0x0285, // ʮ���ƣ�645 
        WM_IME_CHAR                   = 0x0286, // ʮ���ƣ�646 
        WM_IME_REQUEST                = 0x0288, // ʮ���ƣ�648 
        WM_IMEKEYDOWN                 = 0x0290, // ʮ���ƣ�656 
        WM_IME_KEYDOWN                = 0x0290, // ʮ���ƣ�656 
        WM_IMEKEYUP                   = 0x0291, // ʮ���ƣ�657 
        WM_IME_KEYUP                  = 0x0291, // ʮ���ƣ�657 
        WM_NCMOUSEHOVER               = 0x02a0, // ʮ���ƣ�672 
        WM_MOUSEHOVER                 = 0x02a1, // ʮ���ƣ�673 
        WM_NCMOUSELEAVE               = 0x02a2, // ʮ���ƣ�674 
        WM_MOUSELEAVE                 = 0x02a3, // ʮ���ƣ�675 
        /// <summary>
        /// �����ʹ���Ϣ��һ���༭���combobox��ɾ����ǰѡ����ı�
        /// </summary>
        WM_CUT                        = 0x0300, // ʮ���ƣ�768 
        /// <summary>
        /// �����ʹ���Ϣ��һ���༭���combobox�����Ƶ�ǰѡ����ı���������
        /// </summary>
        WM_COPY                       = 0x0301, // ʮ���ƣ�769 
        /// <summary>
        /// �����ʹ���Ϣ��editcontrol��combobox�Ӽ������еõ�����
        /// </summary>
        WM_PASTE                      = 0x0302, // ʮ���ƣ�770 
        /// <summary>
        /// �����ʹ���Ϣ��editcontrol��combobox�����ǰѡ�������
        /// </summary>
        WM_CLEAR                      = 0x0303, // ʮ���ƣ�771 
        /// <summary>
        /// �����ʹ���Ϣ��editcontrol��combobox�������һ�β���
        /// </summary>
        WM_UNDO                       = 0x0304, // ʮ���ƣ�772 
        WM_RENDERFORMAT               = 0x0305, // ʮ���ƣ�773 
        WM_RENDERALLFORMATS           = 0x0306, // ʮ���ƣ�774 
        /// <summary>
        /// ������ENPTYCLIPBOARD����ʱ ���ʹ���Ϣ���������������
        /// </summary>
        WM_DESTROYCLIPBOARD           = 0x0307, // ʮ���ƣ�775 
        /// <summary>
        /// ������������ݱ仯ʱ���ʹ���Ϣ��������۲����ĵ�һ�����ڣ��������ü�����۲촰������ʾ�������������
        /// </summary>
        WM_DRAWCLIPBOARD              = 0x0308, // ʮ���ƣ�776 
        /// <summary>
        /// �����������CF_OWNERDIPLAY��ʽ�����ݲ��Ҽ�����۲촰�ڵĿͻ�����Ҫ�ػ�
        /// </summary>
        WM_PAINTCLIPBOARD             = 0x0309, // ʮ���ƣ�777 
        WM_VSCROLLCLIPBOARD           = 0x030a, // ʮ���ƣ�778 
        /// <summary>
        /// �����������CF_OWNERDIPLAY��ʽ�����ݲ��Ҽ�����۲촰�ڵĿͻ�����Ĵ�С�Ѿ��ı��Ǵ���Ϣͨ��������۲촰�ڷ��͸��������������
        /// </summary>
        WM_SIZECLIPBOARD              = 0x030b, // ʮ���ƣ�779 
        /// <summary>
        /// ͨ��������۲촰�ڷ��ʹ���Ϣ���������������������һ��CF_OWNERDISPLAY��ʽ�ļ����������
        /// </summary>
        WM_ASKCBFORMATNAME            = 0x030c, // ʮ���ƣ�780 
        /// <summary>
        /// ��һ�����ڴӼ�����۲�������ȥʱ���ʹ���Ϣ��������۲����ĵ�һ������
        /// </summary>
        WM_CHANGECBCHAIN              = 0x030d, // ʮ���ƣ�781 
        /// <summary>
        /// ����Ϣͨ��һ��������۲촰�ڷ��͸�������������� ���������ڵ����������CFOWNERDISPALY��ʽ�����ݲ����и��¼��ڼ�����۲촰��ˮƽ�������ϣ�������Ӧ����������ͼ�󲢸��¹�������ֵ
        /// </summary>
        WM_HSCROLLCLIPBOARD           = 0x030e, // ʮ���ƣ�782 
        /// <summary>
        /// ����Ϣ���͸���Ҫ�յ�����Ĵ��ڣ�����Ϣ��ʹ�������յ�����ʱͬʱ�л���ʵ�������߼���ɫ��
        /// </summary>
        WM_QUERYNEWPALETTE            = 0x030f, // ʮ���ƣ�783 
        /// <summary>
        /// ��һ��Ӧ�ó�����Ҫʵ�������߼���ɫ��ʱ������Ϣ֪ͨ���е�Ӧ�ó���
        /// </summary>
        WM_PALETTEISCHANGING          = 0x0310, // ʮ���ƣ�784 
        /// <summary>
        /// ����Ϣ��һ��ӵ�н���Ĵ���ʵ�������߼���ɫ����ʹ���Ϣ�����ж������ص��Ĵ��ڣ��Դ����ı�ϵͳ��ɫ��
        /// </summary>
        WM_PALETTECHANGED             = 0x0311, // ʮ���ƣ�785 
        /// <summary>
        /// ���û�������REGISTERHOTKEY����ע����ȼ�ʱ�ύ����Ϣ
        /// </summary>
        WM_HOTKEY                     = 0x0312, // ʮ���ƣ�786 
        /// <summary>
        /// Ӧ�ó����ʹ���Ϣ����WINDOWS������Ӧ�ó��򷢳�һ������Ҫ�����һ��Ӧ�ó����һ����
        /// </summary>
        WM_PRINT                      = 0x0317, // ʮ���ƣ�791 
        WM_PRINTCLIENT                = 0x0318, // ʮ���ƣ�792 
        WM_APPCOMMAND                 = 0x0319, // ʮ���ƣ�793 
        WM_HANDHELDFIRST              = 0x0358, // ʮ���ƣ�856 
        WM_HANDHELDLAST               = 0x035f, // ʮ���ƣ�863 
        WM_AFXFIRST                   = 0x0360, // ʮ���ƣ�864 
        WM_AFXLAST                    = 0x037f, // ʮ���ƣ�895 
        WM_PENWINFIRST                = 0x0380, // ʮ���ƣ�896 
        WM_RCRESULT                   = 0x0381, // ʮ���ƣ�897 
        WM_HOOKRCRESULT               = 0x0382, // ʮ���ƣ�898 
        WM_GLOBALRCCHANGE             = 0x0383, // ʮ���ƣ�899 
        WM_PENMISCINFO                = 0x0383, // ʮ���ƣ�899 
        WM_SKB                        = 0x0384, // ʮ���ƣ�900 
        WM_HEDITCTL                   = 0x0385, // ʮ���ƣ�901 
        WM_PENCTL                     = 0x0385, // ʮ���ƣ�901 
        WM_PENMISC                    = 0x0386, // ʮ���ƣ�902 
        WM_CTLINIT                    = 0x0387, // ʮ���ƣ�903 
        WM_PENEVENT                   = 0x0388, // ʮ���ƣ�904 
        WM_PENWINLAST                 = 0x038f, // ʮ���ƣ�911 
        WM_DDE_FIRST                  = 0x03E0,
        /// <summary>
        /// һ��DDE�ͻ������ύ����Ϣ��ʼһ�������������ĻỰ����Ӧ�Ǹ�ָ���ĳ����������
        /// </summary>
        WM_DDE_INITIATE               = WM_DDE_FIRST + 0,
        /// <summary>
        /// һ��DDEӦ�ó��������ǿͻ����Ƿ��������ύ����Ϣ����ֹһ���Ự
        /// </summary>
        WM_DDE_TERMINATE              = WM_DDE_FIRST + 1,
        /// <summary>
        /// һ��DDE�ͻ������ύ����Ϣ��һ��DDE������������������ÿ��������ı�ʱ������
        /// </summary>
        WM_DDE_ADVISE                 = WM_DDE_FIRST + 2,
        /// <summary>
        /// һ��DDE�ͻ�����ͨ������Ϣ֪ͨһ��DDE������򲻸���ָ�������һ������ļ������ʽ����
        /// </summary>
        WM_DDE_UNADVISE               = WM_DDE_FIRST + 3,
        /// <summary>
        /// ����Ϣ֪ͨһ��DDE����̬���ݽ������������յ������ڴ���WM_DDE_POKE, WM_DDE_EXECUTE, WM_DDE_DATA, WM_DDE_ADVISE, WM_DDE_UNADVISE, or WM_DDE_INITIAT��Ϣ
        /// </summary>
        WM_DDE_ACK                    = WM_DDE_FIRST + 4,
        /// <summary>
        /// һ��DDE��������ύ����Ϣ��DDE�ͻ����������ݸ�һ��������ͻ���֪ͨ�ͻ���һ������������
        /// </summary>
        WM_DDE_DATA                   = WM_DDE_FIRST + 5,
        /// <summary>
        /// һ��DDE�ͻ������ύ����Ϣ��һ��DDE�������������һ���������ֵ
        /// </summary>
        WM_DDE_REQUEST                = WM_DDE_FIRST + 6,
        /// <summary>
        /// һ��DDE�ͻ������ύ����Ϣ��һ��DDE������򣬿ͻ�ʹ�ô���Ϣ���������������һ��δ��ͬ��������������ͨ����WM_DDE_ACK��Ϣ��ʾ�Ƿ����������������
        /// </summary>
        WM_DDE_POKE                   = WM_DDE_FIRST + 7,
        /// <summary>
        /// һ��DDE�ͻ������ύ����Ϣ��һ��DDE�������������һ���ַ�����������������������һ��������������ͨ���ύWM_DDE_ACK��Ϣ������Ӧ
        /// </summary>
        WM_DDE_EXECUTE                = WM_DDE_FIRST + 8,
        WM_DDE_LAST                   = WM_DDE_FIRST + 8,
        DDM_SETFMT                    = 0x0400, // ʮ���ƣ�1024 
        DM_GETDEFID                   = 0x0400, // ʮ���ƣ�1024 
        NIN_SELECT                    = 0x0400, // ʮ���ƣ�1024 
        TBM_GETPOS                    = 0x0400, // ʮ���ƣ�1024 
        WM_PSD_PAGESETUPDLG           = 0x0400, // ʮ���ƣ�1024 
        /// <summary>
        /// ˽�д�����ʹ��������Ϣ������Ϣ�ܰ���Ӧ�ó����Զ���˽����Ϣ
        /// </summary>
        WM_USER                       = 0x0400, // ʮ���ƣ�1024 
        CBEM_INSERTITEMA              = 0x0401, // ʮ���ƣ�1025 
        DDM_DRAW                      = 0x0401, // ʮ���ƣ�1025 
        DM_SETDEFID                   = 0x0401, // ʮ���ƣ�1025 
        HKM_SETHOTKEY                 = 0x0401, // ʮ���ƣ�1025 
        PBM_SETRANGE                  = 0x0401, // ʮ���ƣ�1025 
        RB_INSERTBANDA                = 0x0401, // ʮ���ƣ�1025 
        SB_SETTEXTA                   = 0x0401, // ʮ���ƣ�1025 
        TB_ENABLEBUTTON               = 0x0401, // ʮ���ƣ�1025 
        TBM_GETRANGEMIN               = 0x0401, // ʮ���ƣ�1025 
        TTM_ACTIVATE                  = 0x0401, // ʮ���ƣ�1025 
        WM_CHOOSEFONT_GETLOGFONT      = 0x0401, // ʮ���ƣ�1025 
        WM_PSD_FULLPAGERECT           = 0x0401, // ʮ���ƣ�1025 
        CBEM_SETIMAGELIST             = 0x0402, // ʮ���ƣ�1026 
        DDM_CLOSE                     = 0x0402, // ʮ���ƣ�1026 
        DM_REPOSITION                 = 0x0402, // ʮ���ƣ�1026 
        HKM_GETHOTKEY                 = 0x0402, // ʮ���ƣ�1026 
        PBM_SETPOS                    = 0x0402, // ʮ���ƣ�1026 
        RB_DELETEBAND                 = 0x0402, // ʮ���ƣ�1026 
        SB_GETTEXTA                   = 0x0402, // ʮ���ƣ�1026 
        TB_CHECKBUTTON                = 0x0402, // ʮ���ƣ�1026 
        TBM_GETRANGEMAX               = 0x0402, // ʮ���ƣ�1026 
        WM_PSD_MINMARGINRECT          = 0x0402, // ʮ���ƣ�1026 
        CBEM_GETIMAGELIST             = 0x0403, // ʮ���ƣ�1027 
        DDM_BEGIN                     = 0x0403, // ʮ���ƣ�1027 
        HKM_SETRULES                  = 0x0403, // ʮ���ƣ�1027 
        PBM_DELTAPOS                  = 0x0403, // ʮ���ƣ�1027 
        RB_GETBARINFO                 = 0x0403, // ʮ���ƣ�1027 
        SB_GETTEXTLENGTHA             = 0x0403, // ʮ���ƣ�1027 
        TBM_GETTIC                    = 0x0403, // ʮ���ƣ�1027 
        TB_PRESSBUTTON                = 0x0403, // ʮ���ƣ�1027 
        TTM_SETDELAYTIME              = 0x0403, // ʮ���ƣ�1027 
        WM_PSD_MARGINRECT             = 0x0403, // ʮ���ƣ�1027 
        CBEM_GETITEMA                 = 0x0404, // ʮ���ƣ�1028 
        DDM_END                       = 0x0404, // ʮ���ƣ�1028 
        PBM_SETSTEP                   = 0x0404, // ʮ���ƣ�1028 
        RB_SETBARINFO                 = 0x0404, // ʮ���ƣ�1028 
        SB_SETPARTS                   = 0x0404, // ʮ���ƣ�1028 
        TB_HIDEBUTTON                 = 0x0404, // ʮ���ƣ�1028 
        TBM_SETTIC                    = 0x0404, // ʮ���ƣ�1028 
        TTM_ADDTOOLA                  = 0x0404, // ʮ���ƣ�1028 
        WM_PSD_GREEKTEXTRECT          = 0x0404, // ʮ���ƣ�1028 
        CBEM_SETITEMA                 = 0x0405, // ʮ���ƣ�1029 
        PBM_STEPIT                    = 0x0405, // ʮ���ƣ�1029 
        TB_INDETERMINATE              = 0x0405, // ʮ���ƣ�1029 
        TBM_SETPOS                    = 0x0405, // ʮ���ƣ�1029 
        TTM_DELTOOLA                  = 0x0405, // ʮ���ƣ�1029 
        WM_PSD_ENVSTAMPRECT           = 0x0405, // ʮ���ƣ�1029 
        CBEM_GETCOMBOCONTROL          = 0x0406, // ʮ���ƣ�1030 
        PBM_SETRANGE32                = 0x0406, // ʮ���ƣ�1030 
        RB_SETBANDINFOA               = 0x0406, // ʮ���ƣ�1030 
        SB_GETPARTS                   = 0x0406, // ʮ���ƣ�1030 
        TB_MARKBUTTON                 = 0x0406, // ʮ���ƣ�1030 
        TBM_SETRANGE                  = 0x0406, // ʮ���ƣ�1030 
        TTM_NEWTOOLRECTA              = 0x0406, // ʮ���ƣ�1030 
        WM_PSD_YAFULLPAGERECT         = 0x0406, // ʮ���ƣ�1030 
        CBEM_GETEDITCONTROL           = 0x0407, // ʮ���ƣ�1031 
        PBM_GETRANGE                  = 0x0407, // ʮ���ƣ�1031 
        RB_SETPARENT                  = 0x0407, // ʮ���ƣ�1031 
        SB_GETBORDERS                 = 0x0407, // ʮ���ƣ�1031 
        TBM_SETRANGEMIN               = 0x0407, // ʮ���ƣ�1031 
        TTM_RELAYEVENT                = 0x0407, // ʮ���ƣ�1031 
        CBEM_SETEXSTYLE               = 0x0408, // ʮ���ƣ�1032 
        PBM_GETPOS                    = 0x0408, // ʮ���ƣ�1032 
        RB_HITTEST                    = 0x0408, // ʮ���ƣ�1032 
        SB_SETMINHEIGHT               = 0x0408, // ʮ���ƣ�1032 
        TBM_SETRANGEMAX               = 0x0408, // ʮ���ƣ�1032 
        TTM_GETTOOLINFOA              = 0x0408, // ʮ���ƣ�1032 
        CBEM_GETEXSTYLE               = 0x0409, // ʮ���ƣ�1033 
        CBEM_GETEXTENDEDSTYLE         = 0x0409, // ʮ���ƣ�1033 
        PBM_SETBARCOLOR               = 0x0409, // ʮ���ƣ�1033 
        RB_GETRECT                    = 0x0409, // ʮ���ƣ�1033 
        SB_SIMPLE                     = 0x0409, // ʮ���ƣ�1033 
        TB_ISBUTTONENABLED            = 0x0409, // ʮ���ƣ�1033 
        TBM_CLEARTICS                 = 0x0409, // ʮ���ƣ�1033 
        TTM_SETTOOLINFOA              = 0x0409, // ʮ���ƣ�1033 
        CBEM_HASEDITCHANGED           = 0x040a, // ʮ���ƣ�1034 
        RB_INSERTBANDW                = 0x040a, // ʮ���ƣ�1034 
        SB_GETRECT                    = 0x040a, // ʮ���ƣ�1034 
        TB_ISBUTTONCHECKED            = 0x040a, // ʮ���ƣ�1034 
        TBM_SETSEL                    = 0x040a, // ʮ���ƣ�1034 
        TTM_HITTESTA                  = 0x040a, // ʮ���ƣ�1034 
        WIZ_QUERYNUMPAGES             = 0x040a, // ʮ���ƣ�1034 
        CBEM_INSERTITEMW              = 0x040b, // ʮ���ƣ�1035 
        RB_SETBANDINFOW               = 0x040b, // ʮ���ƣ�1035 
        SB_SETTEXTW                   = 0x040b, // ʮ���ƣ�1035 
        TB_ISBUTTONPRESSED            = 0x040b, // ʮ���ƣ�1035 
        TBM_SETSELSTART               = 0x040b, // ʮ���ƣ�1035 
        TTM_GETTEXTA                  = 0x040b, // ʮ���ƣ�1035 
        WIZ_NEXT                      = 0x040b, // ʮ���ƣ�1035 
        CBEM_SETITEMW                 = 0x040c, // ʮ���ƣ�1036 
        RB_GETBANDCOUNT               = 0x040c, // ʮ���ƣ�1036 
        SB_GETTEXTLENGTHW             = 0x040c, // ʮ���ƣ�1036 
        TB_ISBUTTONHIDDEN             = 0x040c, // ʮ���ƣ�1036 
        TBM_SETSELEND                 = 0x040c, // ʮ���ƣ�1036 
        TTM_UPDATETIPTEXTA            = 0x040c, // ʮ���ƣ�1036 
        WIZ_PREV                      = 0x040c, // ʮ���ƣ�1036 
        CBEM_GETITEMW                 = 0x040d, // ʮ���ƣ�1037 
        RB_GETROWCOUNT                = 0x040d, // ʮ���ƣ�1037 
        SB_GETTEXTW                   = 0x040d, // ʮ���ƣ�1037 
        TB_ISBUTTONINDETERMINATE      = 0x040d, // ʮ���ƣ�1037 
        TTM_GETTOOLCOUNT              = 0x040d, // ʮ���ƣ�1037 
        CBEM_SETEXTENDEDSTYLE         = 0x040e, // ʮ���ƣ�1038 
        RB_GETROWHEIGHT               = 0x040e, // ʮ���ƣ�1038 
        SB_ISSIMPLE                   = 0x040e, // ʮ���ƣ�1038 
        TB_ISBUTTONHIGHLIGHTED        = 0x040e, // ʮ���ƣ�1038 
        TBM_GETPTICS                  = 0x040e, // ʮ���ƣ�1038 
        TTM_ENUMTOOLSA                = 0x040e, // ʮ���ƣ�1038 
        SB_SETICON                    = 0x040f, // ʮ���ƣ�1039 
        TBM_GETTICPOS                 = 0x040f, // ʮ���ƣ�1039 
        TTM_GETCURRENTTOOLA           = 0x040f, // ʮ���ƣ�1039 
        RB_IDTOINDEX                  = 0x0410, // ʮ���ƣ�1040 
        SB_SETTIPTEXTA                = 0x0410, // ʮ���ƣ�1040 
        TBM_GETNUMTICS                = 0x0410, // ʮ���ƣ�1040 
        TTM_WINDOWFROMPOINT           = 0x0410, // ʮ���ƣ�1040 
        RB_GETTOOLTIPS                = 0x0411, // ʮ���ƣ�1041 
        SB_SETTIPTEXTW                = 0x0411, // ʮ���ƣ�1041 
        TBM_GETSELSTART               = 0x0411, // ʮ���ƣ�1041 
        TB_SETSTATE                   = 0x0411, // ʮ���ƣ�1041 
        TTM_TRACKACTIVATE             = 0x0411, // ʮ���ƣ�1041 
        RB_SETTOOLTIPS                = 0x0412, // ʮ���ƣ�1042 
        SB_GETTIPTEXTA                = 0x0412, // ʮ���ƣ�1042 
        TB_GETSTATE                   = 0x0412, // ʮ���ƣ�1042 
        TBM_GETSELEND                 = 0x0412, // ʮ���ƣ�1042 
        TTM_TRACKPOSITION             = 0x0412, // ʮ���ƣ�1042 
        RB_SETBKCOLOR                 = 0x0413, // ʮ���ƣ�1043 
        SB_GETTIPTEXTW                = 0x0413, // ʮ���ƣ�1043 
        TB_ADDBITMAP                  = 0x0413, // ʮ���ƣ�1043 
        TBM_CLEARSEL                  = 0x0413, // ʮ���ƣ�1043 
        TTM_SETTIPBKCOLOR             = 0x0413, // ʮ���ƣ�1043 
        RB_GETBKCOLOR                 = 0x0414, // ʮ���ƣ�1044 
        SB_GETICON                    = 0x0414, // ʮ���ƣ�1044 
        TB_ADDBUTTONSA                = 0x0414, // ʮ���ƣ�1044 
        TBM_SETTICFREQ                = 0x0414, // ʮ���ƣ�1044 
        TTM_SETTIPTEXTCOLOR           = 0x0414, // ʮ���ƣ�1044 
        RB_SETTEXTCOLOR               = 0x0415, // ʮ���ƣ�1045 
        TB_INSERTBUTTONA              = 0x0415, // ʮ���ƣ�1045 
        TBM_SETPAGESIZE               = 0x0415, // ʮ���ƣ�1045 
        TTM_GETDELAYTIME              = 0x0415, // ʮ���ƣ�1045 
        RB_GETTEXTCOLOR               = 0x0416, // ʮ���ƣ�1046 
        TB_DELETEBUTTON               = 0x0416, // ʮ���ƣ�1046 
        TBM_GETPAGESIZE               = 0x0416, // ʮ���ƣ�1046 
        TTM_GETTIPBKCOLOR             = 0x0416, // ʮ���ƣ�1046 
        RB_SIZETORECT                 = 0x0417, // ʮ���ƣ�1047 
        TB_GETBUTTON                  = 0x0417, // ʮ���ƣ�1047 
        TBM_SETLINESIZE               = 0x0417, // ʮ���ƣ�1047 
        TTM_GETTIPTEXTCOLOR           = 0x0417, // ʮ���ƣ�1047 
        RB_BEGINDRAG                  = 0x0418, // ʮ���ƣ�1048 
        TB_BUTTONCOUNT                = 0x0418, // ʮ���ƣ�1048 
        TBM_GETLINESIZE               = 0x0418, // ʮ���ƣ�1048 
        TTM_SETMAXTIPWIDTH            = 0x0418, // ʮ���ƣ�1048 
        RB_ENDDRAG                    = 0x0419, // ʮ���ƣ�1049 
        TB_COMMANDTOINDEX             = 0x0419, // ʮ���ƣ�1049 
        TBM_GETTHUMBRECT              = 0x0419, // ʮ���ƣ�1049 
        TTM_GETMAXTIPWIDTH            = 0x0419, // ʮ���ƣ�1049 
        RB_DRAGMOVE                   = 0x041a, // ʮ���ƣ�1050 
        TBM_GETCHANNELRECT            = 0x041a, // ʮ���ƣ�1050 
        TB_SAVERESTOREA               = 0x041a, // ʮ���ƣ�1050 
        TTM_SETMARGIN                 = 0x041a, // ʮ���ƣ�1050 
        RB_GETBARHEIGHT               = 0x041b, // ʮ���ƣ�1051 
        TB_CUSTOMIZE                  = 0x041b, // ʮ���ƣ�1051 
        TBM_SETTHUMBLENGTH            = 0x041b, // ʮ���ƣ�1051 
        TTM_GETMARGIN                 = 0x041b, // ʮ���ƣ�1051 
        RB_GETBANDINFOW               = 0x041c, // ʮ���ƣ�1052 
        TB_ADDSTRINGA                 = 0x041c, // ʮ���ƣ�1052 
        TBM_GETTHUMBLENGTH            = 0x041c, // ʮ���ƣ�1052 
        TTM_POP                       = 0x041c, // ʮ���ƣ�1052 
        RB_GETBANDINFOA               = 0x041d, // ʮ���ƣ�1053 
        TB_GETITEMRECT                = 0x041d, // ʮ���ƣ�1053 
        TBM_SETTOOLTIPS               = 0x041d, // ʮ���ƣ�1053 
        TTM_UPDATE                    = 0x041d, // ʮ���ƣ�1053 
        RB_MINIMIZEBAND               = 0x041e, // ʮ���ƣ�1054 
        TB_BUTTONSTRUCTSIZE           = 0x041e, // ʮ���ƣ�1054 
        TBM_GETTOOLTIPS               = 0x041e, // ʮ���ƣ�1054 
        TTM_GETBUBBLESIZE             = 0x041e, // ʮ���ƣ�1054 
        RB_MAXIMIZEBAND               = 0x041f, // ʮ���ƣ�1055 
        TBM_SETTIPSIDE                = 0x041f, // ʮ���ƣ�1055 
        TB_SETBUTTONSIZE              = 0x041f, // ʮ���ƣ�1055 
        TTM_ADJUSTRECT                = 0x041f, // ʮ���ƣ�1055 
        TBM_SETBUDDY                  = 0x0420, // ʮ���ƣ�1056 
        TB_SETBITMAPSIZE              = 0x0420, // ʮ���ƣ�1056 
        TTM_SETTITLEA                 = 0x0420, // ʮ���ƣ�1056 
        MSG_FTS_JUMP_VA               = 0x0421, // ʮ���ƣ�1057 
        TB_AUTOSIZE                   = 0x0421, // ʮ���ƣ�1057 
        TBM_GETBUDDY                  = 0x0421, // ʮ���ƣ�1057 
        TTM_SETTITLEW                 = 0x0421, // ʮ���ƣ�1057 
        RB_GETBANDBORDERS             = 0x0422, // ʮ���ƣ�1058 
        MSG_FTS_JUMP_QWORD            = 0x0423, // ʮ���ƣ�1059 
        RB_SHOWBAND                   = 0x0423, // ʮ���ƣ�1059 
        TB_GETTOOLTIPS                = 0x0423, // ʮ���ƣ�1059 
        MSG_REINDEX_REQUEST           = 0x0424, // ʮ���ƣ�1060 
        TB_SETTOOLTIPS                = 0x0424, // ʮ���ƣ�1060 
        MSG_FTS_WHERE_IS_IT           = 0x0425, // ʮ���ƣ�1061 
        RB_SETPALETTE                 = 0x0425, // ʮ���ƣ�1061 
        TB_SETPARENT                  = 0x0425, // ʮ���ƣ�1061 
        RB_GETPALETTE                 = 0x0426, // ʮ���ƣ�1062 
        RB_MOVEBAND                   = 0x0427, // ʮ���ƣ�1063 
        TB_SETROWS                    = 0x0427, // ʮ���ƣ�1063 
        TB_GETROWS                    = 0x0428, // ʮ���ƣ�1064 
        TB_GETBITMAPFLAGS             = 0x0429, // ʮ���ƣ�1065 
        TB_SETCMDID                   = 0x042a, // ʮ���ƣ�1066 
        RB_PUSHCHEVRON                = 0x042b, // ʮ���ƣ�1067 
        TB_CHANGEBITMAP               = 0x042b, // ʮ���ƣ�1067 
        TB_GETBITMAP                  = 0x042c, // ʮ���ƣ�1068 
        MSG_GET_DEFFONT               = 0x042d, // ʮ���ƣ�1069 
        TB_GETBUTTONTEXTA             = 0x042d, // ʮ���ƣ�1069 
        TB_REPLACEBITMAP              = 0x042e, // ʮ���ƣ�1070 
        TB_SETINDENT                  = 0x042f, // ʮ���ƣ�1071 
        TB_SETIMAGELIST               = 0x0430, // ʮ���ƣ�1072 
        TB_GETIMAGELIST               = 0x0431, // ʮ���ƣ�1073 
        TB_LOADIMAGES                 = 0x0432, // ʮ���ƣ�1074 
        TTM_ADDTOOLW                  = 0x0432, // ʮ���ƣ�1074 
        TB_GETRECT                    = 0x0433, // ʮ���ƣ�1075 
        TTM_DELTOOLW                  = 0x0433, // ʮ���ƣ�1075 
        TB_SETHOTIMAGELIST            = 0x0434, // ʮ���ƣ�1076 
        TTM_NEWTOOLRECTW              = 0x0434, // ʮ���ƣ�1076 
        TB_GETHOTIMAGELIST            = 0x0435, // ʮ���ƣ�1077 
        TTM_GETTOOLINFOW              = 0x0435, // ʮ���ƣ�1077 
        TB_SETDISABLEDIMAGELIST       = 0x0436, // ʮ���ƣ�1078 
        TTM_SETTOOLINFOW              = 0x0436, // ʮ���ƣ�1078 
        TB_GETDISABLEDIMAGELIST       = 0x0437, // ʮ���ƣ�1079 
        TTM_HITTESTW                  = 0x0437, // ʮ���ƣ�1079 
        TB_SETSTYLE                   = 0x0438, // ʮ���ƣ�1080 
        TTM_GETTEXTW                  = 0x0438, // ʮ���ƣ�1080 
        TB_GETSTYLE                   = 0x0439, // ʮ���ƣ�1081 
        TTM_UPDATETIPTEXTW            = 0x0439, // ʮ���ƣ�1081 
        TB_GETBUTTONSIZE              = 0x043a, // ʮ���ƣ�1082 
        TTM_ENUMTOOLSW                = 0x043a, // ʮ���ƣ�1082 
        TB_SETBUTTONWIDTH             = 0x043b, // ʮ���ƣ�1083 
        TTM_GETCURRENTTOOLW           = 0x043b, // ʮ���ƣ�1083 
        TB_SETMAXTEXTROWS             = 0x043c, // ʮ���ƣ�1084 
        TB_GETTEXTROWS                = 0x043d, // ʮ���ƣ�1085 
        TB_GETOBJECT                  = 0x043e, // ʮ���ƣ�1086 
        TB_GETBUTTONINFOW             = 0x043f, // ʮ���ƣ�1087 
        TB_SETBUTTONINFOW             = 0x0440, // ʮ���ƣ�1088 
        TB_GETBUTTONINFOA             = 0x0441, // ʮ���ƣ�1089 
        TB_SETBUTTONINFOA             = 0x0442, // ʮ���ƣ�1090 
        TB_INSERTBUTTONW              = 0x0443, // ʮ���ƣ�1091 
        TB_ADDBUTTONSW                = 0x0444, // ʮ���ƣ�1092 
        TB_HITTEST                    = 0x0445, // ʮ���ƣ�1093 
        TB_SETDRAWTEXTFLAGS           = 0x0446, // ʮ���ƣ�1094 
        TB_GETHOTITEM                 = 0x0447, // ʮ���ƣ�1095 
        TB_SETHOTITEM                 = 0x0448, // ʮ���ƣ�1096 
        TB_SETANCHORHIGHLIGHT         = 0x0449, // ʮ���ƣ�1097 
        TB_GETANCHORHIGHLIGHT         = 0x044a, // ʮ���ƣ�1098 
        TB_GETBUTTONTEXTW             = 0x044b, // ʮ���ƣ�1099 
        TB_SAVERESTOREW               = 0x044c, // ʮ���ƣ�1100 
        TB_ADDSTRINGW                 = 0x044d, // ʮ���ƣ�1101 
        TB_MAPACCELERATORA            = 0x044e, // ʮ���ƣ�1102 
        TB_GETINSERTMARK              = 0x044f, // ʮ���ƣ�1103 
        TB_SETINSERTMARK              = 0x0450, // ʮ���ƣ�1104 
        TB_INSERTMARKHITTEST          = 0x0451, // ʮ���ƣ�1105 
        TB_MOVEBUTTON                 = 0x0452, // ʮ���ƣ�1106 
        TB_GETMAXSIZE                 = 0x0453, // ʮ���ƣ�1107 
        TB_SETEXTENDEDSTYLE           = 0x0454, // ʮ���ƣ�1108 
        TB_GETEXTENDEDSTYLE           = 0x0455, // ʮ���ƣ�1109 
        TB_GETPADDING                 = 0x0456, // ʮ���ƣ�1110 
        TB_SETPADDING                 = 0x0457, // ʮ���ƣ�1111 
        TB_SETINSERTMARKCOLOR         = 0x0458, // ʮ���ƣ�1112 
        TB_GETINSERTMARKCOLOR         = 0x0459, // ʮ���ƣ�1113 
        TB_MAPACCELERATORW            = 0x045a, // ʮ���ƣ�1114 
        TB_GETSTRINGW                 = 0x045b, // ʮ���ƣ�1115 
        TB_GETSTRINGA                 = 0x045c, // ʮ���ƣ�1116 
        TAPI_REPLY                    = 0x0463, // ʮ���ƣ�1123 
        ACM_OPENA                     = 0x0464, // ʮ���ƣ�1124 
        BFFM_SETSTATUSTEXTA           = 0x0464, // ʮ���ƣ�1124 
        CDM_FIRST                     = 0x0464, // ʮ���ƣ�1124 
        CDM_GETSPEC                   = 0x0464, // ʮ���ƣ�1124 
        IPM_CLEARADDRESS              = 0x0464, // ʮ���ƣ�1124 
        WM_CAP_UNICODE_START          = 0x0464, // ʮ���ƣ�1124 
        ACM_PLAY                      = 0x0465, // ʮ���ƣ�1125 
        BFFM_ENABLEOK                 = 0x0465, // ʮ���ƣ�1125 
        CDM_GETFILEPATH               = 0x0465, // ʮ���ƣ�1125 
        IPM_SETADDRESS                = 0x0465, // ʮ���ƣ�1125 
        PSM_SETCURSEL                 = 0x0465, // ʮ���ƣ�1125 
        UDM_SETRANGE                  = 0x0465, // ʮ���ƣ�1125 
        WM_CHOOSEFONT_SETLOGFONT      = 0x0465, // ʮ���ƣ�1125 
        ACM_STOP                      = 0x0466, // ʮ���ƣ�1126 
        BFFM_SETSELECTIONA            = 0x0466, // ʮ���ƣ�1126 
        CDM_GETFOLDERPATH             = 0x0466, // ʮ���ƣ�1126 
        IPM_GETADDRESS                = 0x0466, // ʮ���ƣ�1126 
        PSM_REMOVEPAGE                = 0x0466, // ʮ���ƣ�1126 
        UDM_GETRANGE                  = 0x0466, // ʮ���ƣ�1126 
        WM_CAP_SET_CALLBACK_ERRORW    = 0x0466, // ʮ���ƣ�1126 
        WM_CHOOSEFONT_SETFLAGS        = 0x0466, // ʮ���ƣ�1126 
        ACM_OPENW                     = 0x0467, // ʮ���ƣ�1127 
        BFFM_SETSELECTIONW            = 0x0467, // ʮ���ƣ�1127 
        CDM_GETFOLDERIDLIST           = 0x0467, // ʮ���ƣ�1127 
        IPM_SETRANGE                  = 0x0467, // ʮ���ƣ�1127 
        PSM_ADDPAGE                   = 0x0467, // ʮ���ƣ�1127 
        UDM_SETPOS                    = 0x0467, // ʮ���ƣ�1127 
        WM_CAP_SET_CALLBACK_STATUSW   = 0x0467, // ʮ���ƣ�1127 
        BFFM_SETSTATUSTEXTW           = 0x0468, // ʮ���ƣ�1128 
        CDM_SETCONTROLTEXT            = 0x0468, // ʮ���ƣ�1128 
        IPM_SETFOCUS                  = 0x0468, // ʮ���ƣ�1128 
        PSM_CHANGED                   = 0x0468, // ʮ���ƣ�1128 
        UDM_GETPOS                    = 0x0468, // ʮ���ƣ�1128 
        CDM_HIDECONTROL               = 0x0469, // ʮ���ƣ�1129 
        IPM_ISBLANK                   = 0x0469, // ʮ���ƣ�1129 
        PSM_RESTARTWINDOWS            = 0x0469, // ʮ���ƣ�1129 
        UDM_SETBUDDY                  = 0x0469, // ʮ���ƣ�1129 
        CDM_SETDEFEXT                 = 0x046a, // ʮ���ƣ�1130 
        PSM_REBOOTSYSTEM              = 0x046a, // ʮ���ƣ�1130 
        UDM_GETBUDDY                  = 0x046a, // ʮ���ƣ�1130 
        PSM_CANCELTOCLOSE             = 0x046b, // ʮ���ƣ�1131 
        UDM_SETACCEL                  = 0x046b, // ʮ���ƣ�1131 
        EM_CONVPOSITION               = 0x046c, // ʮ���ƣ�1132 
        PSM_QUERYSIBLINGS             = 0x046c, // ʮ���ƣ�1132 
        UDM_GETACCEL                  = 0x046c, // ʮ���ƣ�1132 
        MCIWNDM_GETZOOM               = 0x046d, // ʮ���ƣ�1133 
        PSM_UNCHANGED                 = 0x046d, // ʮ���ƣ�1133 
        UDM_SETBASE                   = 0x046d, // ʮ���ƣ�1133 
        PSM_APPLY                     = 0x046e, // ʮ���ƣ�1134 
        UDM_GETBASE                   = 0x046e, // ʮ���ƣ�1134 
        PSM_SETTITLEA                 = 0x046f, // ʮ���ƣ�1135 
        UDM_SETRANGE32                = 0x046f, // ʮ���ƣ�1135 
        PSM_SETWIZBUTTONS             = 0x0470, // ʮ���ƣ�1136 
        UDM_GETRANGE32                = 0x0470, // ʮ���ƣ�1136 
        WM_CAP_DRIVER_GET_NAMEW       = 0x0470, // ʮ���ƣ�1136 
        PSM_PRESSBUTTON               = 0x0471, // ʮ���ƣ�1137 
        UDM_SETPOS32                  = 0x0471, // ʮ���ƣ�1137 
        WM_CAP_DRIVER_GET_VERSIONW    = 0x0471, // ʮ���ƣ�1137 
        PSM_SETCURSELID               = 0x0472, // ʮ���ƣ�1138 
        UDM_GETPOS32                  = 0x0472, // ʮ���ƣ�1138 
        PSM_SETFINISHTEXTA            = 0x0473, // ʮ���ƣ�1139 
        PSM_GETTABCONTROL             = 0x0474, // ʮ���ƣ�1140 
        PSM_ISDIALOGMESSAGE           = 0x0475, // ʮ���ƣ�1141 
        MCIWNDM_REALIZE               = 0x0476, // ʮ���ƣ�1142 
        PSM_GETCURRENTPAGEHWND        = 0x0476, // ʮ���ƣ�1142 
        MCIWNDM_SETTIMEFORMATA        = 0x0477, // ʮ���ƣ�1143 
        PSM_INSERTPAGE                = 0x0477, // ʮ���ƣ�1143 
        MCIWNDM_GETTIMEFORMATA        = 0x0478, // ʮ���ƣ�1144 
        PSM_SETTITLEW                 = 0x0478, // ʮ���ƣ�1144 
        WM_CAP_FILE_SET_CAPTURE_FILEW = 0x0478, // ʮ���ƣ�1144 
        MCIWNDM_VALIDATEMEDIA         = 0x0479, // ʮ���ƣ�1145 
        PSM_SETFINISHTEXTW            = 0x0479, // ʮ���ƣ�1145 
        WM_CAP_FILE_GET_CAPTURE_FILEW = 0x0479, // ʮ���ƣ�1145 
        MCIWNDM_PLAYTO                = 0x047b, // ʮ���ƣ�1147 
        WM_CAP_FILE_SAVEASW           = 0x047b, // ʮ���ƣ�1147 
        MCIWNDM_GETFILENAMEA          = 0x047c, // ʮ���ƣ�1148 
        MCIWNDM_GETDEVICEA            = 0x047d, // ʮ���ƣ�1149 
        PSM_SETHEADERTITLEA           = 0x047d, // ʮ���ƣ�1149 
        WM_CAP_FILE_SAVEDIBW          = 0x047d, // ʮ���ƣ�1149 
        MCIWNDM_GETPALETTE            = 0x047e, // ʮ���ƣ�1150 
        PSM_SETHEADERTITLEW           = 0x047e, // ʮ���ƣ�1150 
        MCIWNDM_SETPALETTE            = 0x047f, // ʮ���ƣ�1151 
        PSM_SETHEADERSUBTITLEA        = 0x047f, // ʮ���ƣ�1151 
        MCIWNDM_GETERRORA             = 0x0480, // ʮ���ƣ�1152 
        PSM_SETHEADERSUBTITLEW        = 0x0480, // ʮ���ƣ�1152 
        PSM_HWNDTOINDEX               = 0x0481, // ʮ���ƣ�1153 
        PSM_INDEXTOHWND               = 0x0482, // ʮ���ƣ�1154 
        MCIWNDM_SETINACTIVETIMER      = 0x0483, // ʮ���ƣ�1155 
        PSM_PAGETOINDEX               = 0x0483, // ʮ���ƣ�1155 
        PSM_INDEXTOPAGE               = 0x0484, // ʮ���ƣ�1156 
        DL_BEGINDRAG                  = 0x0485, // ʮ���ƣ�1157 
        MCIWNDM_GETINACTIVETIMER      = 0x0485, // ʮ���ƣ�1157 
        PSM_IDTOINDEX                 = 0x0485, // ʮ���ƣ�1157 
        DL_DRAGGING                   = 0x0486, // ʮ���ƣ�1158 
        PSM_INDEXTOID                 = 0x0486, // ʮ���ƣ�1158 
        DL_DROPPED                    = 0x0487, // ʮ���ƣ�1159 
        PSM_GETRESULT                 = 0x0487, // ʮ���ƣ�1159 
        DL_CANCELDRAG                 = 0x0488, // ʮ���ƣ�1160 
        PSM_RECALCPAGESIZES           = 0x0488, // ʮ���ƣ�1160 
        MCIWNDM_GET_SOURCE            = 0x048c, // ʮ���ƣ�1164 
        MCIWNDM_PUT_SOURCE            = 0x048d, // ʮ���ƣ�1165 
        MCIWNDM_GET_DEST              = 0x048e, // ʮ���ƣ�1166 
        MCIWNDM_PUT_DEST              = 0x048f, // ʮ���ƣ�1167 
        MCIWNDM_CAN_PLAY              = 0x0490, // ʮ���ƣ�1168 
        MCIWNDM_CAN_WINDOW            = 0x0491, // ʮ���ƣ�1169 
        MCIWNDM_CAN_RECORD            = 0x0492, // ʮ���ƣ�1170 
        MCIWNDM_CAN_SAVE              = 0x0493, // ʮ���ƣ�1171 
        MCIWNDM_CAN_EJECT             = 0x0494, // ʮ���ƣ�1172 
        MCIWNDM_CAN_CONFIG            = 0x0495, // ʮ���ƣ�1173 
        IE_GETINK                     = 0x0496, // ʮ���ƣ�1174 
        IE_MSGFIRST                   = 0x0496, // ʮ���ƣ�1174 
        MCIWNDM_PALETTEKICK           = 0x0496, // ʮ���ƣ�1174 
        IE_SETINK                     = 0x0497, // ʮ���ƣ�1175 
        IE_GETPENTIP                  = 0x0498, // ʮ���ƣ�1176 
        IE_SETPENTIP                  = 0x0499, // ʮ���ƣ�1177 
        IE_GETERASERTIP               = 0x049a, // ʮ���ƣ�1178 
        IE_SETERASERTIP               = 0x049b, // ʮ���ƣ�1179 
        IE_GETBKGND                   = 0x049c, // ʮ���ƣ�1180 
        IE_SETBKGND                   = 0x049d, // ʮ���ƣ�1181 
        IE_GETGRIDORIGIN              = 0x049e, // ʮ���ƣ�1182 
        IE_SETGRIDORIGIN              = 0x049f, // ʮ���ƣ�1183 
        IE_GETGRIDPEN                 = 0x04a0, // ʮ���ƣ�1184 
        IE_SETGRIDPEN                 = 0x04a1, // ʮ���ƣ�1185 
        IE_GETGRIDSIZE                = 0x04a2, // ʮ���ƣ�1186 
        IE_SETGRIDSIZE                = 0x04a3, // ʮ���ƣ�1187 
        IE_GETMODE                    = 0x04a4, // ʮ���ƣ�1188 
        IE_SETMODE                    = 0x04a5, // ʮ���ƣ�1189 
        IE_GETINKRECT                 = 0x04a6, // ʮ���ƣ�1190 
        WM_CAP_SET_MCI_DEVICEW        = 0x04a6, // ʮ���ƣ�1190 
        WM_CAP_GET_MCI_DEVICEW        = 0x04a7, // ʮ���ƣ�1191 
        WM_CAP_PAL_OPENW              = 0x04b4, // ʮ���ƣ�1204 
        WM_CAP_PAL_SAVEW              = 0x04b5, // ʮ���ƣ�1205 
        IE_GETAPPDATA                 = 0x04b8, // ʮ���ƣ�1208 
        IE_SETAPPDATA                 = 0x04b9, // ʮ���ƣ�1209 
        IE_GETDRAWOPTS                = 0x04ba, // ʮ���ƣ�1210 
        IE_SETDRAWOPTS                = 0x04bb, // ʮ���ƣ�1211 
        IE_GETFORMAT                  = 0x04bc, // ʮ���ƣ�1212 
        IE_SETFORMAT                  = 0x04bd, // ʮ���ƣ�1213 
        IE_GETINKINPUT                = 0x04be, // ʮ���ƣ�1214 
        IE_SETINKINPUT                = 0x04bf, // ʮ���ƣ�1215 
        IE_GETNOTIFY                  = 0x04c0, // ʮ���ƣ�1216 
        IE_SETNOTIFY                  = 0x04c1, // ʮ���ƣ�1217 
        IE_GETRECOG                   = 0x04c2, // ʮ���ƣ�1218 
        IE_SETRECOG                   = 0x04c3, // ʮ���ƣ�1219 
        IE_GETSECURITY                = 0x04c4, // ʮ���ƣ�1220 
        IE_SETSECURITY                = 0x04c5, // ʮ���ƣ�1221 
        IE_GETSEL                     = 0x04c6, // ʮ���ƣ�1222 
        IE_SETSEL                     = 0x04c7, // ʮ���ƣ�1223 
        CDM_LAST                      = 0x04c8, // ʮ���ƣ�1224 
        IE_DOCOMMAND                  = 0x04c8, // ʮ���ƣ�1224 
        MCIWNDM_NOTIFYMODE            = 0x04c8, // ʮ���ƣ�1224 
        IE_GETCOMMAND                 = 0x04c9, // ʮ���ƣ�1225 
        IE_GETCOUNT                   = 0x04ca, // ʮ���ƣ�1226 
        IE_GETGESTURE                 = 0x04cb, // ʮ���ƣ�1227 
        MCIWNDM_NOTIFYMEDIA           = 0x04cb, // ʮ���ƣ�1227 
        IE_GETMENU                    = 0x04cc, // ʮ���ƣ�1228 
        IE_GETPAINTDC                 = 0x04cd, // ʮ���ƣ�1229 
        MCIWNDM_NOTIFYERROR           = 0x04cd, // ʮ���ƣ�1229 
        IE_GETPDEVENT                 = 0x04ce, // ʮ���ƣ�1230 
        IE_GETSELCOUNT                = 0x04cf, // ʮ���ƣ�1231 
        IE_GETSELITEMS                = 0x04d0, // ʮ���ƣ�1232 
        IE_GETSTYLE                   = 0x04d1, // ʮ���ƣ�1233 
        MCIWNDM_SETTIMEFORMATW        = 0x04db, // ʮ���ƣ�1243 
        EM_OUTLINE                    = 0x04dc, // ʮ���ƣ�1244 
        MCIWNDM_GETTIMEFORMATW        = 0x04dc, // ʮ���ƣ�1244 
        EM_GETSCROLLPOS               = 0x04dd, // ʮ���ƣ�1245 
        EM_SETSCROLLPOS               = 0x04de, // ʮ���ƣ�1246 
        EM_SETFONTSIZE                = 0x04df, // ʮ���ƣ�1247 
        MCIWNDM_GETFILENAMEW          = 0x04e0, // ʮ���ƣ�1248 
        MCIWNDM_GETDEVICEW            = 0x04e1, // ʮ���ƣ�1249 
        MCIWNDM_GETERRORW             = 0x04e4, // ʮ���ƣ�1252 
        FM_GETFOCUS                   = 0x0600, // ʮ���ƣ�1536 
        FM_GETDRIVEINFOA              = 0x0601, // ʮ���ƣ�1537 
        FM_GETSELCOUNT                = 0x0602, // ʮ���ƣ�1538 
        FM_GETSELCOUNTLFN             = 0x0603, // ʮ���ƣ�1539 
        FM_GETFILESELA                = 0x0604, // ʮ���ƣ�1540 
        FM_GETFILESELLFNA             = 0x0605, // ʮ���ƣ�1541 
        FM_REFRESH_WINDOWS            = 0x0606, // ʮ���ƣ�1542 
        FM_RELOAD_EXTENSIONS          = 0x0607, // ʮ���ƣ�1543 
        FM_GETDRIVEINFOW              = 0x0611, // ʮ���ƣ�1553 
        FM_GETFILESELW                = 0x0614, // ʮ���ƣ�1556 
        FM_GETFILESELLFNW             = 0x0615, // ʮ���ƣ�1557 
        WLX_WM_SAS                    = 0x0659, // ʮ���ƣ�1625 
        SM_GETSELCOUNT                = 0x07e8, // ʮ���ƣ�2024 
        UM_GETSELCOUNT                = 0x07e8, // ʮ���ƣ�2024 
        WM_CPL_LAUNCH                 = 0x07e8, // ʮ���ƣ�2024 
        SM_GETSERVERSELA              = 0x07e9, // ʮ���ƣ�2025 
        UM_GETUSERSELA                = 0x07e9, // ʮ���ƣ�2025 
        WM_CPL_LAUNCHED               = 0x07e9, // ʮ���ƣ�2025 
        SM_GETSERVERSELW              = 0x07ea, // ʮ���ƣ�2026 
        UM_GETUSERSELW                = 0x07ea, // ʮ���ƣ�2026 
        SM_GETCURFOCUSA               = 0x07eb, // ʮ���ƣ�2027 
        UM_GETGROUPSELA               = 0x07eb, // ʮ���ƣ�2027 
        SM_GETCURFOCUSW               = 0x07ec, // ʮ���ƣ�2028 
        UM_GETGROUPSELW               = 0x07ec, // ʮ���ƣ�2028 
        SM_GETOPTIONS                 = 0x07ed, // ʮ���ƣ�2029 
        UM_GETCURFOCUSA               = 0x07ed, // ʮ���ƣ�2029 
        UM_GETCURFOCUSW               = 0x07ee, // ʮ���ƣ�2030 
        UM_GETOPTIONS                 = 0x07ef, // ʮ���ƣ�2031 
        UM_GETOPTIONS2                = 0x07f0, // ʮ���ƣ�2032 
        MEM_COMMIT                    = 0x1000,
        OCMBASE                       = 0x2000, // ʮ���ƣ�8192 
        OCM_CTLCOLOR                  = 0x2019, // ʮ���ƣ�8217 
        OCM_DRAWITEM                  = 0x202b, // ʮ���ƣ�8235 
        OCM_MEASUREITEM               = 0x202c, // ʮ���ƣ�8236 
        OCM_DELETEITEM                = 0x202d, // ʮ���ƣ�8237 
        OCM_VKEYTOITEM                = 0x202e, // ʮ���ƣ�8238 
        OCM_CHARTOITEM                = 0x202f, // ʮ���ƣ�8239 
        OCM_COMPAREITEM               = 0x2039, // ʮ���ƣ�8249 
        OCM_NOTIFY                    = 0x204e, // ʮ���ƣ�8270 
        OCM_COMMAND                   = 0x2111, // ʮ���ƣ�8465 
        OCM_HSCROLL                   = 0x2114, // ʮ���ƣ�8468 
        OCM_VSCROLL                   = 0x2115, // ʮ���ƣ�8469 
        OCM_CTLCOLORMSGBOX            = 0x2132, // ʮ���ƣ�8498 
        OCM_CTLCOLOREDIT              = 0x2133, // ʮ���ƣ�8499 
        OCM_CTLCOLORLISTBOX           = 0x2134, // ʮ���ƣ�8500 
        OCM_CTLCOLORBTN               = 0x2135, // ʮ���ƣ�8501 
        OCM_CTLCOLORDLG               = 0x2136, // ʮ���ƣ�8502 
        OCM_CTLCOLORSCROLLBAR         = 0x2137, // ʮ���ƣ�8503 
        OCM_CTLCOLORSTATIC            = 0x2138, // ʮ���ƣ�8504 
        OCM_PARENTNOTIFY              = 0x2210, // ʮ���ƣ�8720 
        /// <summary>
        /// ��Ӧ�ó���ʹ�õ���Ϣ��
        /// </summary>
        WM_APP                        = 0x8000, // ʮ���ƣ�32768 
        MEM_RELEASE                   = 0x8000,
        WM_RASDIALEVENT               = 0xcccd, // ʮ���ƣ�52429 
    }

    /// <summary>
    /// ģ������¼���
    /// </summary>
    public enum KEYEVENTF
    {
        /// <summary>
        /// ���°����ĳ���
        /// </summary>
        KEYEVENTF_KEYDOWN = 0,
        /// <summary>
        /// �ͷŰ����ĳ���
        /// </summary>
        KEYEVENTF_KEYUP = 2,
    }

    /// <summary>
    /// ģ������¼���
    /// </summary>
    public enum MOUSEEVENTF : int
    {
        /// <summary>
        /// ģ������ƶ��¼���
        /// </summary>
        MOUSEEVENTF_MOVE       = 0x1,
        /// <summary>
        /// ģ�ⰴ����������
        /// </summary>
        MOUSEEVENTF_LEFTDOWN   = 0x2,
        /// <summary>
        /// ģ��ſ���������
        /// </summary>
        MOUSEEVENTF_LEFTUP     = 0x4,
        /// <summary>
        /// ģ�ⰴ������Ҽ���
        /// </summary>
        MOUSEEVENTF_RIGHTDOWN  = 0x8,
        /// <summary>
        /// ģ��ſ�����Ҽ���
        /// </summary>
        MOUSEEVENTF_RIGHTUP    = 0x10,
        /// <summary>
        /// ģ�ⰴ������м���
        /// </summary>
        MOUSEEVENTF_MIDDLEDOWN = 0x20,
        /// <summary>
        /// ģ��ſ�����м���
        /// </summary>
        MOUSEEVENTF_MIDDLEUP   = 0x40,
        /// <summary>
        /// ��Ҫ���ڿ�������ƶ�λ���Ƿ����λ�á�
        /// </summary>
        MOUSEEVENTF_ABSOLUTE   = 0x8000,
    }

    /// <summary>
    /// ���̷���Ȩ�ޱ�ʶ��
    /// </summary>
    [System.Flags]
    public enum ProcessAccessFlags : uint
    {
        /// <summary>
        /// �����ܻ�õ�Ȩ��
        /// </summary>
        PROCESS_ALL_ACCESS = 0x001F0FFF,
        /// <summary>
        /// ��ֹһ�����̵�Ȩ�ޣ�ʹ��TerminateProcess
        /// </summary>
        Terminate = 0x00000001,
        /// <summary>
        /// ��Ҫ����һ���߳�
        /// </summary>
        PROCESS_CREATE_THREAD = 0x00000002,
        /// <summary>
        /// ���������ڴ�ռ��Ȩ��(����VirtualProtectEx��WriteProcessMemory)
        /// </summary>
        PROCESS_VM_OPERATION = 0x00000008,
        /// <summary>
        /// ��ȡ�����ڴ�ռ��Ȩ�ޣ���ʹ��ReadProcessMemory
        /// </summary>
        PROCESS_VM_READ = 0x00000010,
        /// <summary>
        /// ��ȡ�����ڴ�ռ��Ȩ�ޣ���ʹ��WriteProcessMemory
        /// </summary>
        PROCESS_VM_WRITE = 0x00000020,
        /// <summary>
        /// �ظ�ʹ��DuplicateHandle���
        /// </summary>
        PROCESS_DUP_HANDLE = 0x00000040,
        /// <summary>
        /// ����ĳЩ��Ϣ��Ȩ�ޣ���������ȼ�
        /// </summary>
        PROCESS_SET_INFORMATION = 0x00000200,
        /// <summary>
        /// Ҳӵ��PROCESS_QUERY_LIMITED_INFORMATIONȨ��
        /// </summary>
        PROCESS_QUERY_INFORMATION = 0x00000400,
        /// <summary>
        /// �ȴ�������ֹ
        /// </summary>
        Synchronize = 0x00100000
    }

    /// <summary>
    /// �����ļ����Ա�ʶ
    /// </summary>
    public enum FileAttributeFlags : uint
    {
        /// <summary>
        /// ֻ����
        /// </summary>
        FILE_ATTRIBUTE_READONLY = 0x00000001,
        /// <summary>
        /// ���ء�
        /// </summary>
        FILE_ATTRIBUTE_HIDDEN = 0x00000002,
        /// <summary>
        /// ϵͳ��
        /// </summary>
        FILE_ATTRIBUTE_SYSTEM = 0x00000004,
        /// <summary>
        /// Ŀ¼��
        /// </summary>
        FILE_ATTRIBUTE_DIRECTORY = 0x00000010,
        /// <summary>
        /// �浵��
        /// </summary>
        FILE_ATTRIBUTE_ARCHIVE = 0x00000020,
        /// <summary>
        /// ������
        /// </summary>
        FILE_ATTRIBUTE_DEVICE = 0x00000040,
        /// <summary>
        /// ����
        /// </summary>
        FILE_ATTRIBUTE_NORMAL = 0x00000080,
        /// <summary>
        /// ��ʱ
        /// </summary>
        FILE_ATTRIBUTE_TEMPORARY = 0x00000100,
        /// <summary>
        /// ϡ���ļ�
        /// </summary>
        FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200,
        /// <summary>
        /// �����ӻ��ݷ�ʽ
        /// </summary>
        FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400,
        /// <summary>
        /// ѹ����ֻ������NTFS����
        /// </summary>
        FILE_ATTRIBUTE_COMPRESSED = 0x00000800,
        /// <summary>
        /// �ѻ���
        /// </summary>
        FILE_ATTRIBUTE_OFFLINE = 0x00001000,
        /// <summary>
        /// ������ֻ������NTFS������
        /// </summary>
        FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000,
        /// <summary>
        /// ���ܡ�ֻ������NTFS������
        /// </summary>
        FILE_ATTRIBUTE_ENCRYPTED = 0x00004000,
        /// <summary>
        /// ����
        /// </summary>
        FILE_ATTRIBUTE_VIRTUAL = 65536,
    }

    /// <summary>
    /// �����ȡ��Դ��ʶ
    /// </summary>
    public enum GetFileInfoFlags : uint
    {
        /// <summary>
        /// ��ȡͼ��
        /// </summary>
        SHGFI_ICON = 0x000000100,
        /// <summary>
        /// ��ȡ��ʾ��
        /// </summary>
        SHGFI_DISPLAYNAME = 0x000000200,
        /// <summary>
        /// ��ȡ������
        /// </summary>
        SHGFI_TYPENAME = 0x000000400,
        /// <summary>
        /// ��ȡ����
        /// </summary>
        SHGFI_ATTRIBUTES = 0x000000800,
        /// <summary>
        /// get icon location
        /// </summary>
        SHGFI_ICONLOCATION = 0x000001000,
        /// <summary>
        /// return exe type
        /// </summary>
        SHGFI_EXETYPE = 0x000002000,
        /// <summary>
        /// get system icon index
        /// </summary>
        SHGFI_SYSICONINDEX = 0x000004000,
        /// <summary>
        /// put a link overlay on icon
        /// </summary>
        SHGFI_LINKOVERLAY = 0x000008000,
        /// <summary>
        /// show icon in selected state
        /// </summary>
        SHGFI_SELECTED = 0x000010000,
        /// <summary>
        /// get only specified attributes
        /// </summary>
        SHGFI_ATTR_SPECIFIED = 0x000020000,
        /// <summary>
        /// ��ȡ��ͼ��
        /// </summary>
        SHGFI_LARGEICON = 0x000000000,
        /// <summary>
        /// ��ȡСͼ��
        /// </summary>
        SHGFI_SMALLICON = 0x000000001,
        /// <summary>
        /// get open icon
        /// </summary>
        SHGFI_OPENICON = 0x000000002,
        /// <summary>
        /// get shell size icon
        /// </summary>
        SHGFI_SHELLICONSIZE = 0x000000004,
        /// <summary>
        /// pszPath��һ����ʶ����pszPath is a pidl��
        /// </summary>
        SHGFI_PIDL = 0x000000008,
        /// <summary>
        /// ������ʵ�һ��������ָ�����ļ���ʹ������Ϊ��pszPath�����д��ݵ��ļ��Ǵ��ڵģ���ʱ�������Ի����չ������������ע������õ�ͼ�����������Ϣ����use passed dwFileAttribute��
        /// </summary>
        SHGFI_USEFILEATTRIBUTES = 0x000000010,
        /// <summary>
        /// apply the appropriate overlays
        /// </summary>
        SHGFI_ADDOVERLAYS = 0x000000020,
        /// <summary>
        /// Get the index of the overlay
        /// </summary>
        SHGFI_OVERLAYINDEX = 0x000000040
    }

    ///// <summary>
    ///// ֪ͨ��Ϣ(Notification message)��ָ����һ����Ϣ��һ�������ڵ��ӿؼ�������һЩ���飬��Ҫ֪ͨ�����ڡ�֪ͨ��Ϣֻ�����ڱ�׼�Ĵ��ڿؼ��簴ť���б����Ͽ򡢱༭���Լ�Windows 95�����ؼ�����״��ͼ���б���ͼ�ȡ����磬������˫��һ���ؼ����ڿؼ���ѡ�񲿷��ı��������ؼ��Ĺ������������֪ͨ��Ϣ�� 
    ///// </summary>
    //public enum NotificationMessage
    //{
    //    /// <summary>
    //    /// �û������˰�ť
    //    /// </summary>
    //    BN_CLICKED,
    //    /// <summary>
    //    /// ��ť����ֹ
    //    /// </summary>
    //    BN_DISABLE,
    //    /// <summary>
    //    /// �û�˫���˰�ť
    //    /// </summary>
    //    BN_DOUBLECLICKED,
    //    /// <summary>
    //    /// �û������˰�ť
    //    /// </summary>
    //    BN_HILITE,
    //    /// <summary>
    //    /// ��ťӦ���ػ�
    //    /// </summary>
    //    BN_PAINT,
    //    /// <summary>
    //    /// ����Ӧ��ȥ����Ͽ�
    //    /// </summary>
    //    BN_UNHILITE,
    //    /// <summary>
    //    /// ��Ͽ���б�򱻹ر�
    //    /// </summary>
    //    CBN_CLOSEUP,
    //    /// <summary>
    //    /// �û�˫����һ���ַ���
    //    /// </summary>
    //    CBN_DBLCLK,
    //    /// <summary>
    //    /// ��Ͽ���б������
    //    /// </summary>
    //    CBN_DROPDOWN,
    //    /// <summary>
    //    /// �û��޸��˱༭���е��ı�
    //    /// </summary>
    //    CBN_EDITCHANGE,
    //    /// <summary>
    //    /// �༭���ڵ��ı���������
    //    /// </summary>
    //    CBN_EDITUPDATE,
    //    /// <summary>
    //    /// ��Ͽ��ڴ治��
    //    /// </summary>
    //    CBN_ERRSPACE,
    //    /// <summary>
    //    /// ��Ͽ�ʧȥ���뽹��
    //    /// </summary>
    //    CBN_KILLFOCUS,
    //    /// <summary>
    //    /// ����Ͽ���ѡ����һ��
    //    /// </summary>
    //    CBN_SELCHANGE,
    //    /// <summary>
    //    /// �û���ѡ��Ӧ����ȡ��
    //    /// </summary>
    //    CBN_SELENDCANCEL,
    //    /// <summary>
    //    /// �û���ѡ���ǺϷ���
    //    /// </summary>
    //    CBN_SELENDOK,
    //    /// <summary>
    //    /// ��Ͽ������뽹��༭��
    //    /// </summary>
    //    CBN_SETFOCUS,
    //    /// <summary>
    //    /// �༭���е��ı�������
    //    /// </summary>
    //    EN_CHANGE,
    //    /// <summary>
    //    /// �༭���ڴ治��
    //    /// </summary>
    //    EN_ERRSPACE,
    //    /// <summary>
    //    /// �û������ˮƽ������
    //    /// </summary>
    //    EN_HSCROLL,
    //    /// <summary>
    //    /// �༭������ʧȥ���뽹��
    //    /// </summary>
    //    EN_KILLFOCUS,
    //    /// <summary>
    //    /// ��������ݱ��ض�
    //    /// </summary>
    //    EN_MAXTEXT,
    //    /// <summary>
    //    /// �༭�������뽹��
    //    /// </summary>
    //    EN_SETFOCUS,
    //    /// <summary>
    //    /// �༭���е��ı���Ҫ����
    //    /// </summary>
    //    EN_UPDATE,
    //    /// <summary>
    //    /// �û�����˴�ֱ��������Ϣ�����б��
    //    /// </summary>
    //    EN_VSCROLL,
    //    /// <summary>
    //    /// �û�˫����һ��
    //    /// </summary>
    //    LBN_DBLCLK,
    //    /// <summary>
    //    /// �б���ڴ治��
    //    /// </summary>
    //    LBN_ERRSPACE,
    //    /// <summary>
    //    /// �б������ʧȥ���뽹��
    //    /// </summary>
    //    LBN_KILLFOCUS,
    //    /// <summary>
    //    /// ѡ��ȡ��
    //    /// </summary>
    //    LBN_SELCANCEL,
    //    /// <summary>
    //    /// ѡ������һ��
    //    /// </summary>
    //    LBN_SELCHANGE,
    //    /// <summary>
    //    /// �б�������뽹��
    //    /// </summary>
    //    LBN_SETFOCUS,
    //}

}
