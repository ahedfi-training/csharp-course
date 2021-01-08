namespace Demo
{
    public class Person
    {
        #region Fields
        public int Age;
        public decimal salary;
        public decimal salary2;
        public decimal salary3;
        #endregion

        #region Contructors
        #endregion

        #region Methods
        #endregion

        #region operator
        public static explicit operator decimal(Person p)
        {
            // Logic
            return p.salary;
        }
        public static implicit operator int(Person p)
        {
            return p.Age;
        }
        #endregion
    }
}

