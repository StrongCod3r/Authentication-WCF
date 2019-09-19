using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace AlitaliaSmtp.Service
{
	public class Authenticator : UserNamePasswordValidator
	{
		public override void Validate(string userName, string password)
		{
			string user = "Alitalia";
			string pass = "123";

			if (!user.Equals(userName) || !pass.Equals(password))
			{
				throw new FaultException("ServiceSMTP: Invalid user and/or password");
			}
		}
	}
}