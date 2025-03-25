using MaterialsDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialsDB
{
    public partial class FormAdd : Form
    {
        private PartnersContext db;
        private string type;
        public FormAdd()
        {
            InitializeComponent();
            db = new PartnersContext();

        }

        public FormAdd(string type)
        {
            InitializeComponent();
            db = new PartnersContext();
            this.type = type;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            typesOfSupplier.DataSource = db.TypesOfSuppliers.ToList();
            typesOfSupplier.DisplayMember = "TypeName";
            typesOfSupplier.ValueMember = "TypeName";

            if (type != null)
            {
                typesOfSupplier.SelectedValue = type;
            }
        }
    }
}
