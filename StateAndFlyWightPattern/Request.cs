namespace StateAndFlyWightPattern
{
    public class Request
    {
        public RequestState RequestState { get; private set; }
        public int Amount { get; private set; }

        public Request()
        {
            Amount = 0;
            RequestState=new DraftRequestState();
        }

        public void UpdateAmount(int amount)
        {
            if (RequestState.CanUpdateRequest())
            {
                this.Amount = amount;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Accepted()
        {
            if (RequestState.CanAcceptRequest())
            {
                this.RequestState = new AcceptedRequestState();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
