using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using BuggerNetEng;

namespace BuggerNet
{
    public partial class frmExPInvoke : Form
    {
        public frmExPInvoke()
        {
            InitializeComponent();
        }

        static AllYouDoIsException allYouDoIsException = new AllYouDoIsException();
        static bool fCallWithHandler = false;
        public static int iA = 0;
        public static int iB = 0;
        public static int iC = 0;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;

            int.TryParse(txtA.Text, out a);
            int.TryParse(txtB.Text, out b);

            iA = a;
            iB = b;

            fCallWithHandler = chkExHandler.Checked;
            //if (chkExHandler.Checked)
            //{
            //    c= allYouDoIsException.CallAddWithExceptionHandler(a, b);
            //    fCallWithHandler = true;
            //}
            //else
            //{
            //    c = allYouDoIsException.CallAddWithoutExceptionHandler(a, b);
            //    fCallWithHandler = false;
            //}

            Thread thread = new Thread(frmExPInvoke.CallAdd);
            thread.Start();
            thread.Join();
            
            txtAB.Text = iC.ToString();
        }


        private static void CallAdd()
        {
            if (fCallWithHandler)
            {
                iC = allYouDoIsException.CallAddWithExceptionHandler(iA, iB);
            }
            else
            {
                iC = allYouDoIsException.CallAddWithoutExceptionHandler(iA, iB);                
            }
        }

    }
}
