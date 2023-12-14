using System;

using R5T.N0003;


namespace R5T.T0220
{
    public class EnvironmentVariable : IEnvironmentVariable
    {
        public IEnvironmentVariableName Name { get; set; }
        public IEnvironmentVariableValue Value { get; set; }
    }
}
