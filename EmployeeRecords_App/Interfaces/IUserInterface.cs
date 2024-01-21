using System;
using EmployeeRecords_App.Enums;

namespace EmployeeRecords_App.Interfaces
{
    public interface IUserInterface
    {
        void ShowMessage(string message);
        void ShowEmptyLine();
        int ReadValidAge(string prompt);
        Position ReadValidPosition(string prompt);
        int ReadInt(string prompt);
        decimal ReadDecimal(string prompt);
    }
}