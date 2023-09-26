namespace StateAndFlyWightPattern
{
    public class Request
    {
        public RequestState RequestState { get; private set; }
        public int Amount { get; private set; }

        public Request()
        {
            Amount = 0;
            RequestState=RequestStateFactory.GetState<DraftRequestState>()!;
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
                this.RequestState = RequestStateFactory.GetState<AcceptedRequestState>()!;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
