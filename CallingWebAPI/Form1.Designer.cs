namespace CallingWebAPI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rdoPost = new System.Windows.Forms.RadioButton();
            this.rdoGet = new System.Windows.Forms.RadioButton();
            this.txtFunctionURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(65, 36);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(385, 20);
            this.txtURL.TabIndex = 1;
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(65, 75);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequest.Size = new System.Drawing.Size(385, 341);
            this.txtRequest.TabIndex = 2;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(470, 75);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(385, 341);
            this.txtResponse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Request Json String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Response";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(722, 426);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(133, 34);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rdoPost
            // 
            this.rdoPost.AutoSize = true;
            this.rdoPost.Location = new System.Drawing.Point(65, 13);
            this.rdoPost.Name = "rdoPost";
            this.rdoPost.Size = new System.Drawing.Size(46, 17);
            this.rdoPost.TabIndex = 7;
            this.rdoPost.TabStop = true;
            this.rdoPost.Text = "Post";
            this.rdoPost.UseVisualStyleBackColor = true;
            // 
            // rdoGet
            // 
            this.rdoGet.AutoSize = true;
            this.rdoGet.Location = new System.Drawing.Point(118, 13);
            this.rdoGet.Name = "rdoGet";
            this.rdoGet.Size = new System.Drawing.Size(42, 17);
            this.rdoGet.TabIndex = 8;
            this.rdoGet.TabStop = true;
            this.rdoGet.Text = "Get";
            this.rdoGet.UseVisualStyleBackColor = true;
            // 
            // txtFunctionURL
            // 
            this.txtFunctionURL.Location = new System.Drawing.Point(517, 36);
            this.txtFunctionURL.Name = "txtFunctionURL";
            this.txtFunctionURL.Size = new System.Drawing.Size(338, 20);
            this.txtFunctionURL.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Function";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 472);
            this.Controls.Add(this.txtFunctionURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoGet);
            this.Controls.Add(this.rdoPost);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rdoPost;
        private System.Windows.Forms.RadioButton rdoGet;
        private System.Windows.Forms.TextBox txtFunctionURL;
        private System.Windows.Forms.Label label4;
    }
}

