namespace CarDbApp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._cmbCarId = new System.Windows.Forms.ComboBox();
            this._cmbState = new System.Windows.Forms.ComboBox();
            this._cmbSpz = new System.Windows.Forms.ComboBox();
            this._cmbModel = new System.Windows.Forms.ComboBox();
            this._cmbLastUpdate = new System.Windows.Forms.ComboBox();
            this._cmbFirstDriver = new System.Windows.Forms.ComboBox();
            this._btnOpenCsv = new System.Windows.Forms.Button();
            this._btnVerify = new System.Windows.Forms.Button();
            this._pnlCarRecords = new System.Windows.Forms.Panel();
            this._btnUpsert = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnLoadDb = new System.Windows.Forms.Button();
            this._btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 307);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CarId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "SPZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "LastUpdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "FirstDriver";
            // 
            // _cmbCarId
            // 
            this._cmbCarId.FormattingEnabled = true;
            this._cmbCarId.Location = new System.Drawing.Point(116, 4);
            this._cmbCarId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbCarId.Name = "_cmbCarId";
            this._cmbCarId.Size = new System.Drawing.Size(133, 23);
            this._cmbCarId.TabIndex = 7;
            // 
            // _cmbState
            // 
            this._cmbState.FormattingEnabled = true;
            this._cmbState.Location = new System.Drawing.Point(116, 30);
            this._cmbState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbState.Name = "_cmbState";
            this._cmbState.Size = new System.Drawing.Size(133, 23);
            this._cmbState.TabIndex = 8;
            // 
            // _cmbSpz
            // 
            this._cmbSpz.FormattingEnabled = true;
            this._cmbSpz.Location = new System.Drawing.Point(116, 54);
            this._cmbSpz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbSpz.Name = "_cmbSpz";
            this._cmbSpz.Size = new System.Drawing.Size(133, 23);
            this._cmbSpz.TabIndex = 9;
            // 
            // _cmbModel
            // 
            this._cmbModel.FormattingEnabled = true;
            this._cmbModel.Location = new System.Drawing.Point(116, 89);
            this._cmbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbModel.Name = "_cmbModel";
            this._cmbModel.Size = new System.Drawing.Size(133, 23);
            this._cmbModel.TabIndex = 10;
            // 
            // _cmbLastUpdate
            // 
            this._cmbLastUpdate.FormattingEnabled = true;
            this._cmbLastUpdate.Location = new System.Drawing.Point(116, 124);
            this._cmbLastUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbLastUpdate.Name = "_cmbLastUpdate";
            this._cmbLastUpdate.Size = new System.Drawing.Size(133, 23);
            this._cmbLastUpdate.TabIndex = 11;
            // 
            // _cmbFirstDriver
            // 
            this._cmbFirstDriver.FormattingEnabled = true;
            this._cmbFirstDriver.Location = new System.Drawing.Point(116, 154);
            this._cmbFirstDriver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbFirstDriver.Name = "_cmbFirstDriver";
            this._cmbFirstDriver.Size = new System.Drawing.Size(133, 23);
            this._cmbFirstDriver.TabIndex = 12;
            // 
            // _btnOpenCsv
            // 
            this._btnOpenCsv.Location = new System.Drawing.Point(10, 185);
            this._btnOpenCsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnOpenCsv.Name = "_btnOpenCsv";
            this._btnOpenCsv.Size = new System.Drawing.Size(82, 31);
            this._btnOpenCsv.TabIndex = 13;
            this._btnOpenCsv.Text = "Open csv";
            this._btnOpenCsv.UseVisualStyleBackColor = true;
            this._btnOpenCsv.Click += new System.EventHandler(this._btnOpenCsv_Click);
            // 
            // _btnVerify
            // 
            this._btnVerify.Enabled = false;
            this._btnVerify.Location = new System.Drawing.Point(102, 185);
            this._btnVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnVerify.Name = "_btnVerify";
            this._btnVerify.Size = new System.Drawing.Size(82, 31);
            this._btnVerify.TabIndex = 14;
            this._btnVerify.Text = "Verify csv ";
            this._btnVerify.UseVisualStyleBackColor = true;
            this._btnVerify.Click += new System.EventHandler(this._btnVerify_Click);
            // 
            // _pnlCarRecords
            // 
            this._pnlCarRecords.AutoScroll = true;
            this._pnlCarRecords.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._pnlCarRecords.Location = new System.Drawing.Point(280, 7);
            this._pnlCarRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pnlCarRecords.Name = "_pnlCarRecords";
            this._pnlCarRecords.Size = new System.Drawing.Size(1305, 322);
            this._pnlCarRecords.TabIndex = 15;
            // 
            // _btnUpsert
            // 
            this._btnUpsert.Location = new System.Drawing.Point(189, 185);
            this._btnUpsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnUpsert.Name = "_btnUpsert";
            this._btnUpsert.Size = new System.Drawing.Size(82, 31);
            this._btnUpsert.TabIndex = 16;
            this._btnUpsert.Text = "Upsert";
            this._btnUpsert.UseVisualStyleBackColor = true;
            this._btnUpsert.Click += new System.EventHandler(this._btnUpsert_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(101, 220);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(82, 31);
            this._btnAdd.TabIndex = 17;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnLoadDb
            // 
            this._btnLoadDb.Location = new System.Drawing.Point(10, 220);
            this._btnLoadDb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnLoadDb.Name = "_btnLoadDb";
            this._btnLoadDb.Size = new System.Drawing.Size(82, 31);
            this._btnLoadDb.TabIndex = 19;
            this._btnLoadDb.Text = "LoadDb";
            this._btnLoadDb.UseVisualStyleBackColor = true;
            this._btnLoadDb.Click += new System.EventHandler(this._btnLoadDb_Click);
            // 
            // _btnClear
            // 
            this._btnClear.Location = new System.Drawing.Point(189, 220);
            this._btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(82, 31);
            this._btnClear.TabIndex = 20;
            this._btnClear.Text = "Clear view";
            this._btnClear.UseVisualStyleBackColor = true;
            this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 338);
            this.Controls.Add(this._btnClear);
            this.Controls.Add(this._btnLoadDb);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._btnUpsert);
            this.Controls.Add(this._pnlCarRecords);
            this.Controls.Add(this._btnVerify);
            this.Controls.Add(this._btnOpenCsv);
            this.Controls.Add(this._cmbFirstDriver);
            this.Controls.Add(this._cmbLastUpdate);
            this.Controls.Add(this._cmbModel);
            this.Controls.Add(this._cmbSpz);
            this.Controls.Add(this._cmbState);
            this.Controls.Add(this._cmbCarId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox _cmbCarId;
        private ComboBox _cmbState;
        private ComboBox _cmbSpz;
        private ComboBox _cmbModel;
        private ComboBox _cmbLastUpdate;
        private ComboBox _cmbFirstDriver;
        private Button _btnOpenCsv;
        private Button _btnVerify;
        private Panel _pnlCarRecords;
        private Button _btnUpsert;
        private Button _btnAdd;
        private Button _btnLoadDb;
        private Button _btnClear;
    }
}