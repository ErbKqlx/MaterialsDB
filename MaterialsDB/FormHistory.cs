using MaterialsDB.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormHistory : Form
    {
        private PartnersContext db;
        private int id;
        public FormHistory(int id)
        {
            InitializeComponent();
            db = new PartnersContext();
            this.id = id;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var supplier = db.Suppliers.Find(id);
            labelName.Text += supplier.Name;

            dataGridViewHistory.DataSource = db.SuppliersMaterials
                .Include(i => i.IdMaterialNavigation)
                .Select(i => new { 
                    i.Id,
                    i.IdSupplier,
                    i.IdMaterialNavigation.Name,
                    i.PackageAmount,
                    i.AmountInPackage,
                    i.IdUnitNavigation.Unit,
                    i.DateOfSupply,
                    i.Price,
                    i.Quality })
                .Where(i => i.IdSupplier == supplier.Id)
                .OrderByDescending(i => i.DateOfSupply)
                .ToList();

            dataGridViewHistory.Columns["Id"].Visible = false;
            dataGridViewHistory.Columns["IdSupplier"].Visible = false;
            dataGridViewHistory.Columns["Name"].HeaderText = "Наименование материала";
            dataGridViewHistory.Columns["PackageAmount"].HeaderText = "Количество упаковок";
            dataGridViewHistory.Columns["AmountInPackage"].HeaderText = "Количество в упаковке";
            dataGridViewHistory.Columns["Unit"].HeaderText = "Единица измерения";
            dataGridViewHistory.Columns["DateOfSupply"].HeaderText = "Дата поставки";
            dataGridViewHistory.Columns["Price"].HeaderText = "Цена за упаковку";
            dataGridViewHistory.Columns["Quality"].HeaderText = "Качество поставки";

            dataGridViewHistory.Columns["PackageAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHistory.Columns["AmountInPackage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHistory.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHistory.Columns["DateOfSupply"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHistory.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHistory.Columns["Quality"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewHistory.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
