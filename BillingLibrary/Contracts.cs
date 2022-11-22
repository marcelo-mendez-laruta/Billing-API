using BillingLibrary.Models;
namespace BillingLibrary
{
    public interface BillingContracts
	{
        string Create(BillModel request);
        List<BillModel> Pending(int ClientId);
        string Pay(BillModel request);
        string PayById(int Id);
        List<BillModel> Search(string Category);
        List<BillModel> PaymentHistory(int ClientId);
        ClientModel? getClient(int ClientId);
    }
}