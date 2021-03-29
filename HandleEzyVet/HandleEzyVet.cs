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
        HandleContact handleContact = new HandleContact();
        HandleAnimal handleAnimal = new HandleAnimal();
        HandleConnection handleConnection = new HandleConnection();
        HandleWellnessPlan handleWellnessPlan = new HandleWellnessPlan();
        HandelWellnessPlanMembership handelWellnessPlanMembership = new HandelWellnessPlanMembership();
        CheckFunction checkFunction = new CheckFunction();
        FetchDataEzyVet fetchDataEzyVet = new FetchDataEzyVet();
        HandleAppointmentV2 handleAppointmentV2 = new HandleAppointmentV2();

        public HandleEzyVet()
        {
            InitializeComponent();
        }
        
        private void btn_Asyn_Click(object sender, EventArgs e)
        {
            string data = checkFunction.GetTokenByCode(txt_Scope.Text);
            if (txt_Scope.Text == "scope")
            {
                if (txt_TempId.Text == "update")
                {
                    string tokenDetail = handleConnection.GetAccessTokenByScope();
                    string[] tokenArray = tokenDetail.Split('\"');
                    txt_TokenAccess.Text = tokenArray[3];
                    checkFunction.UpdateScope(txt_Scope.Text, txt_TokenAccess.Text);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        txt_TokenAccess.Text = data;
                    }
                    else
                    {
                        string tokenDetail = handleConnection.GetAccessTokenByScope();
                        string[] tokenArray = tokenDetail.Split('\"');
                        txt_TokenAccess.Text = tokenArray[3];
                        checkFunction.InsertScope(txt_Scope.Text, txt_TokenAccess.Text);
                    }
                }
            }
            else
            {
                if (txt_TempId.Text == "update")
                {
                    checkFunction.UpdateScope(txt_Scope.Text, rtb_ShowEzyVetInfo.Text);
                }
                else if (!string.IsNullOrWhiteSpace(data))
                {
                    rtb_ShowEzyVetInfo.Text = data;
                }
                else
                {
                    checkFunction.InsertScope(txt_Scope.Text, rtb_ShowEzyVetInfo.Text);
                }
            }
        }
        private void btn_CreateContact_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleContact.CreateContact(txt_TokenAccess.Text);
        }

        private void btn_UpdateContact_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleContact.UpdateContactById(txt_TokenAccess.Text, txt_ContactId.Text);
        }

        private void btn_DeleteContact_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleContact.DeleteContactById(txt_TokenAccess.Text, txt_TempId.Text);
        }

        private void btn_FetchContact_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleContact.FetchContact(txt_TokenAccess.Text,txt_ContactId.Text, txt_TempId.Text);
        }

       

        private void btn_FetchWellnessPlan_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleWellnessPlan.Fetch(txt_TokenAccess.Text, txt_WellnessPlanId.Text);
        }

        private void btn_CreateWellnessPlan_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleWellnessPlan.Create(txt_TokenAccess.Text);
        }

        private void btn_UpdateWellnessPlan_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleWellnessPlan.Update(txt_TokenAccess.Text, txt_WellnessPlanId.Text); 
        }

        private void btn_DeleteWellnessPlan_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleWellnessPlan.Delete(txt_TokenAccess.Text, txt_WellnessPlanId.Text);
        }

        private void btn_FetchWellnessPlanBenefit_Click(object sender, EventArgs e)
        {

        }

        private void btn_FetchWellnessPlanMembership_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handelWellnessPlanMembership.Fetch(txt_TokenAccess.Text, txt_WellnessPlanId.Text, txt_WellnessPlanMembershipId.Text);
        }

        private void btn_UpdateWellnessPlanMembership_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handelWellnessPlanMembership.Update(txt_TokenAccess.Text, txt_WellnessPlanMembershipId.Text);
        }

        private void btn_CreateWellnessPlanMembership_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handelWellnessPlanMembership.Create(txt_TokenAccess.Text, txt_WellnessPlanId.Text, txt_AnimalId.Text, txt_ResourceId.Text, txt_SeparationId.Text);
        }

        private void btn_CreateAnimal_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleAnimal.Create(txt_TokenAccess.Text, txt_ContactId.Text);
        }

        private void btn_UpdateAnimal_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleAnimal.Update(txt_TokenAccess.Text, txt_AnimalId.Text);
        }

        private void btn_FetchUser_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = fetchDataEzyVet.FetchUser(txt_TokenAccess.Text, txt_UserId.Text);
        }

        private void btn_FetchAppoinmentV2_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleAppointmentV2.Fetch(txt_TokenAccess.Text, txt_AppointmentV2Id.Text, txt_ResourceId.Text);
        }

        private void btn_CreateAppoinmentV2_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleAppointmentV2.Create(txt_TokenAccess.Text, txt_AnimalId.Text, txt_ContactId.Text, txt_ResourceId.Text, txt_TempId.Text);
        }

        private void btn_FetchResource_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = fetchDataEzyVet.FetchResource(txt_TokenAccess.Text, txt_ResourceId.Text);
        }

        private void btn_FetchAnimal_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = handleAnimal.Fetch(txt_TokenAccess.Text, txt_AnimalId.Text);
        }

        private void btn_FetchSeparation_Click(object sender, EventArgs e)
        {
            rtb_ShowEzyVetInfo.Text = fetchDataEzyVet.FetchSeparation(txt_TokenAccess.Text, txt_SeparationId.Text);
        }
    }
}
 