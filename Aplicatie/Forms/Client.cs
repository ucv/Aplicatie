using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aplicatie.Forms
{
    public partial class Client : Form
    {

        public src.ClientClass data;

        public Client()
        {
            this.data = new src.ClientClass();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

    }
}
