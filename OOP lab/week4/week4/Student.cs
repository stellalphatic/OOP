using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class Student
    {
        public string name;
        public int rollNumber;
        public float cgpa;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;

        public float CalculateMerit()
        {
            return 0.6f * fscMarks + (0.4f * ecatMarks);
        }

      
        public bool IsEligibleForScholarship()
        {
            if (isHostelite)
            {
                float merit = CalculateMerit();
                return merit > 80; 
            }
            return false;
        }
    
    }
}
