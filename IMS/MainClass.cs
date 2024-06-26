﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;


namespace IMS
{
    internal class MainClass
    {
        private static string path = "C:\\Users\\muham\\Documents\\connect.cfg";
        private static string s = File.ReadAllText(path);

        public static SqlConnection con = new SqlConnection(s);

        public static DialogResult showMsg(string msg,string heading, string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public static void ShowWindow(Form openWin , Form clsWin, Form MDIWin)
        {
            clsWin.Close();
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void ShowWindow(Form openWin, Form MDIWin)
        {
            //clsWin.Close();
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static void disable_reset(Panel P)
        {
            foreach(Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                      
                }
                if (c is CheckBox)
                {
                    CheckBox CHb = (CheckBox)c;
                    CHb.Enabled = false;
                    CHb.Checked = false;

                }



            }



        }
        public static void disable(Panel P)
        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;

                }
                if (c is CheckBox)
                {
                    CheckBox CHb = (CheckBox)c;
                    CHb.Enabled = false;

                }



            }



        }
        public static void enable_reset(Panel P)
        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;

                }
                if (c is CheckBox)
                {
                    CheckBox CHb = (CheckBox)c;
                    CHb.Enabled = true;
                    CHb.Checked = false;

                }



            }



        }


        public static void enable(Panel P)
        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;

                }
                if (c is CheckBox)
                {
                    CheckBox CHb = (CheckBox)c;
                    CHb.Enabled = true;

                }



            }



        }
    }

    

}
