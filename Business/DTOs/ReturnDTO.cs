namespace Business.DTOs
{
    public class ReturnDTO<T> where T : class
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
