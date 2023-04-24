using Assignment.Models;
using Assignment.ViewModels;

namespace Assignment.IServices
{
    public interface IQL_BillServices
    {
        public bool CreateBill(QL_BillViews p);
        public bool UpdateBill(QL_BillViews p);
        public bool DeleteBill(Guid id);
        public List<QL_BillViews> GetAllBill();
    }
}
