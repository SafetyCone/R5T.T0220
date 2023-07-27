using System;

using R5T.T0199;


namespace R5T.T0220
{
    public class EnvironmentVariable : IEnvironmentVariable
    {
        public IEnvironmentVariableName Name { get; set; }
        public IEnvironmentVariableValue Value { get; set; }
    }
}
