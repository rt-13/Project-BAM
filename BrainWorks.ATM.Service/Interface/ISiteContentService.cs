using BrainWorks.ATM.Data;
using System.Collections.Generic;

namespace BrainWorks.ATM.Service
{
	public interface ISiteContentService
	{
		IEnumerable<SiteContent> GetSiteContentsByReference(string reference);
	}
}
