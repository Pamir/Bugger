namespace BuggerNet
{
    partial class frmExPInvoke
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkExHandler = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(38, 23);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(49, 20);
            this.txtA.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "a : ";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(119, 23);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(49, 20);
            this.txtB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "b : ";
            // 
            // txtAB
            // 
            this.txtAB.Location = new System.Drawing.Point(222, 23);
            this.txtAB.Name = "txtAB";
            this.txtAB.Size = new System.Drawing.Size(49, 20);
            this.txtAB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "a + b : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(318, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkExHandler
            // 
            this.chkExHandler.AutoSize = true;
            this.chkExHandler.Location = new System.Drawing.Point(18, 62);
            this.chkExHandler.Name = "chkExHandler";
            this.chkExHandler.Size = new System.Drawing.Size(163, 17);
            this.chkExHandler.TabIndex = 11;
            this.chkExHandler.Text = "Enable AV ExceptionHandler";
            this.chkExHandler.UseVisualStyleBackColor = true;
            // 
            // frmExPInvoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 193);
            this.Controls.Add(this.chkExHandler);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Name = "frmExPInvoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmExPInvoke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkExHandler;
    }
}