using static test4.Service.DateService;
using test4.Model;

namespace test4
{
    public partial class Form1 : Form
    {
        private string dayOfWeek;
        private string month;
        private string dayOfMonth;
        private string year;
        private string result;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnSendButtonClick(object sender, EventArgs e)
        {
            CreateXmlIfNotExist();
            result = GetResult(DayOfWeekComboBox.Text, DayOfMonthComboBox.Text, MonthComboBox.Text, YearComboBox.Text);

            var date = new Date(DayOfWeekComboBox.Text, DayOfMonthComboBox.Text, MonthComboBox.Text, YearComboBox.Text, result);

            var document = ReadDocument();
            document = AddDate(document, date);
            Save(document);

            MessageBox.Show($"{result}");
        }
    }
}
