
namespace Tyuiu.ShakirovaGM.Sprint6.Task0.V2
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
            SuspendLayout();
            // 
            // textBoxResult_SGM
            // 
            textBoxResult_SGM.Location = new Point(317, 196);
            textBoxResult_SGM.Name = "textBoxResult_SGM";
            textBoxResult_SGM.Size = new Size(185, 23);
            textBoxResult_SGM.TabIndex = 0;
            textBoxResult_SGM.TextChanged += textBoxResult_SGM_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult_SGM);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_SGM;
    }
}