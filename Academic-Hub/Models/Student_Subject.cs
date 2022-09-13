namespace Academic_Hub.Models
{
    public class Student_Subject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public double GetAverage()
        {
            var sum = Mark1 + Mark2 + Mark3;
            return sum / 3;
        }
        public double GetLevel()
        {
            var average = GetAverage();
            if (average > 0 && average < 30)
                return 1;
            else if (average > 29 && average < 40)
                return 2;
            else if (average > 39 && average < 50)
                return 3;
            else if (average > 49 && average < 60)
                return 4;
            else if (average > 59 && average < 70)
                return 5;
            else if (average > 69 && average < 75)
                return 6;
            else if (average > 74 && average <= 100)
                return 7;
            else
                return 0;
        }
    }
}
