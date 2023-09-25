
namespace StateAndFlyWightPattern
{
    public abstract class RequestState
    {
        public virtual bool CanUpdateRequest()
        {
            return false;
        }

        public virtual bool CanAcceptRequest()
        {
            return false;
        }
    }
}
