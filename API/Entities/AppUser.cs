using System;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; } // if the name is not "ID" then the db wont know its the PK. Also, using int will increment the PK
    public required string UserName { get; set; }

}
