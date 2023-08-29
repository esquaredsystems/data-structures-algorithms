using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13
{
    internal class DataItem : IComparable<DataItem>
    {
        private int studentId;
        private string fullName;
        private float cgpa;

        public DataItem() { }

        public DataItem(int studentId, string fullName, float cgpa)
        {
            this.studentId = studentId;
            this.fullName = fullName;
            this.cgpa = cgpa;
        }

        public int getStudentId() {  return studentId; }
        public string getFullName() { return fullName; }
        public float getCGPA() {  return cgpa; }

        public void setStudentId(int studentId) { this.studentId = studentId; } 
        public void setFullName(string fullName) { this.fullName = fullName; }
        public void setCGPA(int cgpa) { this.cgpa = cgpa; }

        public override String ToString()
        {
            return "SID: " + studentId + ", Full Name: " + fullName + ", CGPA: " + cgpa;
        }

        public override bool Equals(object obj)
        {
            return obj is DataItem item &&
                   obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            int hashCode = -1808320576;
            hashCode = hashCode * -1521134295 + studentId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fullName);
            hashCode = hashCode * -1521134295 + cgpa.GetHashCode();
            return hashCode;
        }

        public int CompareTo(DataItem other)
        {
            return other.studentId.CompareTo(this.studentId);
        }
    }
}
