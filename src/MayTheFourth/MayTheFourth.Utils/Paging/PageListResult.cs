namespace MayTheFourth.Utils.Paging
{
    public class PageListResult<T> : BasePagedResult
    {
        public IList<T> Results { get; set; }

        public PageListResult()
        {
            Results = [];
        }

        public PageListResult(List<T> pItems)
        {
            Results = pItems;
            CurrentPage = 1;
            var CountItems = pItems.Count;
            PageSize = CountItems;
            HasNext = false;
        }
    }
}
