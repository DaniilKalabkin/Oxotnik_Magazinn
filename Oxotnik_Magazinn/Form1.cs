using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oxotnik_Magazinn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oxotnik_TovarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oxotnik_TovarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Zakupka". При необходимости она может быть перемещена или удалена.
            this.zakupkaTableAdapter.Fill(this.dataSet1.Zakupka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.dataSet1.Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Proizvoditel". При необходимости она может быть перемещена или удалена.
            this.proizvoditelTableAdapter.Fill(this.dataSet1.Proizvoditel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Prodasha". При необходимости она может быть перемещена или удалена.
            this.prodashaTableAdapter.Fill(this.dataSet1.Prodasha);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Postawka". При необходимости она может быть перемещена или удалена.
            this.postawkaTableAdapter.Fill(this.dataSet1.Postawka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Oxotnik_Tovar_Proizvoditel". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Oxotnik_Tovar". При необходимости она может быть перемещена или удалена.
            this.oxotnik_TovarTableAdapter.Fill(this.dataSet1.Oxotnik_Tovar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oxotnik_TovarBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oxotnik_TovarBindingSource.EndEdit();
            oxotnik_TovarTableAdapter.Update(dataSet1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            postawkaBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            postawkaBindingSource.EndEdit();
            postawkaTableAdapter.Update(dataSet1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prodashaBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prodashaBindingSource.EndEdit();
            prodashaTableAdapter.Update(dataSet1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.EndEdit();
            proizvoditelTableAdapter.Update(dataSet1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            skladBindingSource.AddNew();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            skladBindingSource.EndEdit();
            skladTableAdapter.Update(dataSet1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            zakupkaBindingSource.AddNew();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            zakupkaBindingSource.EndEdit();
            zakupkaTableAdapter.Update(dataSet1);
        }
    }
}
