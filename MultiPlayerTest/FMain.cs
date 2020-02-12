using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPlayerTest
{
    public partial class FMain : Form
    {
        public enum States
        {
            SearchingForServers,
            Client,
            Server
        }

        private States State;

        public FMain(States state)
        {
            InitializeComponent();
            State = state;

        }
    }
}
