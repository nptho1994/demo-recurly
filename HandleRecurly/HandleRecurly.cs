using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using HandleRecurly.Resource;

namespace HandleRecurly
{
    public partial class HandleRecurly : Form
    {
        private HandleBillingInfo handleBillingInfo = new HandleBillingInfo();
        private HandleAccount handleAccount = new HandleAccount();
        private HandlePlan handlePlan = new HandlePlan();
        private HandleSubscription handleSubscription = new HandleSubscription();
        private HandleCoupon handleCoupon = new HandleCoupon();
        public HandleRecurly()
        {
            InitializeComponent();
        }

        private void btn_GetBillingInfoToken_Click(object sender, EventArgs e)
        {
            txt_BillingInfoToken.Text = handleBillingInfo.GetBillingInfoToken();
        }

        private void btn_CreateAccountWithBillingInfo_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.CreateAccountWithBillingInfo(txt_BillingInfoToken.Text);
        }

        private void btn_CreatePlan_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handlePlan.CreatePlan();
        }

        private void btn_CreateSubscription_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleSubscription.CreateSubscription(txt_PlanCode.Text, txt_AccountCode.Text);
        }

        private void btn_CreateCoupon_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleCoupon.CreateCoupon();
        }
    }
}
