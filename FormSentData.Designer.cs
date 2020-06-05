namespace MyInfo
{
    partial class FormSentData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSentAll = new System.Windows.Forms.CheckBox();
            this.btnSentData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxSentAll);
            this.panel1.Controls.Add(this.btnSentData);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateEnd);
            this.panel1.Controls.Add(this.dateBegin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 472);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxSentAll
            // 
            this.checkBoxSentAll.AutoSize = true;
            this.checkBoxSentAll.Location = new System.Drawing.Point(36, 98);
            this.checkBoxSentAll.Name = "checkBoxSentAll";
            this.checkBoxSentAll.Size = new System.Drawing.Size(70, 17);
            this.checkBoxSentAll.TabIndex = 5;
            this.checkBoxSentAll.Text = "ส่งทั้งหมด";
            this.checkBoxSentAll.UseVisualStyleBackColor = true;
            this.checkBoxSentAll.CheckedChanged += new System.EventHandler(this.checkBoxSentAll_CheckedChanged);
            this.checkBoxSentAll.CheckStateChanged += new System.EventHandler(this.checkBoxSentAll_CheckStateChanged);
            // 
            // btnSentData
            // 
            this.btnSentData.Location = new System.Drawing.Point(36, 138);
            this.btnSentData.Name = "btnSentData";
            this.btnSentData.Size = new System.Drawing.Size(157, 23);
            this.btnSentData.TabIndex = 4;
            this.btnSentData.Text = "ส่งข้อมูล";
            this.btnSentData.UseVisualStyleBackColor = true;
            this.btnSentData.Click += new System.EventHandler(this.btnSentData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ถึงวันที่";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(36, 71);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(157, 20);
            this.dateEnd.TabIndex = 2;
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(36, 32);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(157, 20);
            this.dateBegin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ส่งข้อมูลระหว่างวันที่";
            // 
            // FormSentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 472);
            this.Controls.Add(this.panel1);
            this.Name = "FormSentData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ส่งข้อมูล";
            this.Load += new System.EventHandler(this.FormSentData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxSentAll;
        private System.Windows.Forms.Button btnSentData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.Label label1;
    }
}