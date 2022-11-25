using BillingLibrary.Models;

namespace BillingLibrary
{
    public class BillingServices : BillingContracts
    {
        public BillingContext db;
        public Utils _utils;
        public BillingServices()
        {
            db = new BillingContext();
            _utils = new Utils();
        }
        public BillingServices(BillingContext _db)
        {
            db = _db;
            _utils = new Utils();
        }

        public List<BillModel> Create(BillModel request)
        {
            List<BillModel> response= new();
            try
            {
                if (ValidateDate(request.Period))
                {
                    request.Amount = request.Amount == 0 ? _utils.GetRandomAmount() : request.Amount;
                    if (request.ClientId == 0)
                    {
                        var clients = db.Clients.ToList();
                        clients.ForEach(client =>
                        {
                            BillModel newRequest = new()
                            {
                                ClientId = client.Id,
                                Period = request.Period,
                                Category = request.Category,
                                Amount = request.Amount,
                            };
                            db.Add(newRequest);
                        });
                        db.SaveChanges();
                        return response;
                    }
                    if (getClient(request.ClientId) != null)
                    {
                        db.Add(request);
                        response.Add(request);
                        db.SaveChanges();
                        return response;
                    }
                    return response;
                }
                else
                {
                    return response;
                }

            }
            catch (Exception e)
            {
                return response;
            }
        }
        public List<BillModel> Pending(int ClientId)
        {
            try
            {
                return db.Bills.Where(bill => bill.ClientId == ClientId && bill.State == "Pending").ToList();
            }
            catch (Exception)
            {

                return new List<BillModel>();
            }
        }
        public string Pay(BillModel request)
        {
            try
            {
                var bill = db.Bills.FirstOrDefault(item => item.ClientId == request.ClientId && item.Category == request.Category && item.Period == request.Period);
                if (bill != null && getClient(request.ClientId) != null && ValidateDate(request.Period))
                {
                    if (bill.State != "Paid")
                    {
                        bill.State = "Paid";
                        db.SaveChanges();
                        return "success";
                    }
                    else
                    {
                        return "This bill has already been paid";
                    }
                }
                throw new Exception("Bill not found, verify the data sended.");
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<BillModel> Search(string Category)
        {
            return Category=="ALL"?db.Bills.ToList() : db.Bills.Where(bill => bill.Category == Category).ToList();
        }
        public List<BillModel> PaymentHistory(int ClientId)
        {
            return db.Bills.Where(bill => bill.ClientId == ClientId && bill.State=="Paid").ToList();
        }

        public ClientModel? getClient(int ClientId)
        {
            return db.Clients.Where(client => client.Id == ClientId).FirstOrDefault();
        }
        private bool ValidateDate(int date)
        {
            return true;
        }

        public string PayById(int Id)
        {
            try
            {
                var bill = db.Bills.FirstOrDefault(item => item.Id == Id);
                if (bill != null)
                {
                    if (bill.State != "Paid")
                    {
                        bill.State = "Paid";
                        db.SaveChanges();
                        return "success";
                    }
                    else
                    {
                        return "This bill has already been paid";
                    }
                }
                throw new Exception($"Bill not found, verify the data sended.");
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}