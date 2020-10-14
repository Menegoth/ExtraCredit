using System;

namespace Week8 {

    class Student {

        //instance variables
        private int quizOne;
        private int quizTwo;
        private int quizThree;
        private int midtermExam;
        private int finalExam;

        //default constructor
        public Student() { }

        //value constructor
        public Student(int quizOne, int quizTwo, int quizThree, int midtermExam, int finalExam) {
            this.quizOne = quizOne;
            this.quizTwo = quizTwo;
            this.quizThree = quizThree;
            this.midtermExam = midtermExam;
            this.finalExam = finalExam;
        }
        
        //copy constructor
        public Student(Student student) {
            quizOne = student.quizOne;
            quizTwo = student.quizTwo;
            quizThree = student.quizThree;
            midtermExam = student.midtermExam;
            finalExam = student.finalExam;
        }

        //get and set quiz one
        public int GetQuizOne() {
            return quizOne;
        }
        public void SetQuizOne(int quizOne) {
            this.quizOne = quizOne;
        }

        //get and set quizTwo
        public int GetQuizTwo() {
            return quizTwo;
        }
        public void SetQuizTwo(int quizTwo) {
            this.quizTwo = quizTwo;
        }
        
        //get and set quizThree
        public int GetQuizThree() {
            return quizThree;
        }
        public void SetQuizThree(int quizThree) {
            this.quizThree = quizThree;
        }

        //get and set midtermExam
        public int GetMidtermExam() {
            return midtermExam;
        }
        public void SetMidtermExam(int midtermExam) {
            this.midtermExam = midtermExam;
        }

        //get and set finalExam
        public int GetFinalexam() {
            return finalExam;
        }
        public void SetFinalExam(int finalExam) {
            this.finalExam = finalExam;
        }

        //tostring and equals
        public override string ToString() {
            return "Quiz One: " + quizOne + "\nQuiz Two " + quizTwo + "\nQuiz Three: " + quizThree + "\nMidterm: " + midtermExam + "\nFinal: " + finalExam;
        }

        public bool Equals(Student student) {
            return quizOne == student.quizOne && quizTwo == student.quizTwo && quizThree == student.quizThree && midtermExam == student.midtermExam && finalExam == student.finalExam;
        }

        //calculate grade
        public double calculateWeightedGrade() {
            return ((quizOne * (25.0 / 3.0) + quizTwo * (25.0 / 3.0) + quizThree * (25.0 / 3.0) + midtermExam * 35.0 + finalExam * 40.0)/(25+35+40));
        }

    }

    class Program {
        static void Main(string[] args) {

            Student studentA = new Student();
            Student studentB = new Student(70, 70, 70, 80, 60);
            Student studentC = new Student(studentB);

            studentA.SetQuizOne(70);
            studentA.SetQuizTwo(70);
            studentA.SetQuizThree(70);
            studentA.SetMidtermExam(80);
            studentA.SetFinalExam(60);

            Console.WriteLine(studentA.ToString());
            Console.WriteLine(studentB.Equals(studentC));

            Console.WriteLine(studentA.GetQuizOne());
            Console.WriteLine(studentA.GetQuizTwo());
            Console.WriteLine(studentA.GetQuizThree());
            Console.WriteLine(studentA.GetMidtermExam());
            Console.WriteLine(studentA.GetFinalexam());

            Console.WriteLine(studentA.calculateWeightedGrade());

        }
    }
}
