namespace Tyuiu.ShakirovaGM.Sprint6.Task2.V7
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
            buttonDone_SGM = new Button();
            dataGridViewResult_SGM = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBoxStartStep_SGM = new TextBox();
            textBoxStopStep_SGM = new TextBox();
            labelStartStep_SGM = new Label();
            labelStopStep_SGM = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SGM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_SGM
            // 
            buttonDone_SGM.Location = new Point(12, 59);
            buttonDone_SGM.Name = "buttonDone_SGM";
            buttonDone_SGM.Size = new Size(87, 67);
            buttonDone_SGM.TabIndex = 0;
            buttonDone_SGM.Text = "тыкнуть";
            buttonDone_SGM.UseVisualStyleBackColor = true;
            buttonDone_SGM.Click += buttonDone_SGM_Click;
            // 
            // dataGridViewResult_SGM
            // 
            dataGridViewResult_SGM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SGM.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult_SGM.Location = new Point(222, 12);
            dataGridViewResult_SGM.Name = "dataGridViewResult_SGM";
            dataGridViewResult_SGM.Size = new Size(145, 426);
            dataGridViewResult_SGM.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // textBoxStartStep_SGM
            // 
            textBoxStartStep_SGM.Location = new Point(12, 30);
            textBoxStartStep_SGM.Name = "textBoxStartStep_SGM";
            textBoxStartStep_SGM.Size = new Size(100, 23);
            textBoxStartStep_SGM.TabIndex = 2;
            // 
            // textBoxStopStep_SGM
            // 
            textBoxStopStep_SGM.Location = new Point(116, 30);
            textBoxStopStep_SGM.Name = "textBoxStopStep_SGM";
            textBoxStopStep_SGM.Size = new Size(100, 23);
            textBoxStopStep_SGM.TabIndex = 3;
            // 
            // labelStartStep_SGM
            // 
            labelStartStep_SGM.AutoSize = true;
            labelStartStep_SGM.Location = new Point(10, 12);
            labelStartStep_SGM.Name = "labelStartStep_SGM";
            labelStartStep_SGM.Size = new Size(31, 15);
            labelStartStep_SGM.TabIndex = 4;
            labelStartStep_SGM.Text = "Start";
            // 
            // labelStopStep_SGM
            // 
            labelStopStep_SGM.AutoSize = true;
            labelStopStep_SGM.Location = new Point(116, 12);
            labelStopStep_SGM.Name = "labelStopStep_SGM";
            labelStopStep_SGM.Size = new Size(31, 15);
            labelStopStep_SGM.TabIndex = 5;
            labelStopStep_SGM.Text = "Stop";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(labelStopStep_SGM);
            Controls.Add(labelStartStep_SGM);
            Controls.Add(textBoxStopStep_SGM);
            Controls.Add(textBoxStartStep_SGM);
            Controls.Add(dataGridViewResult_SGM);
            Controls.Add(buttonDone_SGM);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SGM).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_SGM;
        private DataGridView dataGridViewResult_SGM;
        private TextBox textBoxStartStep_SGM;
        private TextBox textBoxStopStep_SGM;
        private Label labelStartStep_SGM;
        private Label labelStopStep_SGM;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
