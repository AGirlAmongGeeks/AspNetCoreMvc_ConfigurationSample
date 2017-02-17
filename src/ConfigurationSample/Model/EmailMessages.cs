using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationSample.Model
{
	//In case you wonder - yes, in 'normal' project, these class should be stored in separeted files :).
	public class EmailMessages
	{
		public bool SendingEnabled { get; set; }
		public FirstMessage FirstMessage { get; set; }
		public SecondMessage SecondMessage { get; set; }
	}

	public class FirstMessage
	{
		public string Title { get; set; }
		public string Message { get; set; }
	}

	public class SecondMessage
	{
		public string Message { get; set; }
		public string Title { get; set; }
	}
}
