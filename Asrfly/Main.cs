using Asrfly.Code;
using Asrfly.Gui.GuiHome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly
{
	public partial class Main : Form
	{
		private readonly PageManager pageManager;
		public Main()
		{
			InitializeComponent();
			pageManager = new PageManager(this);
			// Load Home Page
			pageManager.LoadPage(HomeUserControl.Instance());
		}
		private void btnHome_Click(object sender, EventArgs e)
		{
			// Load Home Page
			pageManager.LoadPage(HomeUserControl.Instance());
		}
	}
}
