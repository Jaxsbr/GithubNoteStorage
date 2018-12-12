using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
  public class GitRepository : IGitRepository
  {
    private string _url;
    private string _localDirectory;
    private string _repositoryName;

    public GitRepository(string url, string localDirectory, string repositoryName)
    {
      _url = url;

      _localDirectory = localDirectory;

      _repositoryName = repositoryName;
    }


    public string URL {  get { return _url; } }

    public string LocalDirectory { get { return _localDirectory; } }

    public string RepositoryName { get { return _repositoryName; } }
  }
}
