namespace StateAndFlyWightPattern
{
    public class DraftRequestState :RequestState
    {
        public override bool CanUpdateRequest() => true;

        public override bool CanAcceptRequest() => true;

    }
}
