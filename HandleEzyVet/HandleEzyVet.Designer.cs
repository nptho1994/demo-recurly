﻿
namespace HandleEzyVet
{
    partial class HandleEzyVet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ContactId = new System.Windows.Forms.TextBox();
            this.btn_FetchContact = new System.Windows.Forms.Button();
            this.btn_DeleteContact = new System.Windows.Forms.Button();
            this.btn_UpdateContact = new System.Windows.Forms.Button();
            this.btn_CreateContact = new System.Windows.Forms.Button();
            this.rtb_ShowEzyVetInfo = new System.Windows.Forms.RichTextBox();
            this.gb_Setting = new System.Windows.Forms.GroupBox();
            this.btn_Asyn = new System.Windows.Forms.Button();
            this.txt_TempId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Scope = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TokenAccess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_WellnessPlanId = new System.Windows.Forms.TextBox();
            this.btn_FetchWellnessPlan = new System.Windows.Forms.Button();
            this.btn_DeleteWellnessPlan = new System.Windows.Forms.Button();
            this.btn_UpdateWellnessPlan = new System.Windows.Forms.Button();
            this.btn_CreateWellnessPlan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_WellnessPlanBenefitId = new System.Windows.Forms.TextBox();
            this.btn_FetchWellnessPlanBenefit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_WellnessPlanMembershipId = new System.Windows.Forms.TextBox();
            this.btn_FetchWellnessPlanMembership = new System.Windows.Forms.Button();
            this.btn_DeleteWellnessPlanMembership = new System.Windows.Forms.Button();
            this.btn_UpdateWellnessPlanMembership = new System.Windows.Forms.Button();
            this.btn_CreateWellnessPlanMembership = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_AnimalId = new System.Windows.Forms.TextBox();
            this.btn_FetchAnimal = new System.Windows.Forms.Button();
            this.btn_DeleteAnimal = new System.Windows.Forms.Button();
            this.btn_UpdateAnimal = new System.Windows.Forms.Button();
            this.btn_CreateAnimal = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.btn_FetchUser = new System.Windows.Forms.Button();
            this.btn_CreateAppoinmentV2 = new System.Windows.Forms.Button();
            this.btn_FetchAppoinmentV2 = new System.Windows.Forms.Button();
            this.txt_AppointmentV2Id = new System.Windows.Forms.TextBox();
            this.btn_UpdateAppoinmentV2 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_ResourceId = new System.Windows.Forms.TextBox();
            this.btn_FetchResource = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txt_SeparationId = new System.Windows.Forms.TextBox();
            this.btn_FetchSeparation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_Setting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ContactId);
            this.groupBox1.Controls.Add(this.btn_FetchContact);
            this.groupBox1.Controls.Add(this.btn_DeleteContact);
            this.groupBox1.Controls.Add(this.btn_UpdateContact);
            this.groupBox1.Controls.Add(this.btn_CreateContact);
            this.groupBox1.Location = new System.Drawing.Point(10, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact";
            // 
            // txt_ContactId
            // 
            this.txt_ContactId.Location = new System.Drawing.Point(283, 19);
            this.txt_ContactId.Name = "txt_ContactId";
            this.txt_ContactId.Size = new System.Drawing.Size(51, 20);
            this.txt_ContactId.TabIndex = 10;
            // 
            // btn_FetchContact
            // 
            this.btn_FetchContact.Location = new System.Drawing.Point(5, 19);
            this.btn_FetchContact.Name = "btn_FetchContact";
            this.btn_FetchContact.Size = new System.Drawing.Size(64, 20);
            this.btn_FetchContact.TabIndex = 3;
            this.btn_FetchContact.Text = "Fetch";
            this.btn_FetchContact.UseVisualStyleBackColor = true;
            this.btn_FetchContact.Click += new System.EventHandler(this.btn_FetchContact_Click);
            // 
            // btn_DeleteContact
            // 
            this.btn_DeleteContact.Location = new System.Drawing.Point(213, 19);
            this.btn_DeleteContact.Name = "btn_DeleteContact";
            this.btn_DeleteContact.Size = new System.Drawing.Size(64, 20);
            this.btn_DeleteContact.TabIndex = 2;
            this.btn_DeleteContact.Text = "Delete";
            this.btn_DeleteContact.UseVisualStyleBackColor = true;
            this.btn_DeleteContact.Click += new System.EventHandler(this.btn_DeleteContact_Click);
            // 
            // btn_UpdateContact
            // 
            this.btn_UpdateContact.Location = new System.Drawing.Point(144, 19);
            this.btn_UpdateContact.Name = "btn_UpdateContact";
            this.btn_UpdateContact.Size = new System.Drawing.Size(64, 20);
            this.btn_UpdateContact.TabIndex = 1;
            this.btn_UpdateContact.Text = "Update";
            this.btn_UpdateContact.UseVisualStyleBackColor = true;
            this.btn_UpdateContact.Click += new System.EventHandler(this.btn_UpdateContact_Click);
            // 
            // btn_CreateContact
            // 
            this.btn_CreateContact.Location = new System.Drawing.Point(75, 19);
            this.btn_CreateContact.Name = "btn_CreateContact";
            this.btn_CreateContact.Size = new System.Drawing.Size(64, 20);
            this.btn_CreateContact.TabIndex = 0;
            this.btn_CreateContact.Text = "Create";
            this.btn_CreateContact.UseVisualStyleBackColor = true;
            this.btn_CreateContact.Click += new System.EventHandler(this.btn_CreateContact_Click);
            // 
            // rtb_ShowEzyVetInfo
            // 
            this.rtb_ShowEzyVetInfo.Location = new System.Drawing.Point(10, 267);
            this.rtb_ShowEzyVetInfo.Name = "rtb_ShowEzyVetInfo";
            this.rtb_ShowEzyVetInfo.Size = new System.Drawing.Size(686, 113);
            this.rtb_ShowEzyVetInfo.TabIndex = 5;
            this.rtb_ShowEzyVetInfo.Text = "";
            // 
            // gb_Setting
            // 
            this.gb_Setting.Controls.Add(this.btn_Asyn);
            this.gb_Setting.Controls.Add(this.txt_TempId);
            this.gb_Setting.Controls.Add(this.label2);
            this.gb_Setting.Controls.Add(this.txt_Scope);
            this.gb_Setting.Controls.Add(this.label6);
            this.gb_Setting.Controls.Add(this.txt_TokenAccess);
            this.gb_Setting.Controls.Add(this.label1);
            this.gb_Setting.Location = new System.Drawing.Point(10, 10);
            this.gb_Setting.Name = "gb_Setting";
            this.gb_Setting.Size = new System.Drawing.Size(686, 42);
            this.gb_Setting.TabIndex = 6;
            this.gb_Setting.TabStop = false;
            this.gb_Setting.Text = "Setting";
            // 
            // btn_Asyn
            // 
            this.btn_Asyn.Location = new System.Drawing.Point(616, 16);
            this.btn_Asyn.Name = "btn_Asyn";
            this.btn_Asyn.Size = new System.Drawing.Size(64, 20);
            this.btn_Asyn.TabIndex = 4;
            this.btn_Asyn.Text = "Asyn";
            this.btn_Asyn.UseVisualStyleBackColor = true;
            this.btn_Asyn.Click += new System.EventHandler(this.btn_Asyn_Click);
            // 
            // txt_TempId
            // 
            this.txt_TempId.Location = new System.Drawing.Point(524, 16);
            this.txt_TempId.Name = "txt_TempId";
            this.txt_TempId.Size = new System.Drawing.Size(86, 20);
            this.txt_TempId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "TempId:";
            // 
            // txt_Scope
            // 
            this.txt_Scope.Location = new System.Drawing.Point(353, 16);
            this.txt_Scope.Name = "txt_Scope";
            this.txt_Scope.Size = new System.Drawing.Size(118, 20);
            this.txt_Scope.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Scope:";
            // 
            // txt_TokenAccess
            // 
            this.txt_TokenAccess.Location = new System.Drawing.Point(55, 16);
            this.txt_TokenAccess.Name = "txt_TokenAccess";
            this.txt_TokenAccess.Size = new System.Drawing.Size(250, 20);
            this.txt_TokenAccess.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TokenId:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_WellnessPlanId);
            this.groupBox2.Controls.Add(this.btn_FetchWellnessPlan);
            this.groupBox2.Controls.Add(this.btn_DeleteWellnessPlan);
            this.groupBox2.Controls.Add(this.btn_UpdateWellnessPlan);
            this.groupBox2.Controls.Add(this.btn_CreateWellnessPlan);
            this.groupBox2.Location = new System.Drawing.Point(356, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wellness Plan";
            // 
            // txt_WellnessPlanId
            // 
            this.txt_WellnessPlanId.Location = new System.Drawing.Point(283, 18);
            this.txt_WellnessPlanId.Name = "txt_WellnessPlanId";
            this.txt_WellnessPlanId.Size = new System.Drawing.Size(51, 20);
            this.txt_WellnessPlanId.TabIndex = 12;
            // 
            // btn_FetchWellnessPlan
            // 
            this.btn_FetchWellnessPlan.Location = new System.Drawing.Point(5, 19);
            this.btn_FetchWellnessPlan.Name = "btn_FetchWellnessPlan";
            this.btn_FetchWellnessPlan.Size = new System.Drawing.Size(64, 20);
            this.btn_FetchWellnessPlan.TabIndex = 3;
            this.btn_FetchWellnessPlan.Text = "Fetch";
            this.btn_FetchWellnessPlan.UseVisualStyleBackColor = true;
            this.btn_FetchWellnessPlan.Click += new System.EventHandler(this.btn_FetchWellnessPlan_Click);
            // 
            // btn_DeleteWellnessPlan
            // 
            this.btn_DeleteWellnessPlan.Location = new System.Drawing.Point(213, 19);
            this.btn_DeleteWellnessPlan.Name = "btn_DeleteWellnessPlan";
            this.btn_DeleteWellnessPlan.Size = new System.Drawing.Size(64, 20);
            this.btn_DeleteWellnessPlan.TabIndex = 2;
            this.btn_DeleteWellnessPlan.Text = "Delete";
            this.btn_DeleteWellnessPlan.UseVisualStyleBackColor = true;
            this.btn_DeleteWellnessPlan.Click += new System.EventHandler(this.btn_DeleteWellnessPlan_Click);
            // 
            // btn_UpdateWellnessPlan
            // 
            this.btn_UpdateWellnessPlan.Location = new System.Drawing.Point(144, 19);
            this.btn_UpdateWellnessPlan.Name = "btn_UpdateWellnessPlan";
            this.btn_UpdateWellnessPlan.Size = new System.Drawing.Size(64, 20);
            this.btn_UpdateWellnessPlan.TabIndex = 1;
            this.btn_UpdateWellnessPlan.Text = "Update";
            this.btn_UpdateWellnessPlan.UseVisualStyleBackColor = true;
            this.btn_UpdateWellnessPlan.Click += new System.EventHandler(this.btn_UpdateWellnessPlan_Click);
            // 
            // btn_CreateWellnessPlan
            // 
            this.btn_CreateWellnessPlan.Location = new System.Drawing.Point(75, 19);
            this.btn_CreateWellnessPlan.Name = "btn_CreateWellnessPlan";
            this.btn_CreateWellnessPlan.Size = new System.Drawing.Size(64, 20);
            this.btn_CreateWellnessPlan.TabIndex = 0;
            this.btn_CreateWellnessPlan.Text = "Create";
            this.btn_CreateWellnessPlan.UseVisualStyleBackColor = true;
            this.btn_CreateWellnessPlan.Click += new System.EventHandler(this.btn_CreateWellnessPlan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_WellnessPlanBenefitId);
            this.groupBox3.Controls.Add(this.btn_FetchWellnessPlanBenefit);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(10, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 47);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wellness PlanBenefit";
            // 
            // txt_WellnessPlanBenefitId
            // 
            this.txt_WellnessPlanBenefitId.Location = new System.Drawing.Point(214, 19);
            this.txt_WellnessPlanBenefitId.Name = "txt_WellnessPlanBenefitId";
            this.txt_WellnessPlanBenefitId.Size = new System.Drawing.Size(51, 20);
            this.txt_WellnessPlanBenefitId.TabIndex = 16;
            // 
            // btn_FetchWellnessPlanBenefit
            // 
            this.btn_FetchWellnessPlanBenefit.Location = new System.Drawing.Point(5, 19);
            this.btn_FetchWellnessPlanBenefit.Name = "btn_FetchWellnessPlanBenefit";
            this.btn_FetchWellnessPlanBenefit.Size = new System.Drawing.Size(64, 20);
            this.btn_FetchWellnessPlanBenefit.TabIndex = 3;
            this.btn_FetchWellnessPlanBenefit.Text = "Fetch";
            this.btn_FetchWellnessPlanBenefit.UseVisualStyleBackColor = true;
            this.btn_FetchWellnessPlanBenefit.Click += new System.EventHandler(this.btn_FetchWellnessPlanBenefit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 20);
            this.button3.TabIndex = 1;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(75, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 20);
            this.button4.TabIndex = 0;
            this.button4.Text = "Create";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_WellnessPlanMembershipId);
            this.groupBox4.Controls.Add(this.btn_FetchWellnessPlanMembership);
            this.groupBox4.Controls.Add(this.btn_DeleteWellnessPlanMembership);
            this.groupBox4.Controls.Add(this.btn_UpdateWellnessPlanMembership);
            this.groupBox4.Controls.Add(this.btn_CreateWellnessPlanMembership);
            this.groupBox4.Location = new System.Drawing.Point(356, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 47);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wellness Plan Membership";
            // 
            // txt_WellnessPlanMembershipId
            // 
            this.txt_WellnessPlanMembershipId.Location = new System.Drawing.Point(283, 18);
            this.txt_WellnessPlanMembershipId.Name = "txt_WellnessPlanMembershipId";
            this.txt_WellnessPlanMembershipId.Size = new System.Drawing.Size(51, 20);
            this.txt_WellnessPlanMembershipId.TabIndex = 14;
            // 
            // btn_FetchWellnessPlanMembership
            // 
            this.btn_FetchWellnessPlanMembership.Location = new System.Drawing.Point(5, 19);
            this.btn_FetchWellnessPlanMembership.Name = "btn_FetchWellnessPlanMembership";
            this.btn_FetchWellnessPlanMembership.Size = new System.Drawing.Size(64, 20);
            this.btn_FetchWellnessPlanMembership.TabIndex = 3;
            this.btn_FetchWellnessPlanMembership.Text = "Fetch";
            this.btn_FetchWellnessPlanMembership.UseVisualStyleBackColor = true;
            this.btn_FetchWellnessPlanMembership.Click += new System.EventHandler(this.btn_FetchWellnessPlanMembership_Click);
            // 
            // btn_DeleteWellnessPlanMembership
            // 
            this.btn_DeleteWellnessPlanMembership.Location = new System.Drawing.Point(213, 19);
            this.btn_DeleteWellnessPlanMembership.Name = "btn_DeleteWellnessPlanMembership";
            this.btn_DeleteWellnessPlanMembership.Size = new System.Drawing.Size(64, 20);
            this.btn_DeleteWellnessPlanMembership.TabIndex = 2;
            this.btn_DeleteWellnessPlanMembership.Text = "Delete";
            this.btn_DeleteWellnessPlanMembership.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateWellnessPlanMembership
            // 
            this.btn_UpdateWellnessPlanMembership.Location = new System.Drawing.Point(144, 19);
            this.btn_UpdateWellnessPlanMembership.Name = "btn_UpdateWellnessPlanMembership";
            this.btn_UpdateWellnessPlanMembership.Size = new System.Drawing.Size(64, 20);
            this.btn_UpdateWellnessPlanMembership.TabIndex = 1;
            this.btn_UpdateWellnessPlanMembership.Text = "Update";
            this.btn_UpdateWellnessPlanMembership.UseVisualStyleBackColor = true;
            this.btn_UpdateWellnessPlanMembership.Click += new System.EventHandler(this.btn_UpdateWellnessPlanMembership_Click);
            // 
            // btn_CreateWellnessPlanMembership
            // 
            this.btn_CreateWellnessPlanMembership.Location = new System.Drawing.Point(75, 19);
            this.btn_CreateWellnessPlanMembership.Name = "btn_CreateWellnessPlanMembership";
            this.btn_CreateWellnessPlanMembership.Size = new System.Drawing.Size(64, 20);
            this.btn_CreateWellnessPlanMembership.TabIndex = 0;
            this.btn_CreateWellnessPlanMembership.Text = "Create";
            this.btn_CreateWellnessPlanMembership.UseVisualStyleBackColor = true;
            this.btn_CreateWellnessPlanMembership.Click += new System.EventHandler(this.btn_CreateWellnessPlanMembership_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_AnimalId);
            this.groupBox5.Controls.Add(this.btn_FetchAnimal);
            this.groupBox5.Controls.Add(this.btn_DeleteAnimal);
            this.groupBox5.Controls.Add(this.btn_UpdateAnimal);
            this.groupBox5.Controls.Add(this.btn_CreateAnimal);
            this.groupBox5.Location = new System.Drawing.Point(10, 110);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 47);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Animal";
            // 
            // txt_AnimalId
            // 
            this.txt_AnimalId.Location = new System.Drawing.Point(283, 19);
            this.txt_AnimalId.Name = "txt_AnimalId";
            this.txt_AnimalId.Size = new System.Drawing.Size(51, 20);
            this.txt_AnimalId.TabIndex = 18;
            // 
            // btn_FetchAnimal
            // 
            this.btn_FetchAnimal.Location = new System.Drawing.Point(5, 19);
            this.btn_FetchAnimal.Name = "btn_FetchAnimal";
            this.btn_FetchAnimal.Size = new System.Drawing.Size(64, 20);
            this.btn_FetchAnimal.TabIndex = 3;
            this.btn_FetchAnimal.Text = "Fetch";
            this.btn_FetchAnimal.UseVisualStyleBackColor = true;
            this.btn_FetchAnimal.Click += new System.EventHandler(this.btn_FetchAnimal_Click);
            // 
            // btn_DeleteAnimal
            // 
            this.btn_DeleteAnimal.Location = new System.Drawing.Point(213, 19);
            this.btn_DeleteAnimal.Name = "btn_DeleteAnimal";
            this.btn_DeleteAnimal.Size = new System.Drawing.Size(64, 20);
            this.btn_DeleteAnimal.TabIndex = 2;
            this.btn_DeleteAnimal.Text = "Delete";
            this.btn_DeleteAnimal.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateAnimal
            // 
            this.btn_UpdateAnimal.Location = new System.Drawing.Point(144, 19);
            this.btn_UpdateAnimal.Name = "btn_UpdateAnimal";
            this.btn_UpdateAnimal.Size = new System.Drawing.Size(64, 20);
            this.btn_UpdateAnimal.TabIndex = 1;
            this.btn_UpdateAnimal.Text = "Update";
            this.btn_UpdateAnimal.UseVisualStyleBackColor = true;
            this.btn_UpdateAnimal.Click += new System.EventHandler(this.btn_UpdateAnimal_Click);
            // 
            // btn_CreateAnimal
            // 
            this.btn_CreateAnimal.Location = new System.Drawing.Point(75, 19);
            this.btn_CreateAnimal.Name = "btn_CreateAnimal";
            this.btn_CreateAnimal.Size = new System.Drawing.Size(64, 20);
            this.btn_CreateAnimal.TabIndex = 0;
            this.btn_CreateAnimal.Text = "Create";
            this.btn_CreateAnimal.UseVisualStyleBackColor = true;
            this.btn_CreateAnimal.Click += new System.EventHandler(this.btn_CreateAnimal_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_UserId);
            this.groupBox6.Controls.Add(this.btn_FetchUser);
            this.groupBox6.Location = new System.Drawing.Point(291, 161);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(131, 47);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "User";
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(74, 19);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(51, 20);
            this.txt_UserId.TabIndex = 18;
            // 
            // btn_FetchUser
            // 
            this.btn_FetchUser.Location = new System.Drawing.Point(5, 19);
            this.btn_FetchUser.Name = "btn_FetchUser";
            this.btn_FetchUser.Size = new System.Drawing.Size(64, 20);
            this.btn_FetchUser.TabIndex = 3;
            this.btn_FetchUser.Text = "Fetch";
            this.btn_FetchUser.UseVisualStyleBackColor = true;
            this.btn_FetchUser.Click += new System.EventHandler(this.btn_FetchUser_Click);
            // 
            // btn_CreateAppoinmentV2
            // 
            this.btn_CreateAppoinmentV2.Location = new System.Drawing.Point(75, 19);
            this.btn_CreateAppoinmentV2.Name = "btn_CreateAppoinmentV2";
            this.btn_CreateAppoinmentV2.Size = new System.Drawing.Size(64, 20);
            this.btn_CreateAppoinmentV2.TabIndex = 0;
            this.btn_CreateAppoinmentV2.Text = "Create";
            this.btn_CreateAppoinmentV2.UseVisualStyleBackColor = true;
            this.btn_CreateAppoinmentV2.Click += new System.EventHandler(this.btn_CreateAppoinmentV2_Click);
            // 
            // btn_FetchAppoinmentV2
            // 
            this.btn_FetchAppoinmentV2.Location = new System.Drawing.Point(5, 19);
            this.btn_FetchAppoinmentV2.Name = "btn_FetchAppoinmentV2";
            this.btn_FetchAppoinmentV2.Size = new System.Drawing.Size(64, 20);
            this.btn_FetchAppoinmentV2.TabIndex = 3;
            this.btn_FetchAppoinmentV2.Text = "Fetch";
            this.btn_FetchAppoinmentV2.UseVisualStyleBackColor = true;
            this.btn_FetchAppoinmentV2.Click += new System.EventHandler(this.btn_FetchAppoinmentV2_Click);
            // 
            // txt_AppointmentV2Id
            // 
            this.txt_AppointmentV2Id.Location = new System.Drawing.Point(211, 19);
            this.txt_AppointmentV2Id.Name = "txt_AppointmentV2Id";
            this.txt_AppointmentV2Id.Size = new System.Drawing.Size(51, 20);
            this.txt_AppointmentV2Id.TabIndex = 18;
            // 
            // btn_UpdateAppoinmentV2
            // 
            this.btn_UpdateAppoinmentV2.Location = new System.Drawing.Point(145, 19);
            this.btn_UpdateAppoinmentV2.Name = "btn_UpdateAppoinmentV2";
            this.btn_UpdateAppoinmentV2.Size = new System.Drawing.Size(64, 20);
            this.btn_UpdateAppoinmentV2.TabIndex = 17;
            this.btn_UpdateAppoinmentV2.Text = "Update";
            this.btn_UpdateAppoinmentV2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_UpdateAppoinmentV2);
            this.groupBox7.Controls.Add(this.txt_AppointmentV2Id);
            this.groupBox7.Controls.Add(this.btn_FetchAppoinmentV2);
            this.groupBox7.Controls.Add(this.btn_CreateAppoinmentV2);
            this.groupBox7.Location = new System.Drawing.Point(428, 161);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(268, 47);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Appointment V2";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txt_ResourceId);
            this.groupBox8.Controls.Add(this.btn_FetchResource);
            this.groupBox8.Location = new System.Drawing.Point(10, 214);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(131, 47);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Resource";
            // 
            // txt_ResourceId
            // 
            this.txt_ResourceId.Location = new System.Drawing.Point(74, 19);
            this.txt_ResourceId.Name = "txt_ResourceId";
            this.txt_ResourceId.Size = new System.Drawing.Size(51, 20);
            this.txt_ResourceId.TabIndex = 18;
            // 
            // btn_FetchResource
            // 
            this.btn_FetchResource.Location = new System.Drawing.Point(5, 19);
            this.btn_FetchResource.Name = "btn_FetchResource";
            this.btn_FetchResource.Size = new System.Drawing.Size(64, 20);
            this.btn_FetchResource.TabIndex = 3;
            this.btn_FetchResource.Text = "Fetch";
            this.btn_FetchResource.UseVisualStyleBackColor = true;
            this.btn_FetchResource.Click += new System.EventHandler(this.btn_FetchResource_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txt_SeparationId);
            this.groupBox9.Controls.Add(this.btn_FetchSeparation);
            this.groupBox9.Location = new System.Drawing.Point(147, 214);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(131, 47);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Separation";
            // 
            // txt_SeparationId
            // 
            this.txt_SeparationId.Location = new System.Drawing.Point(74, 19);
            this.txt_SeparationId.Name = "txt_SeparationId";
            this.txt_SeparationId.Size = new System.Drawing.Size(51, 20);
            this.txt_SeparationId.TabIndex = 18;
            // 
            // btn_FetchSeparation
            // 
            this.btn_FetchSeparation.Location = new System.Drawing.Point(5, 19);
            this.btn_FetchSeparation.Name = "btn_FetchSeparation";
            this.btn_FetchSeparation.Size = new System.Drawing.Size(64, 20);
            this.btn_FetchSeparation.TabIndex = 3;
            this.btn_FetchSeparation.Text = "Fetch";
            this.btn_FetchSeparation.UseVisualStyleBackColor = true;
            this.btn_FetchSeparation.Click += new System.EventHandler(this.btn_FetchSeparation_Click);
            // 
            // HandleEzyVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 390);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_Setting);
            this.Controls.Add(this.rtb_ShowEzyVetInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "HandleEzyVet";
            this.Text = "HandleEzyVet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Setting.ResumeLayout(false);
            this.gb_Setting.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_FetchContact;
        private System.Windows.Forms.Button btn_DeleteContact;
        private System.Windows.Forms.Button btn_UpdateContact;
        private System.Windows.Forms.Button btn_CreateContact;
        private System.Windows.Forms.RichTextBox rtb_ShowEzyVetInfo;
        private System.Windows.Forms.GroupBox gb_Setting;
        private System.Windows.Forms.Button btn_Asyn;
        private System.Windows.Forms.TextBox txt_TempId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Scope;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TokenAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_FetchWellnessPlan;
        private System.Windows.Forms.Button btn_DeleteWellnessPlan;
        private System.Windows.Forms.Button btn_UpdateWellnessPlan;
        private System.Windows.Forms.Button btn_CreateWellnessPlan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_FetchWellnessPlanBenefit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_FetchWellnessPlanMembership;
        private System.Windows.Forms.Button btn_DeleteWellnessPlanMembership;
        private System.Windows.Forms.Button btn_UpdateWellnessPlanMembership;
        private System.Windows.Forms.Button btn_CreateWellnessPlanMembership;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_FetchAnimal;
        private System.Windows.Forms.Button btn_DeleteAnimal;
        private System.Windows.Forms.Button btn_UpdateAnimal;
        private System.Windows.Forms.Button btn_CreateAnimal;
        private System.Windows.Forms.TextBox txt_ContactId;
        private System.Windows.Forms.TextBox txt_WellnessPlanId;
        private System.Windows.Forms.TextBox txt_WellnessPlanBenefitId;
        private System.Windows.Forms.TextBox txt_WellnessPlanMembershipId;
        private System.Windows.Forms.TextBox txt_AnimalId;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.Button btn_FetchUser;
        private System.Windows.Forms.Button btn_CreateAppoinmentV2;
        private System.Windows.Forms.Button btn_FetchAppoinmentV2;
        private System.Windows.Forms.TextBox txt_AppointmentV2Id;
        private System.Windows.Forms.Button btn_UpdateAppoinmentV2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txt_ResourceId;
        private System.Windows.Forms.Button btn_FetchResource;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txt_SeparationId;
        private System.Windows.Forms.Button btn_FetchSeparation;
    }
}

