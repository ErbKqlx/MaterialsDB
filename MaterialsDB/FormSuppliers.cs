using MaterialsDB.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using static System.Windows.Forms.DataFormats;

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

            UpdateData();

            dataGridViewSuppliers.Columns["Id"].Visible = false;

            dataGridViewSuppliers.Columns["TypeName"].HeaderText = "Тип поставщика";
            dataGridViewSuppliers.Columns["Name"].HeaderText = "Наименование";
            dataGridViewSuppliers.Columns["Inn"].HeaderText = "ИНН";
            dataGridViewSuppliers.Columns["Active"].HeaderText = "Действующий";
            dataGridViewSuppliers.Columns["AvgQuality"].HeaderText = "Среднее качество поставок";

            dataGridViewSuppliers.Columns["Active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSuppliers.Columns["AvgQuality"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            db?.Dispose();
            db = null;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new FormAdd();

            DialogResult result = formAdd.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            if (IsEmpty(formAdd))
                return;

            //var supplier = new Supplier();
            var type = (TypesOfSupplier)formAdd.typesOfSupplier.SelectedItem;
            Supplier supplier = new Supplier
            {
                IdTypeOfSupplier = type.Id,
                Name = formAdd.name.Text,
                Inn = formAdd.inn.Text,
                Active = formAdd.active.Checked
            };

            db.Suppliers.Add(supplier);
            db.SaveChanges();

            MessageBox.Show(
                "Поставщик добавлен",
                "Добавление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            UpdateData();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            var id = dataGridViewSuppliers.SelectedRows[0].Cells["Id"].Value;
            var converted = Int32.TryParse(id.ToString(), out int idSupplier);
            if (!converted)
                return;

            var supplier = db.Suppliers.Find(idSupplier);
            var formAdd = new FormAdd(db.TypesOfSuppliers.FirstOrDefault(t => t.Id == supplier.IdTypeOfSupplier).TypeName);

            formAdd.typesOfSupplier.SelectedValue = db.TypesOfSuppliers.FirstOrDefault(t => t.Id == supplier.IdTypeOfSupplier);
            formAdd.name.Text = supplier.Name;
            formAdd.inn.Text = supplier.Inn;
            formAdd.active.Checked = supplier.Active;

            DialogResult result = formAdd.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            if (IsEmpty(formAdd))
                return;

            var type = (TypesOfSupplier)formAdd.typesOfSupplier.SelectedItem;
            supplier.IdTypeOfSupplier = type.Id;
            supplier.Name = formAdd.name.Text;
            supplier.Inn = formAdd.inn.Text;
            supplier.Active = formAdd.active.Checked;

            db.Suppliers.Update(supplier);
            db.SaveChanges();

            MessageBox.Show(
                "Поставщик обновлен",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            UpdateData();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var id = dataGridViewSuppliers.SelectedRows[0].Cells["Id"].Value;
            var converted = Int32.TryParse(id.ToString(), out int idSupplier);
            if (!converted)
                return;

            var supplier = db.Suppliers.Find(idSupplier);

            db.Suppliers.Remove(supplier);
            db.SaveChanges();

            MessageBox.Show
            (
                "Поставщик удален",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            UpdateData();
        }

        private void UpdateData()
        {
            //var selected = db.Suppliers.Select(u => (float)u.SuppliersMaterials.Sum(u => u.Quality) / u.SuppliersMaterials.Count());

            dataGridViewSuppliers.DataSource = db.Suppliers
                .Include(u => u.IdTypeOfSupplierNavigation)
                .Select(u => new
                {
                    u.Id,
                    u.IdTypeOfSupplierNavigation.TypeName,
                    u.Name,
                    u.Inn,
                    u.Active,
                    AvgQuality = u.SuppliersMaterials.Count() != 0 ? (float)u.SuppliersMaterials.Sum(u => u.Quality) / u.SuppliersMaterials.Count() : 0
                        
                })
                .OrderByDescending(s => s.Id)
                .ToList();

            //catch
            //{
            //    dataGridViewSuppliers.DataSource = db.Suppliers
            //        .Include(u => u.IdTypeOfSupplierNavigation)
            //        .Select(u => new
            //        {
            //            u.Id,
            //            u.IdTypeOfSupplierNavigation.TypeName,
            //            u.Name,
            //            u.Inn,
            //            u.Active,
            //            AvgQuality = 0
            //        })
            //        .OrderByDescending(s => s.Id)
            //        .ToList();
            //}
        }

        private bool IsEmpty(FormAdd formAdd)
        {
            if (formAdd.name.Text == "" || formAdd.inn.Text == "")
            {
                MessageBox.Show
                (
                    "Есть пустое поле",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return true;
            }
            return false;
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            var id = dataGridViewSuppliers.SelectedRows[0].Cells["Id"].Value;
            var converted = Int32.TryParse(id.ToString(), out int idSupplier);
            if (!converted)
                return;

            FormHistory formHistory = new(idSupplier);
            formHistory.Show();
        }
    }
}
