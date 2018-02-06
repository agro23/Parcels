// namespace Parcels.Models
namespace Parcels.Models
{
  public class Parcel
  {
    private string _recipient; // this is the var that it is contained in

// This will be one of the form vars

    private string _sender;
    private string _weight;
    private string _height;
    private string _length;
    private string _width;

    public string GetWeight()
    {
    return _weight; //@Model.GetRecipient()
    }

    public void SetWeight(string newWeight)
    {
    _weight = newWeight;
    }

    public string GetHeight()
    {
    return _height; //@Model.GetRecipient()
    }

    public void SetHeight(string newHeight)
    {
    _height = newHeight;
    }

    public string GetLength()
    {
    return _length; //@Model.GetRecipient()
    }

    public void SetLength(string newLength)
    {
    _length = newLength;
    }

    public string GetWidth()
    {
    return _width; //@Model.GetRecipient()
    }

    public void SetWidth(string newWidth)
    {
    _width = newWidth;
    }

    // public int Volume(int myWidth, int myHeight, int myLength)
    // {
    //   int answer = myWidth * myHeight * myLength;
    //   return answer; //@Model.GetRecipient()
    // }
    //
    // public int CostToShip(int myWeight, int myVolume)
    // {
    //   int cost = myWeight * 6;
    //   if (myVolume > 1000)
    //   {
    //       cost += cost * ( (myVolume - 1000) / 100 );
    //   }
    //   return cost;
    // }

  }
}
