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
            this.txt_PlanCode.KeyDown += new KeyEventHandler(txt_PlanCode_KeyDown);
            this.txt_AccountCode.KeyDown += new KeyEventHandler(txt_AccountCode_KeyDown);
            this.txt_CouponCode.KeyDown += new KeyEventHandler(txt_CouponCode_KeyDown);
        }

        private void btn_GetBillingInfoToken_Click(object sender, EventArgs e)
        {
            txt_BillingInfoToken.Text = handleBillingInfo.GetBillingInfoToken();
        }

        private void btn_CreateAccountWithBillingInfo_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.CreateAccountWithBillingInfo(txt_BillingInfoToken.Text, txt_AccountCode.Text);
        }

        private void btn_CreatePlan_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handlePlan.CreatePlan(txt_PlanCode.Text);
        }

        private void btn_CreateSubscription_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleSubscription.CreateSubscription(txt_PlanCode.Text, txt_AccountCode.Text);
        }

        private void btn_CreateCoupon_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleCoupon.CreateCoupon(txt_CouponCode.Text);
        }

        private void btn_CreateAccountCoupon_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleCoupon.MapAccountCoupon(txt_CouponId.Text, txt_AccountId.Text);
        }

        private void txt_PlanCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_PlanCode.Text))
            {
                txt_PlanId.Text = handlePlan.GetPlanIdByCode(txt_PlanCode.Text);
            }
        }

        private void txt_AccountCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_AccountCode.Text))
            {
                txt_AccountId.Text = handleAccount.GetAccountIdByCode(txt_AccountCode.Text);
            }
        }

        private void txt_CouponCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_CouponCode.Text))
            {
                txt_CouponId.Text = handleCoupon.GetCouponIdByCode(txt_CouponCode.Text);
            }
        }

        private void btn_CancelSubscription_Click(object sender, EventArgs e)
        {

        }

        private void btn_GetList_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.GetListAccount();
        }
    }
}
