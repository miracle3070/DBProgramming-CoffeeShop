namespace _HW__커피샵_프로그램
{
    partial class FormMenuAdd
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
            this.textBoxCoffeeName = new System.Windows.Forms.TextBox();
            this.textBoxCoffeePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMenuAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "추가할 메뉴 정보를 입력하세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "메뉴 이름";
            // 
            // textBoxCoffeeName
            // 
            this.textBoxCoffeeName.Location = new System.Drawing.Point(178, 76);
            this.textBoxCoffeeName.Name = "textBoxCoffeeName";
            this.textBoxCoffeeName.Size = new System.Drawing.Size(180, 25);
            this.textBoxCoffeeName.TabIndex = 2;
            // 
            // textBoxCoffeePrice
            // 
            this.textBoxCoffeePrice.Location = new System.Drawing.Point(178, 117);
            this.textBoxCoffeePrice.Name = "textBoxCoffeePrice";
            this.textBoxCoffeePrice.Size = new System.Drawing.Size(180, 25);
            this.textBoxCoffeePrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "가격";
            // 
            // buttonMenuAdd
            // 
            this.buttonMenuAdd.Location = new System.Drawing.Point(160, 179);
            this.buttonMenuAdd.Name = "buttonMenuAdd";
            this.buttonMenuAdd.Size = new System.Drawing.Size(203, 54);
            this.buttonMenuAdd.TabIndex = 5;
            this.buttonMenuAdd.Text = "추가하기";
            this.buttonMenuAdd.UseVisualStyleBackColor = true;
            this.buttonMenuAdd.Click += new System.EventHandler(this.buttonMenuAdd_Click);
            // 
            // FormMenuAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 264);
            this.Controls.Add(this.buttonMenuAdd);
            this.Controls.Add(this.textBoxCoffeePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCoffeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuAdd";
            this.Text = "FormMenuAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCoffeeName;
        private System.Windows.Forms.TextBox textBoxCoffeePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMenuAdd;
    }
}