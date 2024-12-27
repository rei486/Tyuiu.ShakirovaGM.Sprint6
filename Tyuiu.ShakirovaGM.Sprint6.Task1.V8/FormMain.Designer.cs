namespace Tyuiu.ShakirovaGM.Sprint6.Task1.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxResult_SGM = new TextBox();
            buttonResult_SGM = new Button();
            textBoxStartStep_SGM = new TextBox();
            textBoxStopStep_SGM = new TextBox();
            labelStartStep_SGM = new Label();
            labelStopStep_SGM = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBoxResult_SGM
            // 
            textBoxResult_SGM.Location = new Point(245, 12);
            textBoxResult_SGM.Multiline = true;
            textBoxResult_SGM.Name = "textBoxResult_SGM";
            textBoxResult_SGM.Size = new Size(197, 426);
            textBoxResult_SGM.TabIndex = 0;
            // 
            // buttonResult_SGM
            // 
            buttonResult_SGM.Location = new Point(12, 64);
            buttonResult_SGM.Name = "buttonResult_SGM";
            buttonResult_SGM.Size = new Size(209, 95);
            buttonResult_SGM.TabIndex = 1;
            buttonResult_SGM.Text = "Тыкните";
            buttonResult_SGM.UseVisualStyleBackColor = true;
            buttonResult_SGM.Click += buttonResult_SGM_Click;
            // 
            // textBoxStartStep_SGM
            // 
            textBoxStartStep_SGM.Location = new Point(12, 35);
            textBoxStartStep_SGM.Name = "textBoxStartStep_SGM";
            textBoxStartStep_SGM.Size = new Size(100, 23);
            textBoxStartStep_SGM.TabIndex = 2;
            // 
            // textBoxStopStep_SGM
            // 
            textBoxStopStep_SGM.Location = new Point(121, 35);
            textBoxStopStep_SGM.Name = "textBoxStopStep_SGM";
            textBoxStopStep_SGM.Size = new Size(100, 23);
            textBoxStopStep_SGM.TabIndex = 3;
            // 
            // labelStartStep_SGM
            // 
            labelStartStep_SGM.AutoSize = true;
            labelStartStep_SGM.Location = new Point(12, 12);
            labelStartStep_SGM.Name = "labelStartStep_SGM";
            labelStartStep_SGM.Size = new Size(54, 15);
            labelStartStep_SGM.TabIndex = 4;
            labelStartStep_SGM.Text = "StartStep";
            // 
            // labelStopStep_SGM
            // 
            labelStopStep_SGM.AutoSize = true;
            labelStopStep_SGM.Location = new Point(144, 12);
            labelStopStep_SGM.Name = "labelStopStep_SGM";
            labelStopStep_SGM.Size = new Size(54, 15);
            labelStopStep_SGM.TabIndex = 5;
            labelStopStep_SGM.Text = "StopStep";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(textBox1);
            Controls.Add(labelStopStep_SGM);
            Controls.Add(labelStartStep_SGM);
            Controls.Add(textBoxStopStep_SGM);
            Controls.Add(textBoxStartStep_SGM);
            Controls.Add(buttonResult_SGM);
            Controls.Add(textBoxResult_SGM);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_SGM;
        private Button buttonResult_SGM;
        private TextBox textBoxStartStep_SGM;
        private TextBox textBoxStopStep_SGM;
        private Label labelStartStep_SGM;
        private Label labelStopStep_SGM;
        private TextBox textBox1;
    }
}
