using System.Collections.Generic;

namespace Task_2
{
    public class Person {

        public string FirstName;
        public string Surname;
        public string DOB;
        public int Height;

        public List<Person> persons;

    
    public Person(string firstname, string surname, string dob, int height) {

        this.FirstName = firstname;
        this.Surname = surname;
        this.DOB = dob;
        this.Height = height;
    }

    public string GetFullName() {
        
        string Name = this.FirstName + " " + this.Surname;

        return Name;


    }

    public Person GetHeightDifference() {

        Person HeightDiff = this.persons[0];
        foreach( Person H in this.persons) {
            if (H.Height > HeightDiff.Height) {
                HeightDiff = H;
            }

        }
        return HeightDiff;

    }


    }



}