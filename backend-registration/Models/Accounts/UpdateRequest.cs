using System.ComponentModel.DataAnnotations;
using Registration.Entities;

namespace Registration.Models.Accounts
{
    public class UpdateRequest
    {
        private string _password;
        private string _confirmPassword;
        private string _role;
        private string _email;
        
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }

        [EnumDataType(typeof(Role))]
        public string Role
        {
            get => _role;
            set => _role = replaceEmptyWithNull(value);
        }

        [EmailAddress]
        public string Email
        {
            get => _email;
            set => _email = replaceEmptyWithNull(value);
        }

        [MinLength(6)]
        public string Password
        {
            get => _password;
            set => _password = replaceEmptyWithNull(value);
        }

        [Compare("Password")]
        public string ConfirmPassword 
        {
            get => _confirmPassword;
            set => _confirmPassword = replaceEmptyWithNull(value);
        }

        private string replaceEmptyWithNull(string value)
        {
            //������ ������ ������ �� null, ����� ������� ���� ��������������
            return string.IsNullOrEmpty(value) ? null : value;
        }
    }
}