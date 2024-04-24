using COISA_WINFORMS.Views.CustomControls;
using COISA_WINFORMS.wwwroot.Custom_Controls;
using COISALIBRARY.Interfaces;
using COISALIBRARY.Models;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COISA_WINFORMS.Views.DASHBOARD
{
    public partial class ProductCategoriesPage : UserControl
    {
        private readonly IUnitOfWork _unitOfWork;

        public  ProductCategoriesPage(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;

          
          
          

        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
          await  DisplayDataAsync();
        }

        async Task DisplayDataAsync()
        {
            StartLoad();
            flowLayoutPanel1.Controls.Clear();
            FlowLayoutPanel flow=(FlowLayoutPanel)flowLayoutPanel1;
            
            Product_Category c = new Product_Category();
            var data = await _unitOfWork.ProductCategory.GetAll(c);
            foreach (var item in data)
            {
                CategoryCard categoryCard = new CategoryCard();

                flowLayoutPanel1.Padding = new Padding(10, 10, 10, 10);
                categoryCard.strTitle.Text = item.strCatName;

                categoryCard.strDesc.Text = "Some Text here for description";

                //Edit Button                   
                categoryCard.btnEdit.Tag = item.strCatName;
                categoryCard.btnEdit.Click += BtnEdit_Click;


                //Delete Button               
                categoryCard.btnRemove.Tag = item.strId;
                categoryCard.btnRemove.Click += BtnRemove_Click;

                categoryCard.Dock = DockStyle.Top;
                categoryCard.Width = flow.ClientSize.Width;

                flowLayoutPanel1.Controls.Add(categoryCard);
            }

            StopLoad();
        }

        void  StartLoad()
        {
            labelloading.Text = "Loading...";          
           
        }
        void  StopLoad()
        {
            labelloading.Text = "";

        }
     

        private async void BtnRemove_Click(object? sender, EventArgs e)
        {
            StartLoad();
            string data = ((IconButton)sender).Tag.ToString();
            Product_Category product_Category =await _unitOfWork.ProductCategory.GetById(data);
            if (product_Category != null)
            {
                _unitOfWork.ProductCategory.Remove(product_Category);
                _unitOfWork.save();
            }
            DisplayDataAsync();
            StopLoad();
           
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            var data = ((IconButton)sender).Tag;
            MessageBox.Show($"Edit  {data} Button  was clicked");
        }

      





        private async void iconButtonCreateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Product_Category productCategories = new Product_Category();
                productCategories.strCatPhoto = "null";
                productCategories.strCatName = textBoxCategoryName.Text.Trim();
                productCategories.Isdeleted = false;
                productCategories.strId = Guid.NewGuid().ToString();
                await _unitOfWork.ProductCategory.Create(productCategories);
                _unitOfWork.save();
                DisplayDataAsync();
                MessageBox.Show("Data saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void eK_RoundedTextBox3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
