namespace CarDbApp.Controls
{
    partial class CarRecordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._txtSpz = new System.Windows.Forms.TextBox();
            this._txtModel = new System.Windows.Forms.TextBox();
            this._txtFirstDriver = new System.Windows.Forms.TextBox();
            this._cmbState = new System.Windows.Forms.ComboBox();
            this._btnVerify = new System.Windows.Forms.Button();
            this._lblCarId = new System.Windows.Forms.Label();
            this._dtpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this._btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtSpz
            // 
            this._txtSpz.Location = new System.Drawing.Point(232, 2);
            this._txtSpz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtSpz.Name = "_txtSpz";
            this._txtSpz.Size = new System.Drawing.Size(110, 23);
            this._txtSpz.TabIndex = 2;
            this._txtSpz.TextChanged += new System.EventHandler(this._ValueChanged);
            // 
            // _txtModel
            // 
            this._txtModel.Location = new System.Drawing.Point(346, 2);
            this._txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtModel.Name = "_txtModel";
            this._txtModel.Size = new System.Drawing.Size(110, 23);
            this._txtModel.TabIndex = 3;
            this._txtModel.TextChanged += new System.EventHandler(this._ValueChanged);
            // 
            // _txtFirstDriver
            // 
            this._txtFirstDriver.Location = new System.Drawing.Point(644, 2);
            this._txtFirstDriver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtFirstDriver.Name = "_txtFirstDriver";
            this._txtFirstDriver.Size = new System.Drawing.Size(110, 23);
            this._txtFirstDriver.TabIndex = 5;
            this._txtFirstDriver.TextChanged += new System.EventHandler(this._ValueChanged);
            // 
            // _cmbState
            // 
            this._cmbState.FormattingEnabled = true;
            this._cmbState.Items.AddRange(new object[] {
            "None",
            "Very good",
            "Good",
            "Bad",
            "Rusty junk"});
            this._cmbState.Location = new System.Drawing.Point(117, 2);
            this._cmbState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cmbState.Name = "_cmbState";
            this._cmbState.Size = new System.Drawing.Size(110, 23);
            this._cmbState.TabIndex = 6;
            this._cmbState.SelectedIndexChanged += new System.EventHandler(this._ValueChanged);
            // 
            // _btnVerify
            // 
            this._btnVerify.Enabled = false;
            this._btnVerify.Location = new System.Drawing.Point(760, 2);
            this._btnVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnVerify.Name = "_btnVerify";
            this._btnVerify.Size = new System.Drawing.Size(119, 22);
            this._btnVerify.TabIndex = 7;
            this._btnVerify.Text = "Check AND Save";
            this._btnVerify.UseVisualStyleBackColor = true;
            this._btnVerify.Click += new System.EventHandler(this._btnVerify_Click);
            // 
            // _lblCarId
            // 
            this._lblCarId.AutoSize = true;
            this._lblCarId.Location = new System.Drawing.Point(3, 4);
            this._lblCarId.Name = "_lblCarId";
            this._lblCarId.Size = new System.Drawing.Size(38, 15);
            this._lblCarId.TabIndex = 8;
            this._lblCarId.Text = "label1";
            // 
            // _dtpLastUpdate
            // 
            this._dtpLastUpdate.Location = new System.Drawing.Point(462, 2);
            this._dtpLastUpdate.Name = "_dtpLastUpdate";
            this._dtpLastUpdate.Size = new System.Drawing.Size(176, 23);
            this._dtpLastUpdate.TabIndex = 9;
            this._dtpLastUpdate.ValueChanged += new System.EventHandler(this._ValueChanged);
            // 
            // _btnDelete
            // 
            this._btnDelete.Location = new System.Drawing.Point(885, 1);
            this._btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(18, 22);
            this._btnDelete.TabIndex = 10;
            this._btnDelete.Text = "x";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // CarRecordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._dtpLastUpdate);
            this.Controls.Add(this._lblCarId);
            this.Controls.Add(this._btnVerify);
            this.Controls.Add(this._cmbState);
            this.Controls.Add(this._txtFirstDriver);
            this.Controls.Add(this._txtModel);
            this.Controls.Add(this._txtSpz);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CarRecordControl";
            this.Size = new System.Drawing.Size(908, 26);
            this.Load += new System.EventHandler(this.CarRecordControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox _txtSpz;
        private TextBox _txtModel;
        private TextBox _txtFirstDriver;
        private ComboBox _cmbState;
        private Button _btnVerify;
        private Label _lblCarId;
        private DateTimePicker _dtpLastUpdate;
        private Button _btnDelete;
    }
}
