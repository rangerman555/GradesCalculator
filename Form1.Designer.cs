namespace GradesCalculator
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
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelSbuject = new System.Windows.Forms.Label();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.labelPoints = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelAverageHeader = new System.Windows.Forms.Label();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.SubjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelPointsHeader = new System.Windows.Forms.Label();
            this.labelCurrPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(80, 26);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubject.TabIndex = 0;
            // 
            // labelSbuject
            // 
            this.labelSbuject.AutoSize = true;
            this.labelSbuject.Location = new System.Drawing.Point(24, 29);
            this.labelSbuject.Name = "labelSbuject";
            this.labelSbuject.Size = new System.Drawing.Size(46, 13);
            this.labelSbuject.TabIndex = 1;
            this.labelSbuject.Text = "Subject:";
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(80, 52);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(100, 20);
            this.textBoxPoints.TabIndex = 1;
            this.textBoxPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.invalidInput_KeyPress);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(24, 55);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(39, 13);
            this.labelPoints.TabIndex = 1;
            this.labelPoints.Text = "Points:";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(80, 78);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrade.TabIndex = 2;
            this.textBoxGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.invalidInput_KeyPress);
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(24, 81);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(39, 13);
            this.labelGrade.TabIndex = 1;
            this.labelGrade.Text = "Grade:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(64, 116);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelAverageHeader
            // 
            this.labelAverageHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAverageHeader.AutoSize = true;
            this.labelAverageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAverageHeader.Location = new System.Drawing.Point(23, 227);
            this.labelAverageHeader.Name = "labelAverageHeader";
            this.labelAverageHeader.Size = new System.Drawing.Size(76, 20);
            this.labelAverageHeader.TabIndex = 4;
            this.labelAverageHeader.Text = "Average: ";
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.AllowUserToAddRows = false;
            this.dataGridViewGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectColumn,
            this.PointsColumn,
            this.GradeColumn});
            this.dataGridViewGrades.Location = new System.Drawing.Point(208, 26);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.Size = new System.Drawing.Size(407, 303);
            this.dataGridViewGrades.TabIndex = 5;
            // 
            // SubjectColumn
            // 
            this.SubjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectColumn.FillWeight = 300F;
            this.SubjectColumn.HeaderText = "Subject";
            this.SubjectColumn.Name = "SubjectColumn";
            // 
            // PointsColumn
            // 
            this.PointsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PointsColumn.HeaderText = "Points";
            this.PointsColumn.Name = "PointsColumn";
            // 
            // GradeColumn
            // 
            this.GradeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradeColumn.HeaderText = "Grade";
            this.GradeColumn.Name = "GradeColumn";
            // 
            // labelAverage
            // 
            this.labelAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAverage.Location = new System.Drawing.Point(101, 223);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(0, 31);
            this.labelAverage.TabIndex = 4;
            // 
            // labelPointsHeader
            // 
            this.labelPointsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPointsHeader.AutoSize = true;
            this.labelPointsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPointsHeader.Location = new System.Drawing.Point(23, 271);
            this.labelPointsHeader.Name = "labelPointsHeader";
            this.labelPointsHeader.Size = new System.Drawing.Size(57, 20);
            this.labelPointsHeader.TabIndex = 4;
            this.labelPointsHeader.Text = "Points:";
            // 
            // labelCurrPoints
            // 
            this.labelCurrPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrPoints.AutoSize = true;
            this.labelCurrPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCurrPoints.Location = new System.Drawing.Point(92, 267);
            this.labelCurrPoints.Name = "labelCurrPoints";
            this.labelCurrPoints.Size = new System.Drawing.Size(0, 31);
            this.labelCurrPoints.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 363);
            this.Controls.Add(this.dataGridViewGrades);
            this.Controls.Add(this.labelCurrPoints);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelPointsHeader);
            this.Controls.Add(this.labelAverageHeader);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelSbuject);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.textBoxSubject);
            this.Name = "Form1";
            this.Text = "Average Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saveData);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelSbuject;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelAverageHeader;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeColumn;
        private System.Windows.Forms.Label labelPointsHeader;
        private System.Windows.Forms.Label labelCurrPoints;
    }
}

