﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : object
    {

        /*ctor snippet will make a constructor for you just type and tab twice*/
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public virtual GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
            //if (!String.IsNullOrEmpty(value))
            //{
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                
                if(_name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.existingName = _name;
                    args.newName = value;

                    NameChanged(this, args);
                //}

                _name = value;
                }
            }
       }
        public event NameChangedDelegate NameChanged;
        private string _name;
        protected List<float> grades;
    }
}
