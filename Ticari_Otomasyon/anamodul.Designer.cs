﻿namespace Ticari_Otomasyon
{
    partial class anamodul
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anamodul));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAnaSayfa,
            this.btnUrunler,
            this.btnStoklar,
            this.btnMusteriler,
            this.btnFirmalar,
            this.btnPersoneller,
            this.btnGiderler,
            this.btnKasa,
            this.barButtonItem16});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1284, 150);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Caption = "Ana Sayfa";
            this.btnAnaSayfa.Id = 1;
            this.btnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.Image")));
            this.btnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.LargeImage")));
            this.btnAnaSayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnaSayfa_ItemClick);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "Ürünler";
            this.btnUrunler.Id = 2;
            this.btnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.Image")));
            this.btnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.LargeImage")));
            this.btnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnStoklar
            // 
            this.btnStoklar.Caption = "Stoklar";
            this.btnStoklar.Enabled = false;
            this.btnStoklar.Id = 3;
            this.btnStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.Image")));
            this.btnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.LargeImage")));
            this.btnStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStoklar_ItemClick);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "Üyeler";
            this.btnMusteriler.Id = 4;
            this.btnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.Image")));
            this.btnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.LargeImage")));
            this.btnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
            // 
            // btnFirmalar
            // 
            this.btnFirmalar.Caption = "Firmalar";
            this.btnFirmalar.Enabled = false;
            this.btnFirmalar.Id = 5;
            this.btnFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.Image")));
            this.btnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.LargeImage")));
            this.btnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFirmalar.Name = "btnFirmalar";
            this.btnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirmalar_ItemClick);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Caption = "Personeller";
            this.btnPersoneller.Id = 6;
            this.btnPersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.ImageOptions.Image")));
            this.btnPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.ImageOptions.LargeImage")));
            this.btnPersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersoneller_ItemClick);
            // 
            // btnGiderler
            // 
            this.btnGiderler.Caption = "Giderler";
            this.btnGiderler.Enabled = false;
            this.btnGiderler.Id = 7;
            this.btnGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.Image")));
            this.btnGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.LargeImage")));
            this.btnGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderler_ItemClick);
            // 
            // btnKasa
            // 
            this.btnKasa.Caption = "Üyelik";
            this.btnKasa.Id = 8;
            this.btnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.Image")));
            this.btnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.LargeImage")));
            this.btnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasa_ItemClick);
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "barButtonItem16";
            this.barButtonItem16.Id = 14;
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ticari Otomasyon";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKasa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ana Sayfa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Ana Sayfa";
            this.barButtonItem3.Id = 1;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // anamodul
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "anamodul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticari Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem btnStoklar;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.BarButtonItem btnFirmalar;
        private DevExpress.XtraBars.BarButtonItem btnPersoneller;
        private DevExpress.XtraBars.BarButtonItem btnGiderler;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

