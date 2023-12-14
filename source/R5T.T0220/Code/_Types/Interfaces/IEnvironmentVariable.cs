using System;

using R5T.N0003;


namespace R5T.T0220
{
    /// <summary>
    /// A strong-type based environment variable representation.
    /// </summary>
    public interface IEnvironmentVariable
    {
        public IEnvironmentVariableName Name { get; }
        public IEnvironmentVariableValue Value { get; }
    }
}
