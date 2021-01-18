using Ex41_InterfaceSegregationPrinciple.Audi.Package;

namespace Ex41_InterfaceSegregationPrinciple.Audi.Package.Lines
{
    interface IAudiExclusive : ISportLine, IDesignLine, IAmbientLighting
    {
    }
}
