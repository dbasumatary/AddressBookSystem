using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contacts
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipcode;
        public string phone;
        public string email;

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            if (Regex.IsMatch(value, @"^[A-Z][a-z]{2,}$"))
                firstName = value;
            else
                throw new ArgumentException("Invalid first name");
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            if (Regex.IsMatch(value, @"^[A-Z][a-z]{2,}$"))
                lastName = value;
            else
                throw new ArgumentException("Invalid last name");
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            if (Regex.IsMatch(value, @"^[A-Za-z0-9\s]+$"))
                address = value;
            else
                throw new ArgumentException("Invalid address");
        }

        public string GetCity()
        {
            return city;
        }

        public void SetCity(string value)
        {
            if (Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                city = value;
            else
                throw new ArgumentException("Invalid city");
        }

        public string GetState()
        {
            return state;
        }

        public void SetState(string value)
        {
            if (Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                state = value;
            else
                throw new ArgumentException("Invalid state");
        }

        public string GetZipcode()
        {
            return zipcode;
        }

        public void SetZipcode(string value)
        {
            if (Regex.IsMatch(value, @"^[1-9][0-9]{5}$"))
                zipcode = value;
            else
                throw new ArgumentException("Invalid zipcode");
        }

        public string GetPhone()
        {
            return phone;
        }

        public void SetPhone(string value)
        {
            if (Regex.IsMatch(value, @"^[1-9][0-9]{9}$"))
                phone = value;
            else
                throw new ArgumentException("Invalid phone number");
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            if (Regex.IsMatch(value, @"^[a-z]+([+_.-]?[A-Za-z0-9])*[@][A-Za-z0-9]+([.][a-z]{2,3}){1,2}$"))
                email = value;
            else
                throw new ArgumentException("Invalid email address");
        }

        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name : {lastName}, City: {city}, State: {state}, Address: {address}, ZIP: {zipcode}, Phone: {phone}, Email : {email}";
        }
    }
}
