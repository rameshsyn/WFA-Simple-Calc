namespace Calculator
{
    partial class Calculator
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
            this.Num1 = new System.Windows.Forms.Label();
            this.Num1Input = new System.Windows.Forms.TextBox();
            this.Num2Input = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.SumOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(59, 86);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(74, 25);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "Num1:";
            // 
            // Num1Input
            // 
            this.Num1Input.Location = new System.Drawing.Point(139, 86);
            this.Num1Input.Multiline = true;
            this.Num1Input.Name = "Num1Input";
            this.Num1Input.Size = new System.Drawing.Size(59, 30);
            this.Num1Input.TabIndex = 1;
            this.Num1Input.TextChanged += new System.EventHandler(this.Num1Input_TextChanged);
            // 
            // Num2Input
            // 
            this.Num2Input.Location = new System.Drawing.Point(139, 155);
            this.Num2Input.Multiline = true;
            this.Num2Input.Name = "Num2Input";
            this.Num2Input.Size = new System.Drawing.Size(59, 30);
            this.Num2Input.TabIndex = 3;
            this.Num2Input.TextChanged += new System.EventHandler(this.Num2Input_TextChanged);
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(59, 155);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(74, 25);
            this.Num2.TabIndex = 2;
            this.Num2.Text = "Num2:";
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(59, 218);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(61, 25);
            this.Sum.TabIndex = 4;
            this.Sum.Text = "Sum:";
            // 
            // SumOutput
            // 
            this.SumOutput.AutoSize = true;
            this.SumOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumOutput.Location = new System.Drawing.Point(137, 218);
            this.SumOutput.Name = "SumOutput";
            this.SumOutput.Size = new System.Drawing.Size(0, 25);
            this.SumOutput.TabIndex = 5;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumOutput);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Num2Input);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1Input);
            this.Controls.Add(this.Num1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.TextBox Num1Input;
        private System.Windows.Forms.TextBox Num2Input;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label SumOutput;
    }
}