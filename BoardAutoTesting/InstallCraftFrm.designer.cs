namespace BoardAutoTesting
{
    partial class InstallCraftFrm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtCraftId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ipMcu = new DevComponents.Editors.IpAddressInput();
            this.ipAte = new DevComponents.Editors.IpAddressInput();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.cbxLineId = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxRouteId = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.ipMcu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipAte)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "��̨��ţ�";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "���壺";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(94, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "վλ��";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 99);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(94, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "��Ƭ��IP��ַ��";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 128);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(94, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "��̨IP��ַ��";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtCraftId
            // 
            // 
            // 
            // 
            this.txtCraftId.Border.Class = "TextBoxBorder";
            this.txtCraftId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCraftId.Location = new System.Drawing.Point(112, 14);
            this.txtCraftId.Name = "txtCraftId";
            this.txtCraftId.ReadOnly = true;
            this.txtCraftId.Size = new System.Drawing.Size(157, 25);
            this.txtCraftId.TabIndex = 1;
            // 
            // ipMcu
            // 
            this.ipMcu.AutoOverwrite = true;
            // 
            // 
            // 
            this.ipMcu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipMcu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipMcu.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ipMcu.ButtonFreeText.Visible = true;
            this.ipMcu.Location = new System.Drawing.Point(112, 97);
            this.ipMcu.Name = "ipMcu";
            this.ipMcu.Size = new System.Drawing.Size(157, 25);
            this.ipMcu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipMcu.TabIndex = 2;
            // 
            // ipAte
            // 
            this.ipAte.AutoOverwrite = true;
            // 
            // 
            // 
            this.ipAte.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipAte.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAte.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ipAte.ButtonFreeText.Visible = true;
            this.ipAte.Location = new System.Drawing.Point(112, 124);
            this.ipAte.Name = "ipAte";
            this.ipAte.Size = new System.Drawing.Size(157, 25);
            this.ipAte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipAte.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Location = new System.Drawing.Point(288, 132);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 38);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "����";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Location = new System.Drawing.Point(372, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 38);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "���";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxLineId
            // 
            this.cbxLineId.DisplayMember = "Text";
            this.cbxLineId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLineId.FormattingEnabled = true;
            this.cbxLineId.ItemHeight = 15;
            this.cbxLineId.Location = new System.Drawing.Point(112, 43);
            this.cbxLineId.Name = "cbxLineId";
            this.cbxLineId.Size = new System.Drawing.Size(157, 21);
            this.cbxLineId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxLineId.TabIndex = 4;
            // 
            // cbxRouteId
            // 
            this.cbxRouteId.DisplayMember = "Text";
            this.cbxRouteId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRouteId.FormattingEnabled = true;
            this.cbxRouteId.ItemHeight = 15;
            this.cbxRouteId.Location = new System.Drawing.Point(112, 70);
            this.cbxRouteId.Name = "cbxRouteId";
            this.cbxRouteId.Size = new System.Drawing.Size(157, 21);
            this.cbxRouteId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxRouteId.TabIndex = 4;
            // 
            // InstallCraftFrm
            // 
            this.ClientSize = new System.Drawing.Size(461, 182);
            this.Controls.Add(this.cbxRouteId);
            this.Controls.Add(this.cbxLineId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.ipAte);
            this.Controls.Add(this.ipMcu);
            this.Controls.Add(this.txtCraftId);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallCraftFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "������̨";
            this.Load += new System.EventHandler(this.InstallCraftFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ipMcu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipAte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCraftId;
        private DevComponents.Editors.IpAddressInput ipMcu;
        private DevComponents.Editors.IpAddressInput ipAte;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxLineId;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxRouteId;
    }
}