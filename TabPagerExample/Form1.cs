using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabPagerExample
{
    public partial class Form1 : Form
    {
        private DataManager DataSource = new DataManager();

        private TabPager<Country> MyTabPager;

        private static int recordsPerTab = 20;
        private static int tabsPerPage = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData(int page, int tab)
        {
            //find out the total number of items 
            int totalRecords = DataSource.HowManyCountries();
            //get one specific page items
            List<Country> countries = DataSource.GetPage(1, recordsPerTab * tabsPerPage);

            MyTabPager = new TabPager<Country>( 
                recordsPerTab,
                tabsPerPage,
                totalRecords,                
                countries,
                dataGridView1,
                groupBox1,
                () => SwitchPage(),                                
                page,
                tab);
        }

        //Method that works with TabPager
        private bool SwitchPage()
        {            
            MyTabPager.CurrentPageList = DataSource.GetPage(
                MyTabPager.CurrentPage, 
                recordsPerTab * tabsPerPage);
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(1, 0);
        }
    }
}
