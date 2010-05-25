namespace EventAI
{
    partial class FormDbSearch
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
            this.listView1 = new System.Windows.Forms.ListView();
            this._bCansel = new System.Windows.Forms.Button();
            this._bOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(0, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(693, 257);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // _bCansel
            // 
            this._bCansel.Location = new System.Drawing.Point(525, 397);
            this._bCansel.Name = "_bCansel";
            this._bCansel.Size = new System.Drawing.Size(75, 23);
            this._bCansel.TabIndex = 1;
            this._bCansel.Text = "Отмена";
            this._bCansel.UseVisualStyleBackColor = true;
            // 
            // _bOk
            // 
            this._bOk.Location = new System.Drawing.Point(606, 397);
            this._bOk.Name = "_bOk";
            this._bOk.Size = new System.Drawing.Size(75, 23);
            this._bOk.TabIndex = 2;
            this._bOk.Text = "Да";
            this._bOk.UseVisualStyleBackColor = true;
            // 
            // FormDbSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 427);
            this.Controls.Add(this._bOk);
            this.Controls.Add(this._bCansel);
            this.Controls.Add(this.listView1);
            this.Name = "FormDbSearch";
            this.Text = "FormDbSearch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button _bCansel;
        private System.Windows.Forms.Button _bOk;
    }
}