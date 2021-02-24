using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsManager
{
    public class ProjectInfo
    {
        private string _sourceFullName;
        private string _headerFullName;
        private string _testcaseFullName;
        private FileStream _fsSource;
        private FileStream _fsHeader;
        private FileStream _fsTestcase;

        public string ProjectName { get; set; }

        public string ProjectPath { get; set; }

        public ProjectInfo(string name, string path)
        {
            this.ProjectName = name;
            this.ProjectPath = path;
            _sourceFullName = ProjectPath + @"\src\code\src\" + ProjectName + ".cpp";
            _headerFullName = ProjectPath + @"\src\code\inc\" + ProjectName + ".cpp";
            _testcaseFullName = ProjectPath + @"\src\testcase\" + ProjectName + "_test.cpp";
        }

        public void CreateLocalFiles()
        {
            FileStream _fsSource = new FileStream(_sourceFullName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream _fsHeader = new FileStream(_headerFullName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream _fsTestcase = new FileStream(_testcaseFullName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        public void DeleteLocalFiles()
        {
            if (System.IO.File.Exists(_sourceFullName))
            {
                System.IO.File.Delete(_sourceFullName);
            }
            if (System.IO.File.Exists(_headerFullName))
            {
                System.IO.File.Delete(_headerFullName);
            }
            if (System.IO.File.Exists(_testcaseFullName))
            {
                System.IO.File.Delete(_testcaseFullName);
            }
        }
    }

    public class ProjectsList
    {
        private ListView _listView;
        private List<ProjectInfo> _list;

        public ProjectsList(ListView listView)
        {
            _listView = listView;
            this._list = new List<ProjectInfo>();
        }

        public ProjectInfo Selected { get; set; }

        private void _updateItemsIntoListView()
        {
            this._listView.BeginUpdate();
            this._listView.Items.Clear();

            for (int i = 0; i < _list.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();
                lvi.SubItems.Add(_list[i].ProjectName);
                lvi.SubItems.Add(_list[i].ProjectPath);
                this._listView.Items.Add(lvi);
            }
            this._listView.EndUpdate();
            this._listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void Add(String name, String path)
        {
            ProjectInfo pi = new ProjectInfo(name, path);
            this._list.Add(pi);
            _updateItemsIntoListView();
        }

        public void Remove(string name)
        {
            ProjectInfo pi = null;
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].ProjectName == name)
                {
                    pi = _list[i];
                    break;
                }
            }
            _list.Remove(pi);
            
            _updateItemsIntoListView();
        }

        public void LoadLocalProjects(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path + @"\src\code\src");
            FileInfo[] fileInfo = dirInfo.GetFiles("*.cpp");
            foreach (var f in fileInfo)
            {
                string name = System.IO.Path.GetFileNameWithoutExtension(f.Name);
                this.Add(name, path);
            }
        }

        public void Select(string name)
        {
            foreach (var item in _list)
            {
                if (item.ProjectName == name)
                {
                    Selected = item;
                }
            }
        }
    }
}
