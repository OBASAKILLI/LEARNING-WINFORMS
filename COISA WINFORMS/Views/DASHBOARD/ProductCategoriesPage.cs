using COISALIBRARY.Interfaces;
using COISALIBRARY.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public ProductCategoriesPage(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

       

        

        private async void iconButtonCreateCategory_Click(object sender, EventArgs e)
        {
            try {
                Product_Category productCategories = new Product_Category();
                productCategories.strCatPhoto = "null";
                productCategories.strCatName = textBoxCategoryName.Text.Trim();
                productCategories.Isdeleted = false;
                productCategories.strId = Guid.NewGuid().ToString();
                await _unitOfWork.ProductCategory.Create(productCategories);
                _unitOfWork.save();
                MessageBox.Show("Data saved Successfully");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
