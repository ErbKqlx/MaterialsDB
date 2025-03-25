using MaterialsDB.Models;
using Microsoft.EntityFrameworkCore;

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

            db = new();
            db.Suppliers.Load();

            dataGridViewSuppliers.DataSource = db.Suppliers.Local.OrderBy(s => s.Active == true).ToList();
            dataGridViewSuppliers.Columns["Id"].Visible = false;
            dataGridViewSuppliers.Columns["SuppliersMaterials"].Visible = false;

            dataGridViewSuppliers.Columns["Name"].HeaderText = "Наименование";
            dataGridViewSuppliers.Columns["Inn"].HeaderText = "ИНН";
            dataGridViewSuppliers.Columns["Active"].HeaderText = "Действующий";
            dataGridViewSuppliers.Columns["Active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSuppliers.Columns.Add("avgQuality", "Среднее качество поставок");
            dataGridViewSuppliers.Columns["avgQuality"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
