
namespace SoftEvaluation
{
    partial class EditRecord
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
            this.enterydate = new System.Windows.Forms.DateTimePicker();
            this.userid = new System.Windows.Forms.TextBox();
            this.costcenter = new System.Windows.Forms.NumericUpDown();
            this.credit = new System.Windows.Forms.NumericUpDown();
            this.debit = new System.Windows.Forms.NumericUpDown();
            this.subaccount = new System.Windows.Forms.TextBox();
            this.account = new System.Windows.Forms.NumericUpDown();
            this.remarks = new System.Windows.Forms.TextBox();
            this.voucherdate = new System.Windows.Forms.DateTimePicker();
            this.vouchernumber = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.costcenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vouchernumber)).BeginInit();
            this.SuspendLayout();
            // 
            // enterydate
            // 
            this.enterydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enterydate.Location = new System.Drawing.Point(694, 310);
            this.enterydate.Name = "enterydate";
            this.enterydate.Size = new System.Drawing.Size(120, 22);
            this.enterydate.TabIndex = 39;
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(371, 312);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(130, 22);
            this.userid.TabIndex = 38;
            // 
            // costcenter
            // 
            this.costcenter.Location = new System.Drawing.Point(694, 275);
            this.costcenter.Name = "costcenter";
            this.costcenter.Size = new System.Drawing.Size(120, 22);
            this.costcenter.TabIndex = 37;
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(371, 272);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(130, 22);
            this.credit.TabIndex = 36;
            // 
            // debit
            // 
            this.debit.Location = new System.Drawing.Point(694, 235);
            this.debit.Name = "debit";
            this.debit.Size = new System.Drawing.Size(120, 22);
            this.debit.TabIndex = 35;
            // 
            // subaccount
            // 
            this.subaccount.Location = new System.Drawing.Point(371, 231);
            this.subaccount.Name = "subaccount";
            this.subaccount.Size = new System.Drawing.Size(130, 22);
            this.subaccount.TabIndex = 34;
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(694, 203);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(120, 22);
            this.account.TabIndex = 33;
            // 
            // remarks
            // 
            this.remarks.Location = new System.Drawing.Point(371, 203);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(130, 22);
            this.remarks.TabIndex = 32;
            // 
            // voucherdate
            // 
            this.voucherdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.voucherdate.Location = new System.Drawing.Point(694, 168);
            this.voucherdate.Name = "voucherdate";
            this.voucherdate.Size = new System.Drawing.Size(120, 22);
            this.voucherdate.TabIndex = 31;
            // 
            // vouchernumber
            // 
            this.vouchernumber.Location = new System.Drawing.Point(371, 168);
            this.vouchernumber.Name = "vouchernumber";
            this.vouchernumber.Size = new System.Drawing.Size(130, 22);
            this.vouchernumber.TabIndex = 30;
            this.vouchernumber.ValueChanged += new System.EventHandler(this.vouchernumber_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(558, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Entry Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "User ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cost Center :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Credit :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Debit :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sub Account :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Account :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Remarks :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Voucher Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Voucher NO :";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(504, 391);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 40;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(615, 391);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 41;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // EditRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 503);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.enterydate);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.costcenter);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.debit);
            this.Controls.Add(this.subaccount);
            this.Controls.Add(this.account);
            this.Controls.Add(this.remarks);
            this.Controls.Add(this.voucherdate);
            this.Controls.Add(this.vouchernumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditRecord";
            this.Text = "EditRecord";
            this.Load += new System.EventHandler(this.EditRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costcenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vouchernumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker enterydate;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.NumericUpDown costcenter;
        private System.Windows.Forms.NumericUpDown credit;
        private System.Windows.Forms.NumericUpDown debit;
        private System.Windows.Forms.TextBox subaccount;
        private System.Windows.Forms.NumericUpDown account;
        private System.Windows.Forms.TextBox remarks;
        private System.Windows.Forms.DateTimePicker voucherdate;
        private System.Windows.Forms.NumericUpDown vouchernumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
    }
}