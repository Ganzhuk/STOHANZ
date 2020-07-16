using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using STOHANZ.Models.Repository;

public class User
{
    public int UserId { get; set; }
    public string LogName { get; set; }
    public string Pass { get; set; }
    public virtual Role RoleId { get; set; }

    public User()
    {
    }
    public User(int UserId_, string LogName_, string Pass_, Role RoleId_)
    {
        this.UserId = UserId_;
        this.LogName = LogName_;
        this.Pass = Pass_;
        this.RoleId = RoleId_;
    }
}


