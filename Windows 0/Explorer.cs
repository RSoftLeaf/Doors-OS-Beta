﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_0
{
    public partial class Explorer : Form
    {
        #region VARIABLES

        Form1 form1;
        ImageList imgList = new ImageList();
        
        
        #endregion
        public Explorer(Form1 frm1)
        {
            form1 = frm1;
            InitializeComponent();
            imgList.Images.Add(Properties.Resources.img_file);
            imgList.Images.Add(Properties.Resources.img_folder);
            imgList.ImageSize = new Size(64, 64);
            
            listView1.LargeImageList = imgList;
            listView1.SmallImageList = imgList;
            
            treeView1.BeforeSelect += treeView1_BeforeExpand;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            // заполняем дерево дисками
            FillDriveNodes();
            
        }
        // событие перед раскрытием узла
        void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            listView1.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                    toolStripStatusLabel.Text = String.Format("{0,15:N0}", form1.myMethods.GetWSHFolderSize(e.Node.FullPath)) + " bytes";
                    FillListView(e.Node.FullPath);
                }
            }
            catch (Exception ex) { }
        }
        // событие перед выделением узла
        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(driveNode, drive.Name);
                    treeView1.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) { }
        }
        // получаем дочерние узлы для определенного узла
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }
        public void FillListView(string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    ListViewItem dirNode = new ListViewItem();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    dirNode.ImageIndex = 1;
                    listView1.Items.Add(dirNode);
                }
            }
            catch (Exception ex) { }

            // получаем все файлы
            string[] files = Directory.GetFiles(path);
            // перебор полученных файлов
            foreach (string file in files)
            {
                //Icon fileIcon = Icon.ExtractAssociatedIcon(file);
                //Image image = fileIcon.ToBitmap();
                ListViewItem lvi = new ListViewItem();
                // установка названия файла
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                lvi.ImageIndex = 0;// установка картинки для файла
                // добавляем элемент в ListView
                listView1.Items.Add(lvi);
            }
        }
        private void ChangeView(System.Windows.Forms.ListView lstView,View view)
        {
            /*
            switch (view)
            {
                case View.Details:
                    imgList.ImageSize = new Size(32, 32);
                    break;

            }
            */
            imgList.Images.Clear();
            imgList.Images.Add(Properties.Resources.img_file);
            imgList.Images.Add(Properties.Resources.img_folder);
            if (view == View.LargeIcon || view == View.Tile)
            {
                imgList.ImageSize = new Size(64, 64);


            }
            else
            {
                imgList.ImageSize = new Size(32, 32);
            }
            //                    imgList.ImageSize = new Size(32, 32);
            

            lstView.View = view;

        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView(listView1, View.Details);
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView(listView1, View.LargeIcon);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView(listView1, View.List);
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView(listView1, View.SmallIcon);
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeView(listView1, View.Tile);

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            ChangeView(listView1, View.LargeIcon);
        }
    }
}
