using System;
using System.Linq;
using System.Windows.Forms;
using EmployeeRecords_App.Enums;
using EmployeeRecords_App.Interfaces;
using EmployeeRecords_App.Logging;
using EmployeeRecords_App.Models;

namespace EmployeeRecords_App
{
    public partial class MainForm : Form, IUserInterface
    {
        private IEmployeeManager _employeeManager;

        public MainForm()
        {
            InitializeComponent();

            _employeeManager = new EmployeeManager(new CompanyRepository(new FileLogger()));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ShowMessage("Введите данные сотрудника:");

            var fullName = ShowInputDialog("Имя:");
            var age = ReadValidAge("Возраст:");
            var salary = ReadDecimal("Зарплата:");
            var selectedPosition = ReadValidPosition("Выберите должность (введите номер):");

            var recruitDate = DateTime.Now;

            var newEmployee = new Employee(fullName, age, salary, selectedPosition);

            _employeeManager.RecruitEmployee(newEmployee);
            ShowMessage("Сотрудник добавлен успешно.");
            ShowEmptyLine();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var employeeId = ReadInt("Введите идентификатор сотрудника:");
            _employeeManager.TerminateEmployee(employeeId);
            ShowMessage("Сотрудник удален успешно.");
            ShowEmptyLine();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            var employees = _employeeManager.GetAllEmployees();
            if (employees == null)
            {
                ShowMessage("Список сотрудников пуст.");
            }
            else
            {
                ShowMessage("Список сотрудников:");
                foreach (var employee in employees)
                {
                    ShowMessage(
                        $"Имя: {employee.FullName}, " +
                        $"Должность: {employee.Position}, " +
                        $"Возраст: {employee.Age}, " +
                        $"Зарплата: {employee.Salary}, " +
                        $"Дата найма: {employee.RecrutDate.ToShortDateString()}"
                    );
                }
            }
            ShowEmptyLine();
        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            var employeeId = ReadInt("Введите ID сотрудника:");

            var employee = _employeeManager.GetEmployeeById(employeeId);

            if (employee != null)
            {
                ShowMessage("Информация о сотруднике:");
                ShowMessage($"ID: {employee.Id}, " +
                            $"Имя: {employee.FullName}, " +
                            $"Возраст: {employee.Age}, " +
                            $"Зарплата: {employee.Salary}, " +
                            $"Должность: {employee.Position}, " +
                            $"Дата приема на работу: {employee.RecrutDate}");
            }
            else
            {
                ShowMessage("Сотрудник с указанным ID не найден.");
            }
            ShowEmptyLine();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ShowMessage(string message)
        {
            outbox.AppendText(message + Environment.NewLine);
        }

        public void ShowEmptyLine()
        {
            outbox.AppendText(Environment.NewLine);
        }

        public string ShowInputDialog(string prompt)
        {
            while (true)
            {
                var inputDialog = new InputDialog(prompt);
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    var inputValue = inputDialog.InputValue;
                    if (!string.IsNullOrWhiteSpace(inputValue))
                    {
                        return inputValue;
                    }
                }
                else
                {
                    return null;
                }

                MessageBox.Show("Пустой ввод. Пожалуйста, введите значение.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ReadValidAge(string prompt)
        {
            while (true)
            {
                var input = ShowInputDialog(prompt);
                if (input != null && int.TryParse(input, out var age) && age >= 18)
                {
                    return age;
                }

                MessageBox.Show("Некорректный возраст. " +
                    "Возраст должен быть целым числом и не меньше 18 лет.", 
                    "Ошибка");
            }
        }

        public Position ReadValidPosition(string prompt)
        {
            var positionNames = Enum.GetNames(typeof(Position));
            var positionOptions = string.Join(Environment.NewLine, positionNames
                .Select((position, index) => $"{index + 1}. {position}"));

            while (true)
            {
                var message = $"{prompt}{Environment.NewLine}{positionOptions}";
                MessageBox.Show(message, "Выбор должности", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                var input = ShowInputDialog("Введите номер выбранной должности:");

                if (input != null && int.TryParse(input, out var selectedPositionIndex) &&
                    selectedPositionIndex >= 1 && selectedPositionIndex <= positionNames.Length)
                {
                    var selectedPosition = (Position)(selectedPositionIndex - 1);
                    return selectedPosition;
                }

                MessageBox.Show("Некорректный выбор. " +
                    "Пожалуйста, выберите номер из списка должностей.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public decimal ReadDecimal(string prompt)
        {
            while (true)
            {
                var input = ShowInputDialog(prompt);

                if (input != null && decimal.TryParse(input, out var salary))
                {
                    return salary;
                }

                MessageBox.Show("Некорректная зарплата. Пожалуйста, введите числовое значение.", "Ошибка");
            }
        }

        public int ReadInt(string prompt)
        {
            while (true)
            {
                var input = ShowInputDialog(prompt);
                if (input != null && int.TryParse(input, out var value))
                {
                    return value;
                }

                MessageBox.Show("Некорректное значение. Пожалуйста, введите целое число.", "Ошибка");
            }
        }
    }
}