﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandEditor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
            
        }

        private void 新規プロジェクトNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        /// <summary>
        /// 各種変数初期化
        /// </summary>
        private void Init()
        {
            foreach(var type in Enum.GetNames(typeof(Define.COMMAND_TYPE)))
            {
                mainCommand.Items.Add(type);
            }
            
        }

        private void NewProject()
        {
            string fileName = GetProjectFileName();
            if(fileName.Length == 0)
            {
                return;
            }
            var file = File.Create(fileName);

            file.Close();
        }


        private string GetProjectFileName()
        {
            string fileName = "NewProject" + Define.EXTENSION_PROJECT;

            SaveFileDialog saveDialog = new SaveFileDialog()
            {
                FileName = fileName,
                Filter = "すべてのファイル(*.*)|*.*",
                CheckFileExists = false
            };

            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveDialog.FileName;

                // 拡張子が存在しない場合、末尾に追加する
                if (!fileName.EndsWith(Define.EXTENSION_PROJECT))
                {
                    fileName += Define.EXTENSION_PROJECT;
                }
            }
            else
            {
                return "";
            }

            return fileName;
        }

        public void ChangeCommandWindow(string commandStr)
        {
            generateTextBox.Text = commandStr;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string generetedCommand = CommandGenerate();
            ChangeCommandWindow(generetedCommand);
        }

        /// <summary>
        /// コマンド生成
        /// </summary>
        /// <returns>生成されたコマンド文字列</returns>
        private string CommandGenerate()
        {
            // 0でいいのか？要確認
            var commandControl = CommandPanel.Controls[0];
            string generetedCommand = "";

            switch (commandControl.GetType().ToString())
            {
                case "CommandEditor.GiveForm":
                    GiveForm giveForm = (GiveForm)commandControl;
                    generetedCommand = giveForm.GenerateCommand();
                    break;

                default:
                    break;
            }

            return generetedCommand;
        }
    }
}
