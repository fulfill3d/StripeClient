using Client.Model.SetupIntent;

namespace Client.Interface
{
    public interface ISetupIntentClient
    {
        SetupIntentResult SetupCardIntent(string stripeCustomerId);
    }
}