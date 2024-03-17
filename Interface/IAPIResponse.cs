namespace VFXChallenge.Interface
{
    public class IAPIResponse<T>
    {
        public bool HasError { get; set; }
        public string MsgError { get; set; }
        public T? Data { get; set; }
    }
}
