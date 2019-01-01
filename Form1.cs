using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradesCalculator
{
    public partial class Form1 : Form
    {
        public AppSerializer appSerializer;
        public AverageCalc averageCalc = new AverageCalc();
        public bool DoesNeedToSave { get; set; }
        

        public Form1()
        {
            InitializeComponent();
            appSerializer = AppSerializer.loadFromFile();

            foreach (var item in appSerializer.ListOfDataToSave)
            {
                dataGridViewGrades.Rows.Add(item.Subject, item.Points, item.Grade);
            }

            averageCalc.SumOfPoints = appSerializer.SumOfPoints;
            averageCalc.SumOfGrades = appSerializer.SumOfGrades;
            averageCalc.Average = appSerializer.Average;

            labelAverage.Text = averageCalc.Average.ToString();
            labelCurrPoints.Text = averageCalc.SumOfPoints.ToString();
           
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DataToSave tempData = new DataToSave();
            tempData.addNewGrade(textBoxSubject.Text, textBoxPoints.Text, textBoxGrade.Text);
            addNewDataToTable();
            appSerializer.ListOfDataToSave.Add(tempData);
            DoesNeedToSave = true;
            averageCalc.addGradeAndPoints(textBoxGrade.Text, textBoxPoints.Text);
            averageCalc.calcAverage();
            labelAverage.Text = averageCalc.Average.ToString();
            labelCurrPoints.Text = averageCalc.SumOfPoints.ToString();
            clearTextBoxes();
        }

        private void addNewDataToTable()
        {
            dataGridViewGrades.Rows.Add(textBoxSubject.Text, textBoxPoints.Text, textBoxGrade.Text);
        }

        private void clearTextBoxes()
        {
            textBoxSubject.Clear();
            textBoxPoints.Clear();
            textBoxGrade.Clear();
        }

        private void saveData(object sender, FormClosingEventArgs e)
        {
            if (DoesNeedToSave == true)
            {
                appSerializer.SumOfGrades = averageCalc.SumOfGrades;
                appSerializer.SumOfPoints = averageCalc.SumOfPoints;
                appSerializer.Average = averageCalc.Average;
                appSerializer.saveToFile();
            }
        }


        private void invalidInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    
    }
}
