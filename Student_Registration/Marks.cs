namespace Student_Registration
{
    internal class Marks
    {
        public string SubjectName;
        public int MarkScored;
        public int MaxMark;

        public override string ToString()
        {
            return $"Scored {MarkScored} out of {MaxMark} in {SubjectName}.";
        }
    }
}
