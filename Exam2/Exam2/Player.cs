using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class Player
    {

        //  public  string[] firstNames = {
        //          "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
        //          "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
        //          "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


        //public  string[] lastNames = {
        //          "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
        //          "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
        //          "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
        //      };

        public string firstNames { get; set; }
        public string lastNames { get; set; }
        public Position PreferredPosition { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }



        public Player(string fname, string lname, Position position, DateTime DOB, int age)
        {
            firstNames = fname;
            lastNames = lname;
            PreferredPosition = position;
            DateOfBirth = DOB;
            Age = age;

        }













        //public Player(string[] fname,string[] lname,Position position,DateTime DOB,int age)
        // {
        //     firstNames = fname;
        //     lastNames = lname;
        //     PreferredPosition = position;
        //     DateOfBirth = DOB;
        //     Age = age;

        // }

        //Player p1 = new Player("fname: " + 1, lname: , Position.Defender, new DateTime(2019, 6, 2), 1);


        public override string ToString()
        {
            return $"{firstNames} {lastNames} {Age}  {PreferredPosition} ";
        }


    }
}
