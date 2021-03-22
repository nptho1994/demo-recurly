using HandleEzyVet.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandleEzyVet
{
    public partial class HandleEzyVet : Form
    {
        public HandleEzyVet()
        {
            InitializeComponent();
        }
        HandleContact handleContact = new HandleContact();
        HandleConnection handleConnection = new HandleConnection();
        HandleWellnessPlan handleWellnessPlan = new HandleWellnessPlan();
        private void btn_CreateContact_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleContact.CreateContact();
        }

        private void btn_UpdateContact_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleContact.UpdateContactById(txt_TestValue.Text);
        }

        private void btn_DeleteContact_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleContact.DeleteContactById(txt_TestValue.Text);
        }

        private void btn_FetchContact_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleContact.FetchContact();
        }

        private void btn_Asyn_Click(object sender, EventArgs e)
        {
            string tokenDetail = handleConnection.GetAccessTokenByScope(txt_Scope.Text);
            string[] tokenArray = tokenDetail.Split('\"');
            txt_TokenAccess.Text = tokenArray[3];
        }

        private void btn_FetchWellnessPlan_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleWellnessPlan.FetchWellnessPlan(txt_TokenAccess.Text);
        }

        private void btn_CreateWellnessPlan_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleWellnessPlan.CreateWellnessPlan(txt_TokenAccess.Text);
        }

        private void btn_UpdateWellnessPlan_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleWellnessPlan.UpdateWellnessPlan(txt_TokenAccess.Text, txt_TestValue.Text); 
        }

        private void btn_DeleteWellnessPlan_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleWellnessPlan.DeleteWellnessPlan(txt_TokenAccess.Text, txt_TestValue.Text);
        }
    }
}
 