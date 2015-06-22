using FingerprintNetSample.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FingerprintNetSample
{   
    public partial class UserView : Form
    {
        private GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;

        public UserView()
        {
            InitializeComponent();
        }

        public UserView(bool createMode)
        {
            InitializeComponent();

            if (createMode)
            {
                this.labelTitle.Text = "Fill the fields with the new user data";
                
                this.textBoxInfo.Text = "";
                this.textBoxInfo.Enabled = true;

                this.textBoxName.Text = "";
                this.textBoxName.Enabled = true;

                this.textBoxPassword.Text = "";
                this.textBoxPassword.Enabled = true;
                this.textBoxPassword.Visible = true;

                this.buttonSave.Enabled = true;
                this.buttonSave.Visible = true;

                this.labelStatus.Text = "";
                this.labelStatus.Visible = true;
                this.labelStatusTitle.Visible = true;
                                
                this.labelPassword.Visible = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void setFields(string name,string info)
        {
            this.textBoxName.Text = name;
            this.textBoxInfo.Text = info;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(this.textBoxInfo.Text != "" && this.textBoxName.Text != "" && this.textBoxPassword.Text != "")
            {
                IGRDal dl = DalFactory.GetDal(GrConnector.AccessDal);
                int id = dl.SaveUser(this.textBoxName.Text, this.textBoxInfo.Text,this.textBoxPassword.Text);
                dl = DalFactory.GetDal(GrConnector.AccessDal);
                dl.SaveTemplate(this._template, id);
                this.labelStatus.Text = "User and fingerprint Saved";
            }

            else
            {
                this.labelStatus.Text = "Empty fields";
            }
        }


        internal void setTemplate(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template)
        {
            this._template = _template;
        }
    }
}
