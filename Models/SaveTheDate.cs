namespace SaveTheDate.Models;

public static class SaveTheDate
{
    public static Invitation? GetInvitation()
    {
        var invitation = new Invitation{ InvitationDate = new DateTime(2024, 07, 25) };
        
        if (
            ( (Sophie + Micky)! ).GetType() == typeof(Love))
        {
            if (I.AmAvailableOn(new DateTime(2024, 07, 25)))
            {
                invitation.Accept = true;
                return invitation;
            }
        }

        invitation.Accept = false;
        return invitation;
    }

    private static readonly Person I = new();
    private static readonly Person Sophie = new() { Name = "Sophie" };
    private static readonly Person Micky = new() { Name = "Micky" };
}