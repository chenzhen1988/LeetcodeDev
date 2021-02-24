using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string _projectPath;
        private string _currentProjectName;
        private ProjectsList _projectList;

        public string ProjectsPath 
        {
            get
            {
                return _projectPath;
            }
            set
            {
                _projectPath = value;
                this.textBox_ProjectPath.Text = value;
                this._projectList.LoadLocalProjects(value);
            } 
        }
        public string CurrentProjectName 
        {
            get
            {
                return _currentProjectName;
            }
            set
            {
                _currentProjectName = value;
                this.textBox_ProjectName.Text = value;
            }
        }

        private void _listView_Projects_HeaderInit()
        {
            this.listView_Projects.Columns.Add("序号", 120,  HorizontalAlignment.Left);
            this.listView_Projects.Columns.Add("工程名", 120, HorizontalAlignment.Left);
            this.listView_Projects.Columns.Add("路径", 120, HorizontalAlignment.Left);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _listView_Projects_HeaderInit();
            _projectList = new ProjectsList(this.listView_Projects);

            this.ProjectsPath = @"D:\360CloundPan\Test\LeetcodeDev";
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
                ProjectsPath = fb.SelectedPath;
        }

        private bool _isValidFileName(string fileName)
        {
            bool isValid = true;
            string errChar = "\\/:*?\"<>|";  //
            if (string.IsNullOrEmpty(fileName))
            {
                isValid = false;
            }
            else
            {
                for (int i = 0; i < errChar.Length; i++)
                {
                    if (fileName.Contains(errChar[i].ToString()))
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            return isValid;
        }

        private void button_CreateProject_Click(object sender, EventArgs e)
        {
            if (_isValidFileName(textBox_ProjectName.Text))
            {
                this.CurrentProjectName = textBox_ProjectName.Text;
            }
            _projectList.Add(this.CurrentProjectName, this.ProjectsPath);
            _projectList.Select(this.CurrentProjectName);
            _projectList.Selected.CreateLocalFiles();
        }

        private void listView_Projects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView_Projects.SelectedItems.Count == 0)
            {
                return;
            }

            this.CurrentProjectName = this.listView_Projects.SelectedItems[0].SubItems[1].Text;
            this._projectList.Select(CurrentProjectName); 
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _projectList.Remove(this.CurrentProjectName);
            _projectList.Selected.DeleteLocalFiles();
        }
    }
}
