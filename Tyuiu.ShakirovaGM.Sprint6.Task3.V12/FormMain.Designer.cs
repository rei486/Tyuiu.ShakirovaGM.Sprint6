using Tyuiu.ShakirovaGM.Sprint6.Task3.V12.Lib;
namespace Tyuiu.ShakirovaGM.Sprint6.Task3.V12
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
            groupBoxResult_SGM = new GroupBox();
            labelCondition1_SGM = new Label();
            buttonResult_SGM = new Button();
            dataGridViewResult_SGM = new DataGridView();
            dataGridViewSorted_SGM = new DataGridView();
            groupBoxResult_SGM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SGM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted_SGM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxResult_SGM
            // 
            groupBoxResult_SGM.Controls.Add(labelCondition1_SGM);
            groupBoxResult_SGM.Location = new Point(12, 12);
            groupBoxResult_SGM.Name = "groupBoxResult_SGM";
            groupBoxResult_SGM.Size = new Size(339, 301);
            groupBoxResult_SGM.TabIndex = 0;
            groupBoxResult_SGM.TabStop = false;
            groupBoxResult_SGM.Text = "Условие";
            // 
            // labelCondition1_SGM
            // 
            labelCondition1_SGM.AutoSize = true;
            labelCondition1_SGM.Location = new Point(21, 28);
            labelCondition1_SGM.Name = "labelCondition1_SGM";
            labelCondition1_SGM.Size = new Size(168, 15);
            labelCondition1_SGM.TabIndex = 0;
            labelCondition1_SGM.Text = "Четные на 0 в первой строке ";
            // 
            // buttonResult_SGM
            // 
            buttonResult_SGM.Location = new Point(219, 319);
            buttonResult_SGM.Name = "buttonResult_SGM";
            buttonResult_SGM.Size = new Size(132, 66);
            buttonResult_SGM.TabIndex = 1;
            buttonResult_SGM.Text = "тыкать";
            buttonResult_SGM.UseVisualStyleBackColor = true;
            buttonResult_SGM.Click += buttonResult_SGM_Click;
            // 
            // dataGridViewResult_SGM
            // 
            dataGridViewResult_SGM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SGM.Location = new Point(364, 44);
            dataGridViewResult_SGM.Name = "dataGridViewResult_SGM";
            dataGridViewResult_SGM.Size = new Size(240, 150);
            dataGridViewResult_SGM.TabIndex = 2;
            // 
            // dataGridViewSorted_SGM
            // 
            dataGridViewSorted_SGM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSorted_SGM.Location = new Point(364, 217);
            dataGridViewSorted_SGM.Name = "dataGridViewSorted_SGM";
            dataGridViewSorted_SGM.Size = new Size(240, 150);
            dataGridViewSorted_SGM.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSorted_SGM);
            Controls.Add(dataGridViewResult_SGM);
            Controls.Add(buttonResult_SGM);
            Controls.Add(groupBoxResult_SGM);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxResult_SGM.ResumeLayout(false);
            groupBoxResult_SGM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SGM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted_SGM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResult_SGM;
        private Label labelCondition1_SGM;
        private Button buttonResult_SGM;
        private DataGridView dataGridViewResult_SGM;
        private DataGridView dataGridViewSorted_SGM;
    }
}
