using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PatientLibrary
{
    // using Interface
    public class Patient : IPatient
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dOB { get; set; }
        public string problem { get; set; }
        public string clinicalNote { get; set; }

        const string regexName = @"^[a-zA-Z]+[\s]+[a-zA-Z]+";
        public Patient()
        {

        }

        public Patient(int id, string name, DateTime dOB, string problem, string clinicalNote)
        {
            this.id = id;
            this.name = name;
            this.dOB = dOB;
            this.problem = problem;
            this.clinicalNote = clinicalNote;

            string invalidEntry = string.Empty;

            invalidEntry = CheckInputs();



            if (!string.IsNullOrEmpty(invalidEntry))
            {
                throw new ArgumentException(invalidEntry);
            }

        }
        // overide? the previous CheckInputs
        public string CheckInputs()
        {
            // validation and throw error to main
            string invalidEntry = string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                invalidEntry += $"Please Enter name !{Environment.NewLine}";

            }
            else
            {
                var validName = Regex.Match(name, regexName);
                if (!validName.Success)
                {
                    invalidEntry += $"Please Enter a valid name!{Environment.NewLine}";
                }
            }

            DateTime nowDate = DateTime.Now;

            string tempNow = nowDate.ToString("MM/dd/yyyy");
            string tempDOB = dOB.ToString("MM/dd/yyyy");

            if (nowDate >= dOB || tempNow == tempDOB)
            {
                this.dOB = dOB;
            }
            else
            {
                invalidEntry += $"Date can not be in the future!{Environment.NewLine}";
            }

            if (string.IsNullOrEmpty(clinicalNote))
            {
                invalidEntry += $"Please fill out clinical note !{Environment.NewLine}";

            }

            return invalidEntry;
        }

        // changing Patient object Tostring 
        public override string ToString()
        {
            string str = id + "|" + name + "|" + dOB.ToString("dd MMM yyyy") + "|" + problem+"|"+clinicalNote;
            return str;
        }
    }
}
