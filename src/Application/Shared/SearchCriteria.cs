namespace Application.Shared
{
    public class SearchCriteria<T>
    {
        public object? Filter { get; set; }
        public IEnumerable<T> Data { get; set; } = Enumerable.Empty<T>();
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int TotalRecords { get; set; }
        public string? SortBy { get; set; }
        public bool SortDescending { get; set; }
    }
}
