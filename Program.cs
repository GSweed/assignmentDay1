using System;
using System.Collections.Generic;

namespace assignmentDay1
{
    public class Member
    {
        public int ID;
        public string firstName;
        public string lastName;
        public string gender;
        public string DOB;
        public string phoneNumber;
        public string birthPlace;
        public int age;
        public Boolean isGreduated;

        private List<Member> listMember = null;
        public Member() {
            listMember = new List<Member>();
        }  
        public void addMember()
        {
            Member mem = new Member();
            Console.WriteLine("Enter first name:");
            mem.firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            mem.lastName = Console.ReadLine();
            Console.WriteLine("Enter gender(MALE/FEMALE):");
            mem.gender = Console.ReadLine();
            Console.WriteLine("Enter DOB(dd-mm-yyyy):");
            mem.DOB = Console.ReadLine();
            Console.WriteLine("Enter phone number:");
            mem.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter birth place:");
            mem.birthPlace = Console.ReadLine();
            Console.WriteLine("Enter age:");
            mem.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Greduated(Y/N):");
            if(Console.ReadLine().ToUpper() == "Y" ){
                isGreduated = true;
            }else if(Console.ReadLine().ToUpper() == "N"){
                isGreduated = false;
            }else{
                Console.WriteLine("Please enter correct format!!");
            }
            for (int i = 0; i < listMember.Count; i++)
            {
                listMember.Add(mem);
            }
            
        }
        public int CountMember()
        {
            int Count = 0;
            if (listMember != null)
            {
                Count = listMember.Count;
            }
            return Count;
        }

        public void Display(){
            
                    Console.WriteLine("First Name: {0}, Last Name: {1}, Gender: {2}, DOB: {3}," +
                                        "Phone Number: {4}, Birth Place: {5}, Age: {6}," +
                                    "Greduated: {7}", firstName, lastName, gender, DOB, phoneNumber, birthPlace, age, isGreduated );
               
        }

        public void ReturnMale(){
            var MaleMember = new List<Member>();
            foreach (var mem in listMember)
                {
                    if (mem.gender == "MALE")
                    {
                        MaleMember.Add(mem);
                    }
                }   

                Console.WriteLine(string.Join(',', MaleMember));

        }

        public void FindOldest(){
            Member Oldest = listMember[0];
            int MAX = Oldest.age;
            for (int i = 0; i < listMember.Count; i++)
            {
                if(listMember[i].age > MAX){
                        MAX = listMember[i].age;
                }
            }
            Console.WriteLine("the oldest is: " + MAX );
        }
        public List<Member> getListMember()
        {
            return listMember;
        }
        
        static void Main() {
            Member manageMember = new Member();
            while(true){
                Console.WriteLine("1. Add Member:");
                Console.WriteLine("2. Show Member list:");
                Console.WriteLine("3. Show Male Member list:");
                Console.WriteLine("4. Show the oldest Member:");
                Console.Write("Enter select: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch(key){
                    case 1:
                        Console.WriteLine("\n1. Add Member.");
                        manageMember.addMember();
                        Console.WriteLine("\nAdded Success");
                        break;
                    case 2:
                         manageMember.Display();
                        break;
                    case 3:
                        manageMember.ReturnMale();
                        break;    
                    case 4:
                        manageMember.FindOldest();
                        break;  
                }

            }
        }

    }
    
}