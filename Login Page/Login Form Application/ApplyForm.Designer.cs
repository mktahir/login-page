namespace Login_Form_Application
{
    partial class ApplyForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.contactbox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.companybox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.companylabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.contactlabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // emailbox
            // 
            this.emailbox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbox.Location = new System.Drawing.Point(238, 181);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(252, 27);
            this.emailbox.TabIndex = 7;
            this.emailbox.TextChanged += new System.EventHandler(this.emailbox_TextChanged);
            // 
            // contactbox
            // 
            this.contactbox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactbox.Location = new System.Drawing.Point(238, 242);
            this.contactbox.MaxLength = 10;
            this.contactbox.Name = "contactbox";
            this.contactbox.Size = new System.Drawing.Size(252, 27);
            this.contactbox.TabIndex = 8;
            this.contactbox.TextChanged += new System.EventHandler(this.contactbox_TextChanged);
            this.contactbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactbox_KeyPress);
            // 
            // addressbox
            // 
            this.addressbox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressbox.Location = new System.Drawing.Point(238, 303);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(252, 27);
            this.addressbox.TabIndex = 9;
            this.addressbox.TextChanged += new System.EventHandler(this.addressbox_TextChanged);
            // 
            // submitbutton
            // 
            this.submitbutton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.Location = new System.Drawing.Point(61, 382);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(127, 42);
            this.submitbutton.TabIndex = 10;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Location = new System.Drawing.Point(224, 382);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(127, 42);
            this.clearbutton.TabIndex = 11;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.Location = new System.Drawing.Point(384, 382);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(106, 42);
            this.closebutton.TabIndex = 12;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.Location = new System.Drawing.Point(238, 55);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(252, 27);
            this.namebox.TabIndex = 13;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // companybox
            // 
            this.companybox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companybox.Location = new System.Drawing.Point(238, 122);
            this.companybox.Name = "companybox";
            this.companybox.Size = new System.Drawing.Size(252, 27);
            this.companybox.TabIndex = 14;
            this.companybox.TextChanged += new System.EventHandler(this.companybox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(533, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(533, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 16;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.Color.Red;
            this.namelabel.Location = new System.Drawing.Point(537, 65);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(0, 18);
            this.namelabel.TabIndex = 17;
            this.namelabel.Click += new System.EventHandler(this.namelabel_Click);
            // 
            // companylabel
            // 
            this.companylabel.AutoSize = true;
            this.companylabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companylabel.ForeColor = System.Drawing.Color.Red;
            this.companylabel.Location = new System.Drawing.Point(537, 131);
            this.companylabel.Name = "companylabel";
            this.companylabel.Size = new System.Drawing.Size(0, 18);
            this.companylabel.TabIndex = 18;
            this.companylabel.Click += new System.EventHandler(this.companylabel_Click);
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.Color.Red;
            this.emaillabel.Location = new System.Drawing.Point(537, 190);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(0, 18);
            this.emaillabel.TabIndex = 19;
            this.emaillabel.Click += new System.EventHandler(this.emaillabel_Click);
            // 
            // contactlabel
            // 
            this.contactlabel.AutoSize = true;
            this.contactlabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlabel.ForeColor = System.Drawing.Color.Red;
            this.contactlabel.Location = new System.Drawing.Point(537, 251);
            this.contactlabel.Name = "contactlabel";
            this.contactlabel.Size = new System.Drawing.Size(0, 18);
            this.contactlabel.TabIndex = 20;
            this.contactlabel.Click += new System.EventHandler(this.contactlabel_Click);
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.ForeColor = System.Drawing.Color.Red;
            this.addresslabel.Location = new System.Drawing.Point(537, 312);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(0, 18);
            this.addresslabel.TabIndex = 21;
            this.addresslabel.Click += new System.EventHandler(this.addresslabel_Click);
            // 
            // ApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 538);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.contactlabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.companylabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.companybox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.contactbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ApplyForm";
            this.Text = "ApplyForm";
            this.Load += new System.EventHandler(this.ApplyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox contactbox;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox companybox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label companylabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label contactlabel;
        private System.Windows.Forms.Label addresslabel;
    }
}