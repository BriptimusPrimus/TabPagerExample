using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabPagerExample
{
    public class TabPager<T>
    {
        List<T> PageList;

        List<T> TabList;        

        DataGridView MainGrid;

        private GroupBox ParentPanel;

        private int recordsPerTab = 20;

        private int tabsPerPage = 5;
    
        private int totalRecords = 0;        
        
        private int currentPage = 1;        

        //this means current tab index in current page...
        //not current tab from total number of tabs
        private int currentTab = 0; 

        private int totalPages = 1;

        private int totalTabs = 0;        

        //tabs-button dimensions
        private static int tabsLarge = 30;

        private static int tabsDistance = 0;

        //initial position of tabs in page
        private static int tabsXCoordinate = 10;
        private static int tabsYCoordinate = 10;

        //external method
        private Func<bool> ExternalMethod;

        //types of tabs
        private enum TabTypes 
        { 
            CurrentPage, 
            FirstPage, 
            LastPage, 
            PrevPage, 
            NextPage 
        }

        public TabPager(int recordsPerTab,
                        int tabsPerPage,            
                        int totalRecords,                         
                        List<T> PageList,
                        DataGridView MainGrid,
                        GroupBox ParentPanel, 
                        Func<bool> method,                                                 
                        int page = 1,
                        int tab = 0)
        {            
            this.recordsPerTab = recordsPerTab;
            this.tabsPerPage = tabsPerPage;
            this.totalRecords = totalRecords;
            this.PageList = PageList;
            this.MainGrid = MainGrid;
            this.ParentPanel = ParentPanel;
            this.ExternalMethod = method;
                        
            //calculate totals
            totalTabs = totalRecords / recordsPerTab;
            if (totalRecords % recordsPerTab != 0)
            {
                totalTabs++;
            }

            totalPages = totalTabs / tabsPerPage;
            if (totalTabs % tabsPerPage != 0)
            {
                totalPages++;
            }

            //set current page and tab
            SetValidPage(page);
            SetValidTab(tab);

            //initial draw
            DrawCurrentPage();
            //show the current tab corresponding records in the grid
            setCurrentTab();
        }

        public int CurrentPage
        {
            get 
            {
                return this.currentPage;
            }            
        }

        public int CurrentTab
        {
            get
            {
                return this.currentTab;
            }
        }

        public List<T> CurrentPageList 
        {
            get 
            {
                return this.PageList;
            }
            set
            {
                this.PageList = value;
            }        
        }

        public List<T> CurrentTabList
        {
            get
            {
                return this.TabList;
            }         
        }

        private void ClearPanel()
        {
            foreach (Control ctrl in ParentPanel.Controls)
            {
                ctrl.Dispose(); 
            }
            ParentPanel.Controls.Clear();
        }

        private void DrawPage(int page)
        {
            ClearPanel();

            if (totalPages < 1)
            {
                return;
            }

            //first and last tab in this page
            int firstTab = (page * tabsPerPage) - tabsPerPage + 1;
            int lastTab = page * tabsPerPage;
            while (lastTab > totalTabs)
            {
                lastTab--;
            }

            int xCoord = tabsXCoordinate;
            string name;
            string text;

            //go to the begining tab
            name = "btnFirstPageTab";
            text = "|<<";
            addTabToPanel(xCoord, name, text, TabTypes.FirstPage);
            xCoord += tabsLarge + tabsDistance;

            //prev page tab
            name = "btnPrevPageTab";
            text = "<-";
            addTabToPanel(xCoord, name, text, TabTypes.PrevPage);
            xCoord += tabsLarge + tabsDistance;

            int indexInPage = 0;
            //loop to draw dinamic tabs
            for (int tabIndex = firstTab; tabIndex <= lastTab; tabIndex++)            
            {
                name = indexInPage.ToString();
                indexInPage++;
                text = tabIndex.ToString();                                
                addTabToPanel(xCoord, name, text, TabTypes.CurrentPage);
                xCoord += tabsLarge + tabsDistance;
            }

            //next page tab
            name = "btnNextPageTab";
            text = "->";
            addTabToPanel(xCoord, name, text, TabTypes.NextPage);
            xCoord += tabsLarge + tabsDistance;

            //go to the end tab
            name = "btnLastPageTab";
            text = ">>|";
            addTabToPanel(xCoord, name, text, TabTypes.LastPage);
        }

        private void addTabToPanel(int xCoord, string name, string text, TabTypes type)
        {
            Button tab = new Button();            
            tab.Parent = ParentPanel;                
            tab.Size = new System.Drawing.Size(tabsLarge, tabsLarge);
            tab.Location = new System.Drawing.Point(xCoord, tabsYCoordinate);
            tab.Name = name;
            tab.Text = text;
            tab.Visible = true;
            tab.ForeColor = System.Drawing.Color.Black;

            //click event
            if (type == TabTypes.CurrentPage)
            {
                tab.Click += new System.EventHandler(this.TabButtonClick);
            }
            else if (type == TabTypes.FirstPage)
            {
                tab.Click += new System.EventHandler(this.FirstPageButtonClick);                
            }
            else if (type == TabTypes.LastPage)
            {
                tab.Click += new System.EventHandler(this.LastPageButtonClick);
            }
            else if (type == TabTypes.PrevPage)
            {
                tab.Click += new System.EventHandler(this.PrevPageButtonClick);
            }
            else if (type == TabTypes.NextPage)
            {
                tab.Click += new System.EventHandler(this.NextPageButtonClick);
            }
            ParentPanel.Controls.Add(tab);                            
        }

        public void DrawCurrentPage()
        {
            if (currentPage > totalPages)
            {
                return;
            }            
            DrawPage(currentPage);
        }

        //show the current tab corresponding records in the grid
        private void setCurrentTab()
        {
            //define begining and end
            int inicialIndex = currentTab * recordsPerTab;
            int finalIndex = inicialIndex + recordsPerTab;

            //make a list of the records of the current tab
            TabList = new List<T>();
            for (int index = inicialIndex; index < finalIndex; index++)
            {
                if (index >= PageList.Count)
                {
                    break;
                }
                //these records are a part of the Page List
                TabList.Add(PageList[index]);    
            }

            //set the sortable list as the tab list            
            MySortableBindingList<T> SortableList = new MySortableBindingList<T>(TabList);

            MainGrid.DataSource = SortableList;

            FocusSelectedTab();
        }

        private void setCurrentPage()
        {
            //call the external method wich fills 
            //the page list with its corresponding records
            if (ExternalMethod())
            {
                //when switching page always select the first tab
                currentTab = 0;
                //draw the tab pager components for this page
                DrawCurrentPage();
                //show the current tab corresponding records in the grid
                setCurrentTab();
            }
        }

        private void TabButtonClick(object sender, EventArgs e)
        {
            Button tab = (Button)sender;
            currentTab = Convert.ToInt32(tab.Name);
            setCurrentTab();            
        }

        private void FirstPageButtonClick(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                return;
            }
            currentPage = 1;
            setCurrentPage();
        }

        private void LastPageButtonClick(object sender, EventArgs e)
        {
            if (currentPage == totalPages)
            {
                return;
            }
            currentPage = totalPages;
            setCurrentPage();
        }

        private void PrevPageButtonClick(object sender, EventArgs e)
        {
            if (currentPage <= 1)
            {
                return;
            }
            currentPage--;
            setCurrentPage();
        }

        private void NextPageButtonClick(object sender, EventArgs e)
        {
            if (currentPage >= totalPages)
            {
                return;
            }
            currentPage++;
            setCurrentPage();
        }

        private void SetValidPage(int page)
        { 
            if (page < 1)
            {
                page = 1;
            }
            if (page > totalPages)
            {
                page = totalPages;
            }
            currentPage = page;
        }

        private void SetValidTab(int tabIndex)
        {
            if (tabIndex < 0)
            {
                tabIndex = 0;
            }
            while (tabIndex >= tabsPerPage)
            {
                tabIndex--;
            }
            currentTab = tabIndex;
        }

        private void FocusSelectedTab()
        { 
            //clear focus
            for (int index = 0; index < ParentPanel.Controls.Count; index++ )
            {
                ParentPanel.Controls[index].ForeColor = System.Drawing.Color.Black;    
            }
            //focus on selected tab
            //first page and next page buttons are placed before every tab
            int tabIndex = currentTab + 2;
            if (ParentPanel.Controls.Count > tabIndex)
            {
                ParentPanel.Controls[tabIndex].ForeColor = System.Drawing.Color.Blue;
            }
        }

    }
}
