using Spire.Doc;

namespace SGPProject
{
    public partial class Form1 : Form
    {
        public List<string> items = new List<string>();

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Docx files(*.docx)|*.docx|All files(*.*)|*.*";
            saveFileDialog1.FileName = "расчет_количества_оборудования.docx";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void btnCalculate_Click(object sender, EventArgs e)
        {
            items.Clear();
            // Результат расчета – текст (наименование, производительность (тыс. м³/год), количество)
            string result;

            decimal efficiencyExcavator;
            decimal countExcavators;

            try
            {
                string name = tbxName.Text;
                decimal bucketVolume = Convert.ToDecimal(cbxBucketVolume.Text);
                decimal cycleTime = Convert.ToDecimal(tbxCycleTime.Text);
                decimal countWorkingDays = Convert.ToDecimal(tbxNumWorkingDays.Text);
                decimal coeffUseful = Convert.ToDecimal(tbxCoeffUseful.Text);
                decimal workVolume = Convert.ToDecimal(tbxWorkVolume.Text);

                if (countWorkingDays >= 1 && countWorkingDays <= 365)
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        efficiencyExcavator = CaltulateEfficiencyExcavator(bucketVolume, cycleTime, countWorkingDays, coeffUseful);
                        countExcavators = CalculateCountExcavators(workVolume, efficiencyExcavator);

                        decimal countExcavatorsFormat = decimal.Round(countExcavators, 2, MidpointRounding.AwayFromZero);

                        items.Add(name);
                        items.Add(Convert.ToString(efficiencyExcavator));
                        items.Add(Convert.ToString(workVolume));
                        items.Add(Convert.ToString(countExcavatorsFormat));

                        result = $"Наименование : {name}\r\nПроизводительность (тыс. м³/год) : {efficiencyExcavator}\r\nКоличество (шт) : {countExcavatorsFormat}";
                        tbxResult.Text = result;
                    }
                    else
                    {
                        MessageBoxWarningMessage("Введите название экскаватора!");
                    }
                }
                else
                {
                    MessageBoxWarningMessage("Введите кол-во дней в диапазоне от 1 до 365!");
                }
            }
            catch
            {
                MessageBoxWarningMessage("Введите все значения!");
            }
        }

        public void MessageBoxWarningMessage(string message)
        {
            MessageBox.Show(message, "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private decimal CaltulateEfficiencyExcavator(decimal bucketVolume, decimal cycleTime, decimal countWorkingDays, decimal coeffUseful)
        {
            /* Производительность экскаватора = Объем ковша × (Количество секунд в сутках / Время цикла) × Количество рабочих дней × Коэффициент полезного использования */
            const int countSecodsDay = 86400;

            decimal result = bucketVolume * (countSecodsDay / cycleTime) * countWorkingDays * coeffUseful;
            return result;
        }

        private decimal CalculateCountExcavators(decimal workVolume, decimal efficiencyExcavator)
        {
            //Количество экскаваторов = Объем работ / Производительность экскаватора
            decimal result = workVolume / efficiencyExcavator;
            return result;
        }

        private void btnUploadResult_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            string templateFilePath = "D:\\.NET Core\\SGPTest\\SGPTestTask\\SGPProject\\SGPProject\\Templates\\template_calculating_amount_equipment.docx";

            if (items.Count > 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string outputFilePath = saveFileDialog1.FileName;

                    WordHelper wordHelper = new WordHelper(document, templateFilePath);
                    try
                    {
                        wordHelper.ReplaceTemplateItem(document, items);
                        wordHelper.SaveFile(document, outputFilePath);

                        if (MessageBox.Show("Очистить данные?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ClearTextOnForm(this);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBoxWarningMessage(ex.Message);
                    }
                }
            }
            else
            {
                MessageBoxWarningMessage("Расчитайте данные!");
            }
        }

        private void tbxCycleTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterNumberKeyPress(sender, e);
        }

        private void tbxNumWorkingDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterNumberKeyPress(sender, e);
        }

        private void tbxCoeffUseful_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterNumberKeyPress(sender, e);
        }

        private void tbxWorkVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterNumberKeyPress(sender, e);
        }

        public void FilterNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void cbxBucketVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void ClearTextOnForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextOnForm(c);
                }

                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }
    }
}