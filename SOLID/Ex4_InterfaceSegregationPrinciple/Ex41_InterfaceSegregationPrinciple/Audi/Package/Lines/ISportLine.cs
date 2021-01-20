using Ex41_InterfaceSegregationPrinciple.Audi.Package;

namespace Ex41_InterfaceSegregationPrinciple.Audi.Package.Lines
{
    public interface ISportLine : ISLine, IAudiConnect, IAudiPreSenseFront
    {

    }

}
