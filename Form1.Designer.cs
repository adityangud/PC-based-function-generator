namespace project
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Function = new System.Windows.Forms.Label();
            this.Square = new System.Windows.Forms.RadioButton();
            this.Sine = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Triangular = new System.Windows.Forms.RadioButton();
            this.Sawtooth = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM22";
            // 
            // Function
            // 
            this.Function.AutoSize = true;
            this.Function.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Function.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Function.Location = new System.Drawing.Point(75, 9);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(219, 29);
            this.Function.TabIndex = 0;
            this.Function.Text = "Function Generator";
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Square.Location = new System.Drawing.Point(15, 78);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(63, 19);
            this.Square.TabIndex = 1;
            this.Square.TabStop = true;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.CheckedChanged += new System.EventHandler(this.Square_CheckedChanged);
            // 
            // Sine
            // 
            this.Sine.AutoSize = true;
            this.Sine.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sine.Location = new System.Drawing.Point(15, 111);
            this.Sine.Name = "Sine";
            this.Sine.Size = new System.Drawing.Size(48, 19);
            this.Sine.TabIndex = 2;
            this.Sine.TabStop = true;
            this.Sine.Text = "Sine";
            this.Sine.UseVisualStyleBackColor = true;
            this.Sine.CheckedChanged += new System.EventHandler(this.Sine_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select wave";
            // 
            // Triangular
            // 
            this.Triangular.AutoSize = true;
            this.Triangular.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Triangular.Location = new System.Drawing.Point(15, 179);
            this.Triangular.Name = "Triangular";
            this.Triangular.Size = new System.Drawing.Size(82, 19);
            this.Triangular.TabIndex = 4;
            this.Triangular.TabStop = true;
            this.Triangular.Text = "Triangular";
            this.Triangular.UseVisualStyleBackColor = true;
            this.Triangular.CheckedChanged += new System.EventHandler(this.Triangular_CheckedChanged);
            // 
            // Sawtooth
            // 
            this.Sawtooth.AutoSize = true;
            this.Sawtooth.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sawtooth.Location = new System.Drawing.Point(15, 144);
            this.Sawtooth.Name = "Sawtooth";
            this.Sawtooth.Size = new System.Drawing.Size(79, 19);
            this.Sawtooth.TabIndex = 5;
            this.Sawtooth.TabStop = true;
            this.Sawtooth.Text = "Saw tooth";
            this.Sawtooth.UseVisualStyleBackColor = true;
            this.Sawtooth.CheckedChanged += new System.EventHandler(this.Sawtooth_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "20 Hz",
            "30 Hz",
            "40 Hz",
            "50 Hz",
            "60 Hz",
            "70 Hz",
            "80 Hz",
            "90 Hz"});
            this.listBox1.Location = new System.Drawing.Point(295, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(52, 119);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Frequency";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(153, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Sawtooth);
            this.Controls.Add(this.Triangular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sine);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Function);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label Function;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.RadioButton Sine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Triangular;
        private System.Windows.Forms.RadioButton Sawtooth;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}

