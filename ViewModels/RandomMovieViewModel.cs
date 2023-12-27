using vidly.Models;

namespace vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public required Movie Movie { get; set; }
        public List<Customer>? Customers { get; set; }
    }
}