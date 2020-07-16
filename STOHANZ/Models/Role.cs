using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Role
{
    public int UserId { get; set; }
    public string RoleName { get; set; }

    public Role()
	{
	}
    public Role(int UserId_, string RoleName_)
    {
        this.UserId = UserId_;
        this.RoleName = RoleName_;
    }
}
