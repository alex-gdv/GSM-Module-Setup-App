using System.Windows.Forms;

namespace GSM_Module_Setup_App
{
    class BufferedListView : ListView
    {
        public BufferedListView()
        {
            this.DoubleBuffered = true;
        }
    }
}
