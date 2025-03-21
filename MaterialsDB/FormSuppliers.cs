
using MaterialsDB.Models;

namespace MaterialsDB
{
    public partial class FormSuppliers : Form
    {
        private PartnersContext db;
        public FormSuppliers()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }
    }
}
