using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание 4
// Создайте класс «Веб-сайт»
// Необходимо хранить в полях класса: название сайта, путь к сайту, описание сайта, ip адрес сайта
// Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса

// Задание 5
// Создайте класс «Журнал»
// Необходимо хранить в полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail
// Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса

// Задание 6
// Создайте класс «Магазин»
// Необходимо хранить в полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
// Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса



// ----- Если нужно было использовать свойства вместо полей, то я не понял этого -----
namespace Introduction_to_Classes
{
    internal class WebSite
    {
        public string Name;
        public string Url;
        public string Description;
        public string IP;

        public WebSite(string name, string url, string description, string iP)
        {
            Name = name;
            Url = url;
            Description = description;
            IP = iP;
        }

        public void SetName(string newName) { Name = newName; }
        public void SetUrl(string url) { Url = url; }
        public void SetDescription(string description) { Description = description; }
        public void SetIP(string ip) { IP = ip; }

        public string GetName() { return Name; }
        public string GetUrl() { return Url; }
        public string GetDescription() { return Description; }
        public string GetIP() { return IP; }
    }

    internal class Magazine
    {
        public string Name;
        public string Description;
        public string Number;
        public string Email;
        public int FoundationYear;

        public Magazine(string name, int foundationYear, string description, string number, string email)
        {
            Name = name;
            Description = description;
            Number = number;
            Email = email;
            FoundationYear = foundationYear;
        }

        public void SetName(string newName) { Name = newName; }
        public void SetDescription(string newDescription) { Description = newDescription; }
        public void SetNumber(string newNumber) { Number = newNumber; }
        public void SetEmail(string newEmail) { Email = newEmail; }
        public void SetFoundationYear(int newFoundationYear) { FoundationYear = newFoundationYear; }


        public string GetName() { return Name; }
        public string GetDescription() { return Description; }
        public string GetNumber() { return Number; }
        public string GetEmail() { return Email; }
        public int GetFoundationYear() { return FoundationYear; }
    }

    internal class Store
    {
        public string Name;
        public string Adress;
        public string Description;
        public string Number;
        public string Email;

        public Store(string name, string adress, string description, string number, string email)
        {
            Name = name;
            Adress = adress;
            Description = description;
            Number = number;
            Email = email;
        }

        public void SetName(string newName) { Name = newName; }
        public void SetAdress(string newAdress) { Adress = newAdress; }
        public void SetDescription(string newDescription) { Description = newDescription; }
        public void SetNumber(string newNumber) { Number = newNumber; }
        public void SetEmail(string newEmail) { Email = newEmail; }

        public string GetName() { return Name; }
        public string GetAdress() { return Adress; }
        public string GetDescription() { return Description; }
        public string GetNumber() { return Number; }
        public string GetEmail() { return Email; }
    }
}
