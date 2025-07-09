
namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ContractTerms : Model 
    {
        public string? ElectronicInvoicingPolicy { get; set; }
        public bool HasElectronicOrdering { get; set; }
        public bool HasElectronicPayment { get; set; }
        public string? PerformanceTerms { get; set; }
        public bool ReservedExecution { get; set; }
    }
}