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
    public partial class IdTypeForm : Form
    {
        public IdType idtypeCreated { get; set; }

        public IdTypeForm(string title, IdType idtype)
        {
            InitializeComponent();
            InitForm(title, idtype);
        }

        private void InitForm(string title, IdType idtype)
        {
           
            titleLB.Text = title.ToUpperInvariant();
            this.Text = title.ToUpperInvariant();

            // "INJECT" subject obj for this Form
            idtypeCreated = idtype;
        }

        private void SetForm()
        {
            nameTB.Text = idtypeCreated.Name;
            regexTB.Text = idtypeCreated.Regex;
        }

        private void ResetForm()
        {
            nameTB.Clear();
            regexTB.Clear();
        }
        private void IdTypeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
