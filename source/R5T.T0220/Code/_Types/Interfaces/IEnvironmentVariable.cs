using System;

using R5T.T0199;


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
