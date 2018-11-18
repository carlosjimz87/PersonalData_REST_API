using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DjangoAPIClient
{
  
    public partial class ChooseObject : Form
    {
        public List<int> Ids{ get; set; }
        public int SelectedId { get; set; }

        public ChooseObject(string title, List<int> ids)
        {
            InitializeComponent();
            Ids = ids;
            Init(title,ids);
        }
        
        private void Init(string title, List<int> ids)
        {
            titleLB.Text = title.ToUpperInvariant();
            this.Text = title.ToUpperInvariant();
            SetResponseLB(ids);
        }

        private void SetResponseLB(List<int> ids)
        {
            resultLB.DataSource = ids;
        }

        
    }
}
