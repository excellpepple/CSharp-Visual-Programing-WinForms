using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ExcellPepplePasswordChecker
{
    public partial class PasswordChecker : Form
    {
        // flags to track password validation criteria
        private bool hasUppercase = false;
        private bool hasLowercase = false;
        private bool hasNumber = false;
        private bool hasSpecialCharacter = false;
        private bool hasRequiredLength = false;

        public PasswordChecker()
        {
            InitializeComponent();
            ResetPage(); // reset the page UI when form loads
            textPasswordLength.Text = "4"; // set default minimum password length
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            int minLength;

            // validate the minimum password length input
            if (!int.TryParse(textPasswordLength.Text, out minLength) || minLength < 4)
            {
                MessageBox.Show("Please enter a valid number of 4 or more for Minimum Password Length", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPasswordLength.Focus();
                return;
            }

            string userPassword = textPassword.Text;

            // keep prompting user until the password meets the minimum length
            while (userPassword.Length < minLength)
            {
                MessageBox.Show("Password must be at least " + minLength + " characters long. Please re-enter.", "Invalid Password Length");
                userPassword = Interaction.InputBox("Enter your password:", "Password Required", "");
            }

            // update the password textbox with the valid password
            textPassword.Text = userPassword;

            try
            {
                ResetPage(); // reset all validation flags and UI
                ValidatePassword(); // check password rules

                UpdatePage(); // show updated validation status
            }
            catch (InvalidPasswordException error)
            {
                // handle specific validation failures and update flags
                switch (error.ValidationReason)
                {
                    case InvalidPasswordReason.MissingLowercase:
                        hasLowercase = false;
                        break;
                    case InvalidPasswordReason.MissingNumber:
                        hasNumber = false;
                        break;
                    case InvalidPasswordReason.MissingUppercase:
                        hasUppercase = false;
                        break;
                    case InvalidPasswordReason.MissingSpecialCharacter:
                        hasSpecialCharacter = false;
                        break;
                    case InvalidPasswordReason.InvalidLength:
                        hasRequiredLength = false;
                        break;
                }

                UpdatePage(); // update the page UI after handling failure
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length;
            if (!int.TryParse(textPasswordLength.Text, out length) || length < 4)
                length = 4; // ensure minimum length is at least 4

            string generatedPassword = GeneratePassword(length); // create a valid password
            textPassword.Text = generatedPassword; // show generated password in textbox
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the application
            Application.Exit();
        }

        private void ResetPage()
        {
            // hide all "valid" indicators
            picLengthValid.Visible = false;
            picLowercaseValid.Visible = false;
            picNumberValid.Visible = false;
            picSpecialCharacterValid.Visible = false;
            picUppercaseValid.Visible = false;

            // show all "invalid" indicators
            picUppercaseInvalid.Visible = true;
            picLowerCaseInvalid.Visible = true;
            picLengthInvalid.Visible = true;
            picLowerCaseInvalid.Visible = true;
            picNumberInvalid.Visible = true;

            // reset all password validation flags
            hasUppercase = hasLowercase = hasNumber = hasSpecialCharacter = hasRequiredLength = false;
        }

        private void UpdatePage()
        {
            // update the UI indicators based on validation flags
            picLengthValid.Visible = hasRequiredLength;
            picLengthInvalid.Visible = !hasRequiredLength;

            picUppercaseValid.Visible = hasUppercase;
            picUppercaseInvalid.Visible = !hasUppercase;

            picLowercaseValid.Visible = hasLowercase;
            picLowerCaseInvalid.Visible = !hasLowercase;

            picNumberValid.Visible = hasNumber;
            picNumberInvalid.Visible = !hasNumber;

            picSpecialCharacterValid.Visible = hasSpecialCharacter;
            picSpecialCharacterInvalid.Visible = !hasSpecialCharacter;
        }

        public void UpdateResults(string Inpassword)
        {
            listBoxPasswordResults.Items.Clear(); // clear previous results

            // loop through each character and show its ASCII value
            for (int i = 0; i < Inpassword.Length; i++)
            {
                char ch = Inpassword[i];
                int asciiValue = (int)ch; // convert char to ASCII
                listBoxPasswordResults.Items.Add(
                    "Position " + i + " is '" + ch + "' with ASCII Value " + asciiValue
                );
            };
        }

        private string GeneratePassword(int length)
        {
            // define character sets for password
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string special = "!@#$%^&*()-_=+[]{}|;:',.<>?/";

            Random rand = new Random();
            List<char> passwordChars = new List<char>();

            // ensure at least one character of each type
            passwordChars.Add(upper[rand.Next(upper.Length)]);
            passwordChars.Add(lower[rand.Next(lower.Length)]);
            passwordChars.Add(digits[rand.Next(digits.Length)]);
            passwordChars.Add(special[rand.Next(special.Length)]);

            // fill the rest of the password randomly
            string allChars = upper + lower + digits + special;
            while (passwordChars.Count < length)
            {
                passwordChars.Add(allChars[rand.Next(allChars.Length)]);
            }

            // shuffle the password to avoid predictable order
            passwordChars = passwordChars.OrderBy(c => rand.Next()).ToList();

            return new string(passwordChars.ToArray()); // return as string
        }

        private void ValidatePassword()
        {
            string userPassword = textPassword.Text;

            // check if the password contains spaces
            if (userPassword.Any(char.IsWhiteSpace))
            {
                MessageBox.Show("A Space IS NOT a valid special character", "No Spaces Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPassword.Clear(); // clear the textbox if spaces exist
                throw new InvalidPasswordException(InvalidPasswordReason.EmptyField);
            }

            // check if the password field is empty
            if (string.IsNullOrWhiteSpace(userPassword))
                throw new InvalidPasswordException(InvalidPasswordReason.EmptyField);

            // reset all validation flags
            hasUppercase = hasLowercase = hasNumber = hasSpecialCharacter = hasRequiredLength = false;

            int minLength;
            if (!int.TryParse(textPasswordLength.Text, out minLength))
                minLength = 4;

            // check minimum length requirement
            if (userPassword.Length < minLength)
                throw new InvalidPasswordException(InvalidPasswordReason.InvalidLength);
            else
                hasRequiredLength = true;

            UpdateResults(userPassword); // update listbox with password ASCII values

            // check for lowercase letters
            if (!userPassword.Any(char.IsLower))
                throw new InvalidPasswordException(InvalidPasswordReason.MissingLowercase);
            else
                hasLowercase = true;

            // check for uppercase letters
            if (!userPassword.Any(char.IsUpper))
                throw new InvalidPasswordException(InvalidPasswordReason.MissingUppercase);
            else
                hasUppercase = true;

            // check for digits
            if (!userPassword.Any(char.IsDigit))
                throw new InvalidPasswordException(InvalidPasswordReason.MissingNumber);
            else
                hasNumber = true;

            // check for special characters
            hasSpecialCharacter = userPassword.Any(ch => !char.IsLetterOrDigit(ch));
            if (!hasSpecialCharacter)
                throw new InvalidPasswordException(InvalidPasswordReason.MissingSpecialCharacter);
        }
    }

    // enum to define types of password validation errors
    public enum InvalidPasswordReason
    {
        MissingUppercase,
        MissingLowercase,
        MissingNumber,
        MissingSpecialCharacter,
        InvalidLength,
        EmptyField
    }

    // custom exception class for invalid passwords :)
    class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordReason ValidationReason { get; set; }

        public InvalidPasswordException(InvalidPasswordReason Reason)
            : base("")
        {
            ValidationReason = Reason;
        }
    }
}
