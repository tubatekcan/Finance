using FinanceApp.Models;

namespace FinanceApp.ViewModels
{
    public class IndexVM
    {
        public IEnumerable<Slide> Slides { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}
