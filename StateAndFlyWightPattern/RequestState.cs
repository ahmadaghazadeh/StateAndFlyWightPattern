
namespace StateAndFlyWightPattern
{
    public abstract class RequestState
    {
        public virtual bool CanUpdateRequest()=> false;
       

        public virtual bool CanAcceptRequest() => false;
    }
}
