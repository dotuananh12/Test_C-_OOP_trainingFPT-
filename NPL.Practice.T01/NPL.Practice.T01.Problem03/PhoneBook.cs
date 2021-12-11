using System;

namespace NPL.Practice.T01.Problem03
{
    public class PhoneBook
    {
        private string _phoneNumber;
        private string _group;

        public string Name { get; set; }


        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value.Length == 12)
                {
                    if (value.Substring(0, 1) == "0")
                    {
                        if (value.Substring(3, 1) == " " && value.Substring(7, 1) == " ")
                        {
                            if (int.TryParse(value.Replace(" ", ""), out int Result))
                                _phoneNumber = value;

                            else
                                throw new ArgumentException("Input value is not correct!");
                        }
                        else
                            throw new ArgumentException("Input value is not correct!");
                    }
                    else
                        throw new ArgumentException("Input value is not correct!");
                }          
            }
        }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Group
        {
            get => _group;
            set
            {
                if (_group != "Family" && _group != "Colleague" && _group != "Friend" && _group != "Orther")
                    _group = value;

                else
                    throw new ArgumentException("Input value is not correct");
            }
        }
    }

}
