using System.Collections.Generic;
using RimDev.Releases.Models;

namespace RimDev.Releases.ViewModels.Releases
{
    public class ShowViewModel
	{
		public ShowViewModel(GitHubRepository currentRepository)
		{
            Releases = new List<ReleaseViewModel>();

            CurrentRepository = currentRepository;
        }
		
		public GitHubRepository CurrentRepository { get;set; }
		public AppSettings AppSettings {get;set;}
		public IList<ReleaseViewModel> Releases {get;set;}
	}

    
}