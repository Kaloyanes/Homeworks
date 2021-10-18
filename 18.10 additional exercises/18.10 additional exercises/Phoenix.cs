namespace _18._10_additional_exercises
{
    public class Phoenix
    {
        private int _bodyLenght;
        private double _bodyWidth;
        private int _wingLenght;

        public Phoenix(int bodyLenght, double bodyWidth, int wingLenght)
        {
            _bodyLenght = bodyLenght;
            _bodyWidth = bodyWidth;
            _wingLenght = wingLenght;
        }

        public double totalYears()
        {
            return (_bodyLenght * _bodyLenght) * (_bodyWidth + 2 * _wingLenght);
        }
    }
}