namespace IMC.Services
{
    public class ServicesIMC
    {
        private readonly List<(double, DateTime)> IMCResults = [];

        public void AddToList(double imc)
        {
            IMCResults.Add((imc, DateTime.Now));
        }

        public IReadOnlyList<(double, DateTime)> GetIMCASResults()
        {
            return IMCResults.AsReadOnly();
        }
    }
}

