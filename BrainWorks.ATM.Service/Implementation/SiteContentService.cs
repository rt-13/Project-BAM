using BrainWorks.ATM.Data;
using BrainWorks.ATM.Persistence;
using System;
using System.Collections.Generic;

namespace BrainWorks.ATM.Service
{
	public class SiteContentService : ISiteContentService
	{
		private readonly IUnitOfWork _unitOfWork;
		public SiteContentService(IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
		}

		public IEnumerable<SiteContent> GetSiteContentsByReference(string reference)
		{
			return this._unitOfWork.SiteContentRepository.Find(x => string.Compare(x.Reference, reference, StringComparison.OrdinalIgnoreCase) == 0);
		}
	}
}
