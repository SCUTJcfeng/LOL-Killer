using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace FindProcess01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer += btnFind_Click;
            timer += KillLolClient;

            var processLisst = Process.GetProcesses();
            foreach(var pName in processLisst)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = pName.ProcessName;
                lvItem.SubItems.Add(pName.Id.ToString());
                lvwShowPrs.Items.Add(lvItem);
            }
        }

        public delegate void TimerEventHandler(object sender, EventArgs e);

        public event TimerEventHandler timer;

        public void OnTimer(EventArgs e)
        {
            if (timer != null)
                timer(this, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] process = Process.GetProcessesByName("LeagueClient");
                process[0].Kill();
                //process[0].Close();

                MessageBox.Show("LeagueClient has been killed successfully.");
            }
            catch
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        public void KillLolClient(object sender,EventArgs e)
        {
            try
            {
                Process[] process = Process.GetProcessesByName("Client");
                process[0].Kill();
                //process[0].Close();

                MessageBox.Show("Client has been killed successfully.");
            }
            catch
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void tmrKill_Tick(object sender, EventArgs e)
        {
            EventArgs ev = new EventArgs();
            OnTimer(ev);
        }

        private void lvwShowPrs_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (this.lvwShowPrs.Columns[e.Column].Tag == null)
                this.lvwShowPrs.Columns[e.Column].Tag = true;
            bool flag = (bool)this.lvwShowPrs.Columns[e.Column].Tag;
            if (flag)
                this.lvwShowPrs.Columns[e.Column].Tag = false;
            else
                this.lvwShowPrs.Columns[e.Column].Tag = true;
            this.lvwShowPrs.ListViewItemSorter = new ListViewSort(e.Column, this.lvwShowPrs.Columns[e.Column].Tag);
            this.lvwShowPrs.Sort();//对列表进行自定义排序  
        }
    }
    class ListViewSort : IComparer
    {
        private int col;
        private bool descK;
        public ListViewSort()
        {
            col = 0;
        }
        public ListViewSort(int column, object Desc)
        {
            descK = (bool)Desc;
            col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递 
        }
        public int Compare(object x, object y)
        {
            int tempInt = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            if (descK) return -tempInt;
            else return tempInt;
        }
    }
}
