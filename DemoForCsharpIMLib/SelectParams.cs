﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForCsharpIMLib
{
    public partial class SelectParams : Form
    {
        public SelectParams(Dictionary<string, object> paramList)
        {
            InitializeComponent();
            ParamList = paramList;
        }
        public Dictionary<string,object> ParamList { get; set; }
        public List<object> Pararms { get; set; }
        List<TextBox> TbList = new List<TextBox>();
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
            }

        }

        private void SelectParams_Load(object sender, EventArgs e)
        {
            int rowCount = ParamList.Count;


            panel_table.RowCount = rowCount;    //设置分成几行  

            panel_table.ColumnCount = 2;    //设置分成几列  
            //for (int i = 0; i < colCount; i++)
            //{
            //    panel_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            //}  

            //panel_table.AutoSize = true;
            panel_table.Margin = new Padding(5);
            foreach (var item in ParamList)
            {
                var lb = new Label();
                lb.Text = item.Key;
                var tb = new TextBox();
                if (item.Value.GetType().Name=="String")
                {
                    tb.Text = item.Value.ToString();
                }
                else
                {
                    tb.Text = "obj";
                    tb.BackColor = Color.Red;
                }
                TbList.Add(tb);
                panel_table.Controls.Add(lb);
                panel_table.Controls.Add(tb);
            }
        }
    }
}
