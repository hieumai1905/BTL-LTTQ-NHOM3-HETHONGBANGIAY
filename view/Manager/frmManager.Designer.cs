﻿using BTL_LTTQ_NHOM3_HETHONGBANGIAY.view.usercontrol;
using BTL_LTTQ_NHOM3_HETHONGBANGIAY.view.usercontrol.admin.product;
namespace BTL_LTTQ_NHOM3_HETHONGBANGIAY.view.manager
{
    partial class frmManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pictureStore = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnInfomation = new System.Windows.Forms.Button();
            this.pnlSiderBar = new System.Windows.Forms.Panel();
            this.pnlSidbarOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameEmployee = new System.Windows.Forms.Label();
            this.nameRole = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTurnOff = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.idEmployee = new System.Windows.Forms.Label();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.homeControl = new BTL_LTTQ_NHOM3_HETHONGBANGIAY.view.usercontrol.HomeControl();
            this.cartControl = new BTL_LTTQ_NHOM3_HETHONGBANGIAY.view.usercontrol.CartControl();
            this.listProduct = new BTL_LTTQ_NHOM3_HETHONGBANGIAY.view.usercontrol.admin.product.ListProduct();
            this.storeControl = new BTL_LTTQ_NHOM3_HETHONGBANGIAY.view.usercontrol.StoreControl();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStore)).BeginInit();
            this.pnlSiderBar.SuspendLayout();
            this.pnlSidbarOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblSlogan);
            this.panel2.Controls.Add(this.pictureStore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 120);
            this.panel2.TabIndex = 1;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(61, 90);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(83, 11);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "CAO HƠN ĐI XA HƠN";
            // 
            // pictureStore
            // 
            this.pictureStore.Image = ((System.Drawing.Image)(resources.GetObject("pictureStore.Image")));
            this.pictureStore.Location = new System.Drawing.Point(14, 7);
            this.pictureStore.Name = "pictureStore";
            this.pictureStore.Size = new System.Drawing.Size(178, 94);
            this.pictureStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStore.TabIndex = 1;
            this.pictureStore.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 54);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "      Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSell
            // 
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.Image")));
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Location = new System.Drawing.Point(3, 63);
            this.btnSell.Name = "btnSell";
            this.btnSell.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSell.Size = new System.Drawing.Size(200, 54);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "      Bán hàng";
            this.btnSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(3, 123);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(200, 54);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "      Sản phẩm";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBill
            // 
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(3, 183);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(200, 54);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "      Hoá đơn";
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(3, 243);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(200, 54);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "      Nhân viên";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(3, 303);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(200, 54);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "      Khách hàng";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnInfomation
            // 
            this.btnInfomation.BackColor = System.Drawing.Color.White;
            this.btnInfomation.FlatAppearance.BorderSize = 0;
            this.btnInfomation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfomation.ForeColor = System.Drawing.SystemColors.Info;
            this.btnInfomation.Image = ((System.Drawing.Image)(resources.GetObject("btnInfomation.Image")));
            this.btnInfomation.Location = new System.Drawing.Point(80, 787);
            this.btnInfomation.Name = "btnInfomation";
            this.btnInfomation.Size = new System.Drawing.Size(35, 35);
            this.btnInfomation.TabIndex = 7;
            this.btnInfomation.UseVisualStyleBackColor = false;
            // 
            // pnlSiderBar
            // 
            this.pnlSiderBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSiderBar.Controls.Add(this.pnlSidbarOption);
            this.pnlSiderBar.Controls.Add(this.panel2);
            this.pnlSiderBar.Controls.Add(this.btnInfomation);
            this.pnlSiderBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSiderBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSiderBar.Name = "pnlSiderBar";
            this.pnlSiderBar.Size = new System.Drawing.Size(206, 825);
            this.pnlSiderBar.TabIndex = 0;
            // 
            // pnlSidbarOption
            // 
            this.pnlSidbarOption.BackColor = System.Drawing.Color.White;
            this.pnlSidbarOption.Controls.Add(this.btnHome);
            this.pnlSidbarOption.Controls.Add(this.btnSell);
            this.pnlSidbarOption.Controls.Add(this.btnProduct);
            this.pnlSidbarOption.Controls.Add(this.btnBill);
            this.pnlSidbarOption.Controls.Add(this.btnEmployee);
            this.pnlSidbarOption.Controls.Add(this.btnCustomer);
            this.pnlSidbarOption.Controls.Add(this.btn);
            this.pnlSidbarOption.Location = new System.Drawing.Point(0, 126);
            this.pnlSidbarOption.Name = "pnlSidbarOption";
            this.pnlSidbarOption.Size = new System.Drawing.Size(206, 449);
            this.pnlSidbarOption.TabIndex = 9;
            // 
            // btn
            // 
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.Location = new System.Drawing.Point(3, 363);
            this.btn.Name = "btn";
            this.btn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn.Size = new System.Drawing.Size(200, 54);
            this.btn.TabIndex = 8;
            this.btn.Text = "      Nhà cung cấp";
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // nameEmployee
            // 
            this.nameEmployee.AutoSize = true;
            this.nameEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEmployee.Location = new System.Drawing.Point(73, 9);
            this.nameEmployee.Name = "nameEmployee";
            this.nameEmployee.Size = new System.Drawing.Size(112, 21);
            this.nameEmployee.TabIndex = 16;
            this.nameEmployee.Text = "Mai Văn Hiếu";
            // 
            // nameRole
            // 
            this.nameRole.AutoSize = true;
            this.nameRole.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRole.Location = new System.Drawing.Point(74, 49);
            this.nameRole.Name = "nameRole";
            this.nameRole.Size = new System.Drawing.Size(50, 17);
            this.nameRole.TabIndex = 17;
            this.nameRole.Text = "Admin";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(1195, 22);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(35, 33);
            this.btnSetting.TabIndex = 18;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(-3, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 74);
            this.label3.TabIndex = 19;
            // 
            // btnTurnOff
            // 
            this.btnTurnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnTurnOff.FlatAppearance.BorderSize = 0;
            this.btnTurnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnOff.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnTurnOff.IconColor = System.Drawing.Color.Crimson;
            this.btnTurnOff.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTurnOff.IconSize = 31;
            this.btnTurnOff.Location = new System.Drawing.Point(1315, 22);
            this.btnTurnOff.Name = "btnTurnOff";
            this.btnTurnOff.Size = new System.Drawing.Size(35, 33);
            this.btnTurnOff.TabIndex = 20;
            this.btnTurnOff.UseVisualStyleBackColor = false;
            this.btnTurnOff.Click += new System.EventHandler(this.btnTurnOff_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 31;
            this.iconButton2.Location = new System.Drawing.Point(1255, 22);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 33);
            this.iconButton2.TabIndex = 21;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.iconButton2);
            this.pnlHeader.Controls.Add(this.btnTurnOff);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.btnSetting);
            this.pnlHeader.Controls.Add(this.nameRole);
            this.pnlHeader.Controls.Add(this.nameEmployee);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.idEmployee);
            this.pnlHeader.CustomBorderColor = System.Drawing.Color.LightGray;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(206, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1360, 70);
            this.pnlHeader.TabIndex = 12;
            // 
            // idEmployee
            // 
            this.idEmployee.AutoSize = true;
            this.idEmployee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEmployee.Location = new System.Drawing.Point(135, 49);
            this.idEmployee.Name = "idEmployee";
            this.idEmployee.Size = new System.Drawing.Size(0, 17);
            this.idEmployee.TabIndex = 22;
            this.idEmployee.Visible = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlContainer.Controls.Add(this.homeControl);
            this.pnlContainer.Controls.Add(this.cartControl);
            this.pnlContainer.Controls.Add(this.listProduct);
            this.pnlContainer.Controls.Add(this.storeControl);
            this.pnlContainer.Location = new System.Drawing.Point(206, 93);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1360, 732);
            this.pnlContainer.TabIndex = 13;
            // 
            // homeControl
            // 
            this.homeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.homeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.homeControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeControl.Location = new System.Drawing.Point(0, 2);
            this.homeControl.Name = "homeControl";
            this.homeControl.Size = new System.Drawing.Size(1360, 730);
            this.homeControl.TabIndex = 0;
            // 
            // cartControl
            // 
            this.cartControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.cartControl.Location = new System.Drawing.Point(0, 2);
            this.cartControl.Name = "cartControl";
            this.cartControl.Size = new System.Drawing.Size(1360, 730);
            this.cartControl.TabIndex = 3;
            // 
            // listProduct
            // 
            this.listProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.listProduct.Location = new System.Drawing.Point(0, 0);
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(1360, 732);
            this.listProduct.TabIndex = 4;
            // 
            // storeControl
            // 
            this.storeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.storeControl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.storeControl.Location = new System.Drawing.Point(0, 0);
            this.storeControl.Name = "storeControl";
            this.storeControl.Size = new System.Drawing.Size(1360, 732);
            this.storeControl.TabIndex = 5;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1566, 825);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSiderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStore)).EndInit();
            this.pnlSiderBar.ResumeLayout(false);
            this.pnlSidbarOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.PictureBox pictureStore;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnInfomation;
        private System.Windows.Forms.Panel pnlSiderBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected internal System.Windows.Forms.Label nameEmployee;
        protected internal System.Windows.Forms.Label nameRole;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnTurnOff;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private usercontrol.HomeControl homeControl;
        private usercontrol.CartControl cartControl;
        private StoreControl storeControl;
        private ListProduct listProduct;
        protected internal System.Windows.Forms.Label idEmployee;
        private System.Windows.Forms.FlowLayoutPanel pnlSidbarOption;
        private System.Windows.Forms.Button btn;
    }
}