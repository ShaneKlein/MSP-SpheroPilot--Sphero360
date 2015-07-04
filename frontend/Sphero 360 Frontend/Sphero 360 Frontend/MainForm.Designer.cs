namespace Sphero_360_Frontend
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.speedTimer = new System.Windows.Forms.Timer(this.components);
            this.inputTimer = new System.Windows.Forms.Timer(this.components);
            this._btnConnectToBackend = new System.Windows.Forms.Button();
            this._txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtPort = new System.Windows.Forms.NumericUpDown();
            this._txtMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._btnDisconnectFromBackend = new System.Windows.Forms.Button();
            this._txtTurnRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._txtBoostSpeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.spheroColorDialog = new System.Windows.Forms.ColorDialog();
            this._btnShowColorDialog = new System.Windows.Forms.Button();
            this._btnListControls = new System.Windows.Forms.Button();
            this.readTimer = new System.Windows.Forms.Timer(this.components);
            this.rumbleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._txtPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtTurnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtBoostSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // speedTimer
            // 
            this.speedTimer.Enabled = true;
            this.speedTimer.Interval = 800;
            this.speedTimer.Tick += new System.EventHandler(this.speedTimer_Tick);
            // 
            // inputTimer
            // 
            this.inputTimer.Enabled = true;
            this.inputTimer.Tick += new System.EventHandler(this.inputTimer_Tick);
            // 
            // _btnConnectToBackend
            // 
            this._btnConnectToBackend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnConnectToBackend.BackgroundImage")));
            this._btnConnectToBackend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConnectToBackend.ForeColor = System.Drawing.Color.White;
            this._btnConnectToBackend.Location = new System.Drawing.Point(14, 12);
            this._btnConnectToBackend.Name = "_btnConnectToBackend";
            this._btnConnectToBackend.Size = new System.Drawing.Size(303, 23);
            this._btnConnectToBackend.TabIndex = 1;
            this._btnConnectToBackend.Text = "Connect to Backend";
            this._btnConnectToBackend.UseVisualStyleBackColor = true;
            this._btnConnectToBackend.Click += new System.EventHandler(this._btnConnectToBackend_Click);
            // 
            // _txtServer
            // 
            this._txtServer.BackColor = System.Drawing.Color.LightCyan;
            this._txtServer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtServer.Location = new System.Drawing.Point(77, 70);
            this._txtServer.Name = "_txtServer";
            this._txtServer.Size = new System.Drawing.Size(240, 21);
            this._txtServer.TabIndex = 2;
            this._txtServer.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // _txtPort
            // 
            this._txtPort.BackColor = System.Drawing.Color.LightCyan;
            this._txtPort.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPort.Location = new System.Drawing.Point(77, 96);
            this._txtPort.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this._txtPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtPort.Name = "_txtPort";
            this._txtPort.Size = new System.Drawing.Size(59, 21);
            this._txtPort.TabIndex = 6;
            this._txtPort.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            // 
            // _txtMaxSpeed
            // 
            this._txtMaxSpeed.BackColor = System.Drawing.Color.LightCyan;
            this._txtMaxSpeed.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtMaxSpeed.Location = new System.Drawing.Point(115, 160);
            this._txtMaxSpeed.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this._txtMaxSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtMaxSpeed.Name = "_txtMaxSpeed";
            this._txtMaxSpeed.Size = new System.Drawing.Size(59, 21);
            this._txtMaxSpeed.TabIndex = 8;
            this._txtMaxSpeed.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Speed";
            // 
            // _btnDisconnectFromBackend
            // 
            this._btnDisconnectFromBackend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnDisconnectFromBackend.BackgroundImage")));
            this._btnDisconnectFromBackend.Enabled = false;
            this._btnDisconnectFromBackend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDisconnectFromBackend.ForeColor = System.Drawing.Color.White;
            this._btnDisconnectFromBackend.Location = new System.Drawing.Point(14, 41);
            this._btnDisconnectFromBackend.Name = "_btnDisconnectFromBackend";
            this._btnDisconnectFromBackend.Size = new System.Drawing.Size(303, 23);
            this._btnDisconnectFromBackend.TabIndex = 9;
            this._btnDisconnectFromBackend.Text = "Disconnect from Backend";
            this._btnDisconnectFromBackend.UseVisualStyleBackColor = true;
            this._btnDisconnectFromBackend.Click += new System.EventHandler(this._btnDisconnectFromBackend_Click);
            // 
            // _txtTurnRate
            // 
            this._txtTurnRate.BackColor = System.Drawing.Color.LightCyan;
            this._txtTurnRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTurnRate.Location = new System.Drawing.Point(115, 212);
            this._txtTurnRate.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this._txtTurnRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtTurnRate.Name = "_txtTurnRate";
            this._txtTurnRate.Size = new System.Drawing.Size(59, 21);
            this._txtTurnRate.TabIndex = 11;
            this._txtTurnRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Turn Rate";
            // 
            // _txtBoostSpeed
            // 
            this._txtBoostSpeed.BackColor = System.Drawing.Color.LightCyan;
            this._txtBoostSpeed.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtBoostSpeed.Location = new System.Drawing.Point(115, 186);
            this._txtBoostSpeed.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this._txtBoostSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._txtBoostSpeed.Name = "_txtBoostSpeed";
            this._txtBoostSpeed.Size = new System.Drawing.Size(59, 21);
            this._txtBoostSpeed.TabIndex = 13;
            this._txtBoostSpeed.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Boost Speed";
            // 
            // spheroColorDialog
            // 
            this.spheroColorDialog.Color = System.Drawing.Color.LimeGreen;
            // 
            // _btnShowColorDialog
            // 
            this._btnShowColorDialog.BackgroundImage = global::Sphero_360_Frontend.Properties.Resources.button_tall;
            this._btnShowColorDialog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnShowColorDialog.ForeColor = System.Drawing.Color.White;
            this._btnShowColorDialog.Location = new System.Drawing.Point(178, 160);
            this._btnShowColorDialog.Name = "_btnShowColorDialog";
            this._btnShowColorDialog.Size = new System.Drawing.Size(139, 73);
            this._btnShowColorDialog.TabIndex = 14;
            this._btnShowColorDialog.Text = "Choose Sphero Color";
            this._btnShowColorDialog.UseVisualStyleBackColor = true;
            this._btnShowColorDialog.Click += new System.EventHandler(this._btnShowColorDialog_Click);
            // 
            // _btnListControls
            // 
            this._btnListControls.BackgroundImage = global::Sphero_360_Frontend.Properties.Resources.button;
            this._btnListControls.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnListControls.ForeColor = System.Drawing.Color.White;
            this._btnListControls.Location = new System.Drawing.Point(14, 269);
            this._btnListControls.Name = "_btnListControls";
            this._btnListControls.Size = new System.Drawing.Size(303, 23);
            this._btnListControls.TabIndex = 15;
            this._btnListControls.Text = "Show Gamepad Controls";
            this._btnListControls.UseVisualStyleBackColor = true;
            this._btnListControls.Click += new System.EventHandler(this._btnListControls_Click);
            // 
            // readTimer
            // 
            this.readTimer.Enabled = true;
            this.readTimer.Interval = 50;
            this.readTimer.Tick += new System.EventHandler(this.readTimer_Tick);
            // 
            // rumbleTimer
            // 
            this.rumbleTimer.Interval = 200;
            this.rumbleTimer.Tick += new System.EventHandler(this.rumbleTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sphero_360_Frontend.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(331, 304);
            this.Controls.Add(this._btnListControls);
            this.Controls.Add(this._btnShowColorDialog);
            this.Controls.Add(this._txtBoostSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtTurnRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnDisconnectFromBackend);
            this.Controls.Add(this._txtMaxSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtServer);
            this.Controls.Add(this._btnConnectToBackend);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Sphero360 Frontend";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._txtPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtTurnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtBoostSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer speedTimer;
        private System.Windows.Forms.Timer inputTimer;
        private System.Windows.Forms.Button _btnConnectToBackend;
        private System.Windows.Forms.TextBox _txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _txtPort;
        private System.Windows.Forms.NumericUpDown _txtMaxSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btnDisconnectFromBackend;
        private System.Windows.Forms.NumericUpDown _txtTurnRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _txtBoostSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog spheroColorDialog;
        private System.Windows.Forms.Button _btnShowColorDialog;
        private System.Windows.Forms.Button _btnListControls;
        private System.Windows.Forms.Timer readTimer;
        private System.Windows.Forms.Timer rumbleTimer;
    }
}

