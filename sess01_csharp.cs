namespace sess01_csharp_intro
{
    /// <summary>
    /// Represents an Emloyee with an ID, name, and binary gender
    /// </summary>
    public class SampleEmployeeXMLElementDocumentation
    {
        // Fields
        /// <summary>
        /// An unsigned integer to hold the employee's name
        /// </summary>
        private uint _empID;
        private string _empName;
        private char _gender;

        // Constructors
        public SampleEmployeeXMLElementDocumentation()
        {
            this._empID = 0;
            this._empName = string.Empty; // Same as this._empName = "";
            this._gender = '\0';
        }

        public SampleEmployeeXMLElementDocumentation(uint empID, string empName, char gender)
        {
            this._empID = empID;
            this._empName = empName;
            this._gender = gender;
        }

        // Methods / Getters & Setters
        public uint GetID() { return this._empID; }
        public void SetID(uint empID) { this._empID = empID; }

        public string GetName() { return this._empName; }
        public void SetName(string name) { this._empName = name; }

        public char GetGender() { return this._gender; }
        public void SetGender(char gender) { this._gender = gender; }

        public override string ToString()
        {
            return "Employee Details\n" +
                   "-------------------------------------------\n" +
                   $"ID: {this.GetID()}\n" +
                   $"Name: {this.GetName()}\n" +
                   $"Gender: {this.GetGender()}\n" +
                   "-------------------------------------------";
        }
    }
}