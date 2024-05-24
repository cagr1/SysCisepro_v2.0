namespace SysCisepro3.Main
{
    partial class FrmNewLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewLogin));
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbxUser = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.ipbxPassword = new FontAwesome.Sharp.IconPictureBox();
            this.ipbxNombre = new FontAwesome.Sharp.IconPictureBox();
            this.pbxCisepro = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbxNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCisepro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(101, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 40);
            this.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnLogin.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnLogin.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnLogin.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnLogin.StateCommon.Border.Rounding = 20;
            this.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnLogin.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnLogin.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnLogin.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnLogin.StateNormal.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLogin.StateNormal.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLogin.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnLogin.StateNormal.Border.Rounding = 20;
            this.btnLogin.StateNormal.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnLogin.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLogin.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnLogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnLogin.StatePressed.Border.Rounding = 20;
            this.btnLogin.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnLogin.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnLogin.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnLogin.StateTracking.Border.Color1 = System.Drawing.Color.LightBlue;
            this.btnLogin.StateTracking.Border.Color2 = System.Drawing.Color.LightBlue;
            this.btnLogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Values.Text = "Ingresar";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbxUser
            // 
            this.cbxUser.AutoResize = false;
            this.cbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxUser.Depth = 0;
            this.cbxUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxUser.DropDownHeight = 432;
            this.cbxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUser.DropDownWidth = 121;
            this.cbxUser.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.IntegralHeight = false;
            this.cbxUser.ItemHeight = 43;
            this.cbxUser.Items.AddRange(new object[] {
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos",
            "Carlos"});
            this.cbxUser.Location = new System.Drawing.Point(113, 144);
            this.cbxUser.MaxDropDownItems = 10;
            this.cbxUser.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(183, 49);
            this.cbxUser.StartIndex = 0;
            this.cbxUser.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(113, 215);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(183, 50);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.ipbxPassword);
            this.materialCard1.Controls.Add(this.ipbxNombre);
            this.materialCard1.Controls.Add(this.pbxCisepro);
            this.materialCard1.Controls.Add(this.btnLogin);
            this.materialCard1.Controls.Add(this.txtPassword);
            this.materialCard1.Controls.Add(this.cbxUser);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(39, 71);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(336, 356);
            this.materialCard1.TabIndex = 11;
            // 
            // ipbxPassword
            // 
            this.ipbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ipbxPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ipbxPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ipbxPassword.IconColor = System.Drawing.Color.DodgerBlue;
            this.ipbxPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbxPassword.IconSize = 31;
            this.ipbxPassword.Location = new System.Drawing.Point(51, 225);
            this.ipbxPassword.Name = "ipbxPassword";
            this.ipbxPassword.Size = new System.Drawing.Size(37, 31);
            this.ipbxPassword.TabIndex = 12;
            this.ipbxPassword.TabStop = false;
            // 
            // ipbxNombre
            // 
            this.ipbxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ipbxNombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ipbxNombre.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ipbxNombre.IconColor = System.Drawing.Color.DodgerBlue;
            this.ipbxNombre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbxNombre.IconSize = 28;
            this.ipbxNombre.Location = new System.Drawing.Point(51, 165);
            this.ipbxNombre.Name = "ipbxNombre";
            this.ipbxNombre.Size = new System.Drawing.Size(37, 28);
            this.ipbxNombre.TabIndex = 11;
            this.ipbxNombre.TabStop = false;
            // 
            // pbxCisepro
            // 
            this.pbxCisepro.Image = ((System.Drawing.Image)(resources.GetObject("pbxCisepro.Image")));
            this.pbxCisepro.Location = new System.Drawing.Point(113, 17);
            this.pbxCisepro.Name = "pbxCisepro";
            this.pbxCisepro.Size = new System.Drawing.Size(106, 106);
            this.pbxCisepro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCisepro.TabIndex = 10;
            this.pbxCisepro.TabStop = false;
            // 
            // FrmNewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 471);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "FrmNewLogin";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmNewLogin_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbxNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCisepro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private MaterialSkin.Controls.MaterialComboBox cbxUser;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pbxCisepro;
        private FontAwesome.Sharp.IconPictureBox ipbxNombre;
        private FontAwesome.Sharp.IconPictureBox ipbxPassword;
        public MaterialSkin.Controls.MaterialTextBox txtPassword;
    }
}