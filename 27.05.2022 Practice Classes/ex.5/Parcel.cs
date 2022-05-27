namespace ex._5;

public class Parcel
{
    public string Sender { get; private set; }
    public string Receiver { get; private set; }
    public string SenderAddress { get; private set; }
    public string ReceiverAddress { get; private set; }
    public DateTime SendDate { get; private set; }

    public Parcel(string sender, string receiver, string senderAddress, string receiverAddress, DateTime sendDate)
    {
        Sender = sender;
        Receiver = receiver;
        SenderAddress = senderAddress;
        ReceiverAddress = receiverAddress;
        SendDate = sendDate;
    }

    public void Send()
    {
        SendDate = DateTime.Now;
    }
}