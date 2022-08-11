using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    
    public class NameObject
    {
        public NameObject(string name)
        {
            Name = name;
        }
        public string Name
        {
            get;
            set;
        }
    }

    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name{ get; }
        event GradeAddedDelegate GradeAdded;

    }

    public abstract class Book : NameObject, IBook
    {
        protected Book(string name) : base(name)
        {
        }

        public virtual event GradeAddedDelegate? GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
    
    public class InMemoryBook : Book
    {
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(char Letter)
        {
            switch(Letter)
            {
                case 'A':
                    AddGrade(80.0);
                    break;
                case 'B':
                    AddGrade(70.0);
                    break;
                case 'C':
                    AddGrade(60.0);
                    break;
                default:
                    AddGrade(0.0);
                    break;
            }
        }

        public override void AddGrade(double grade)
        {
            if(grade >= 0 && grade <=100)
            {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public override event GradeAddedDelegate? GradeAdded;

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for(var index = 0; index < grades.Count; index++)
            {
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;

            switch(result.Average)
            {
                case var d when d>=80:
                    result.Letter = 'A';
                    break;
                case var d when d>=70:
                    result.Letter = 'B';
                    break;
                case var d when d>=60:
                    result.Letter = 'C';
                    break;
                default:
                    result.Letter = 'D';
                    break;
            }
            
            return result;
        }
        private List<double> grades;
    }
}