namespace xUnitTutorial.Service
{
    public class Calculator
    {
        private CalculatorState _state = CalculatorState.Cleared;

        public decimal Value { get; private set; } = 0;

        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Add(decimal value)
        {
            _state = CalculatorState.Active;
            return Value += value;
        }

        /// <summary>
        /// Substraction
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Substract(decimal value)
        {
            _state = CalculatorState.Active;
            return Value -= value;
        }

        /// <summary>
        /// Multiplication
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Multiply(decimal value)
        {
            if (Value == 0 && _state == CalculatorState.Cleared)
            {
                _state = CalculatorState.Active;
                return Value = value;
            }

            return Value *= value;
        }
        
        /// <summary>
        /// Division 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Divide(decimal value)
        {
            if (Value == 0 && _state == CalculatorState.Cleared)
            {
                _state = CalculatorState.Active;
                return Value = value;
            }

            return Value /= value;
        }
        
    }

    internal enum CalculatorState
    {
        Cleared,
        Active
    }
}