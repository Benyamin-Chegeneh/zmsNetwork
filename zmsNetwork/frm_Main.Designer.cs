namespace zmsNetwork
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.pic_connect = new System.Windows.Forms.PictureBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_listdns = new System.Windows.Forms.Label();
            this.cmb_listdns = new System.Windows.Forms.ComboBox();
            this.pic_disconnect = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.btn_lastconnection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_disconnect)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_connect
            // 
            this.pic_connect.Image = global::zmsNetwork.Properties.Resources.switch_off;
            this.pic_connect.Location = new System.Drawing.Point(135, 68);
            this.pic_connect.Margin = new System.Windows.Forms.Padding(4);
            this.pic_connect.Name = "pic_connect";
            this.pic_connect.Size = new System.Drawing.Size(149, 148);
            this.pic_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_connect.TabIndex = 0;
            this.pic_connect.TabStop = false;
            this.ToolTip.SetToolTip(this.pic_connect, "Disconnected");
            this.pic_connect.Click += new System.EventHandler(this.pic_connection_Click);
            // 
            // lbl_listdns
            // 
            this.lbl_listdns.AutoSize = true;
            this.lbl_listdns.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listdns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(196)))));
            this.lbl_listdns.Location = new System.Drawing.Point(181, 346);
            this.lbl_listdns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_listdns.Name = "lbl_listdns";
            this.lbl_listdns.Size = new System.Drawing.Size(55, 15);
            this.lbl_listdns.TabIndex = 2;
            this.lbl_listdns.Text = "List DNS";
            this.ToolTip.SetToolTip(this.lbl_listdns, "List DNS");
            // 
            // cmb_listdns
            // 
            this.cmb_listdns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.cmb_listdns.DropDownHeight = 289;
            this.cmb_listdns.DropDownWidth = 395;
            this.cmb_listdns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_listdns.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_listdns.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_listdns.FormattingEnabled = true;
            this.cmb_listdns.IntegralHeight = false;
            this.cmb_listdns.Items.AddRange(new object[] {
            "403",
            "Shecan",
            "Radar",
            "Electro",
            "Begzar",
            "Google",
            "Cloudflare",
            "Quad9",
            "OpenDNS",
            "403 #2",
            "OpenDNS #2",
            "Quad9 #2",
            "Shecan #2",
            "Radar #2",
            "Electro #2",
            "Electro #3",
            "Electro #4",
            "Begzar #2",
            "Cloudflare #2",
            "Cloudflare #3",
            "Combined DNS 1",
            "Combined DNS 2",
            "Combined DNS 3",
            "Combined DNS 4",
            "Combined DNS 5",
            "Combined DNS 6",
            "Combined DNS 7",
            "Combined DNS 8",
            "Combined DNS 9",
            "Combined DNS 10",
            "Combined DNS 11",
            "Combined DNS 12",
            "Combined DNS 13",
            "Combined DNS 14",
            "Combined DNS 15",
            "Combined DNS 16",
            "Combined DNS 17",
            "Combined DNS 18",
            "Combined DNS 19",
            "Combined DNS 20",
            "Combined DNS 21",
            "Combined DNS 22",
            "Combined DNS 23",
            "Combined DNS 24",
            "Combined DNS 25",
            "Combined DNS 26",
            "Combined DNS 27",
            "Combined DNS 28",
            "Combined DNS 29"});
            this.cmb_listdns.Location = new System.Drawing.Point(0, 365);
            this.cmb_listdns.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_listdns.Name = "cmb_listdns";
            this.cmb_listdns.Size = new System.Drawing.Size(405, 23);
            this.cmb_listdns.TabIndex = 3;
            this.ToolTip.SetToolTip(this.cmb_listdns, "List DNS");
            this.cmb_listdns.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_listdns_KeyUp);
            // 
            // pic_disconnect
            // 
            this.pic_disconnect.Image = global::zmsNetwork.Properties.Resources.switch_on;
            this.pic_disconnect.Location = new System.Drawing.Point(135, 68);
            this.pic_disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.pic_disconnect.Name = "pic_disconnect";
            this.pic_disconnect.Size = new System.Drawing.Size(149, 148);
            this.pic_disconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_disconnect.TabIndex = 4;
            this.pic_disconnect.TabStop = false;
            this.ToolTip.SetToolTip(this.pic_disconnect, "Connected");
            this.pic_disconnect.Visible = false;
            this.pic_disconnect.Click += new System.EventHandler(this.pic_disconnect_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(196)))));
            this.lbl_status.Location = new System.Drawing.Point(167, 201);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(90, 15);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Not Connected";
            this.ToolTip.SetToolTip(this.lbl_status, "Status");
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_title.Location = new System.Drawing.Point(166, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(105, 19);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "zmsNetwork";
            this.ToolTip.SetToolTip(this.lbl_title, "Zero Millisecond Network");
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(196)))));
            this.lbl_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_exit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.lbl_exit.Location = new System.Drawing.Point(377, 9);
            this.lbl_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(15, 15);
            this.lbl_exit.TabIndex = 1;
            this.lbl_exit.Text = "X";
            this.lbl_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // btn_lastconnection
            // 
            this.btn_lastconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lastconnection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lastconnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(196)))));
            this.btn_lastconnection.Location = new System.Drawing.Point(135, 497);
            this.btn_lastconnection.Name = "btn_lastconnection";
            this.btn_lastconnection.Size = new System.Drawing.Size(149, 72);
            this.btn_lastconnection.TabIndex = 7;
            this.btn_lastconnection.Text = "Connect\r\nto \r\nLast Connection";
            this.btn_lastconnection.UseVisualStyleBackColor = true;
            this.btn_lastconnection.Visible = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(405, 675);
            this.Controls.Add(this.btn_lastconnection);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pic_disconnect);
            this.Controls.Add(this.cmb_listdns);
            this.Controls.Add(this.lbl_listdns);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.pic_connect);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zmsNetwork";
            ((System.ComponentModel.ISupportInitialize)(this.pic_connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_disconnect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_connect;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label lbl_listdns;
        private System.Windows.Forms.ComboBox cmb_listdns;
        private System.Windows.Forms.PictureBox pic_disconnect;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_lastconnection;
    }
}

