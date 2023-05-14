namespace Steaguri_tricolore
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
            this.culoare1 = new System.Windows.Forms.TextBox();
            this.culoare3 = new System.Windows.Forms.TextBox();
            this.culoare2 = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // culoare1
            // 
            this.culoare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoare1.Location = new System.Drawing.Point(68, 31);
            this.culoare1.Name = "culoare1";
            this.culoare1.Size = new System.Drawing.Size(138, 29);
            this.culoare1.TabIndex = 0;
            // 
            // culoare3
            // 
            this.culoare3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoare3.Location = new System.Drawing.Point(68, 89);
            this.culoare3.Name = "culoare3";
            this.culoare3.Size = new System.Drawing.Size(138, 29);
            this.culoare3.TabIndex = 1;
            // 
            // culoare2
            // 
            this.culoare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoare2.Location = new System.Drawing.Point(68, 60);
            this.culoare2.Name = "culoare2";
            this.culoare2.Size = new System.Drawing.Size(138, 29);
            this.culoare2.TabIndex = 2;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(152, 155);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(44, 155);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 213);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.culoare2);
            this.Controls.Add(this.culoare3);
            this.Controls.Add(this.culoare1);
            this.Name = "Form1";
            this.Text = "Generare Steaguri Tricolore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox culoare1;
        private System.Windows.Forms.TextBox culoare3;
        private System.Windows.Forms.TextBox culoare2;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_start;
    }
}

