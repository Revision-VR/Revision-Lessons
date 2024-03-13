using System;

[Serializable]
public class User
{
    public string localId;
    public User()
    {
        localId = LoginAndRegisterController.localId;
    }
}
