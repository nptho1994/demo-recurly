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
        private HandleAccount handleAccount = new HandleAccount();
        private HandleAccountNote handleAccountNote = new HandleAccountNote();
        private HandleAccountAcquisitionInfo handleAccountAcquisitionInfo = new HandleAccountAcquisitionInfo();
        private HandleBillingInfo handleBillingInfo = new HandleBillingInfo();
        private CheckFunction checkFunction = new CheckFunction();
        
        private HandlePlan handlePlan = new HandlePlan();
        private HandleSubscription handleSubscription = new HandleSubscription();
        private HandleCoupon handleCoupon = new HandleCoupon();
        private HandleInvoice handleInvoice = new HandleInvoice();
        public HandleRecurly()
        {
            InitializeComponent();
            this.txt_PlanCode.KeyDown += new KeyEventHandler(txt_PlanCode_KeyDown);
            this.txt_AccountCode.KeyDown += new KeyEventHandler(txt_AccountCode_KeyDown);
            this.txt_CouponCode.KeyDown += new KeyEventHandler(txt_CouponCode_KeyDown);
            this.txt_SubscriptionId.KeyDown += new KeyEventHandler(txt_SubscriptionId_KeyDown);
        }

        private void btn_TestFunction_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = checkFunction.GetAccessTokenByScope("read-contact");
            rtb_ShowInfo.Text += checkFunction.GetContact();
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

        private void txt_SubscriptionId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_AccountId.Text) && !string.IsNullOrWhiteSpace(txt_PlanId.Text))
            {
                txt_SubscriptionId.Text = handleSubscription.FetchSubscriptionByPlanAccount(txt_AccountId.Text, txt_PlanId.Text);
            }
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

        private void btn_GetList_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.GetListAccount();
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.CreateAccount(txt_AccountCode.Text);
        }

        private void btn_FetchAccount_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.FetchAccount(txt_AccountId.Text);
        }

        private void btn_UpdateAccount_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.UpdateAccount(txt_AccountId.Text, txt_BillingInfoToken.Text);
        }

        private void btn_DeActiveAccount_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.DeActiveAccount(txt_AccountId.Text);
        }

        private void btn_ReActiveAccount_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.ReActiveAccount(txt_AccountId.Text);
        }

        private void btn_FetchAccountBalance_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.FetchAccountBalance(txt_AccountId.Text);
        }

        private void btn_GetListChillAccount_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccount.GetListChillAccount(txt_AccountId.Text);
        }

        private void btn_GetListAccountNote_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccountNote.GetListAccountNote(txt_AccountId.Text);
        }

        private void btn_FetchAccountNote_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccountNote.FetchAccountNote(txt_AccountId.Text);
        }

        private void btn_FetchAccountAcquisitionInfo_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccountAcquisitionInfo.FetchAccountAcquisitionInfo(txt_AccountId.Text);
        }

        private void btn_UpdateAccountAccquisitionInfo_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccountAcquisitionInfo.UpdateAccountAcquisitionInfo(txt_AccountId.Text);
        }

        private void btn_RemoveAccountAccquisitionInfo_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccountAcquisitionInfo.RemoveAccountAcquisitionInfo(txt_AccountId.Text);
        }

        private void btn_GetListAccountAccquisitionInfo_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleAccountAcquisitionInfo.GetListAccountAcquisitionInfo();
        }

        private void btn_CancelSubscription_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleSubscription.CancelSubscription(txt_SubscriptionId.Text);
        }

        private void btn_GetListSubscriptionByAccount_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleSubscription.GetListSubscriptionByAccount(txt_SubscriptionId.Text);
        }

        private void btn_CancelPlan_Click(object sender, EventArgs e)
        {

        }

        private void btn_RefundInvoice_Click(object sender, EventArgs e)
        {
            rtb_ShowInfo.Text = handleInvoice.RefundInvoiceForAccount(txt_AccountId.Text);
        }
    }
}
