// namespace Parcels.Models
namespace Parcels.Models
{
  public class ParcelVar
  {
    private string _recipient; // this is the var that it is contained in

// This will be one of the form vars

    private string _sender;

    public string GetRecipient()
    {
    return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
    _recipient = newRecipient;
    }

    public string GetSender()
    {
    return _sender;
    }

    public void SetSender(string newSender)
    {
    _sender = newSender;
    }
  }
}
