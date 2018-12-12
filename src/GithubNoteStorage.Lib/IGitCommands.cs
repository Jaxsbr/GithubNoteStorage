using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
  public interface IGitCommands
  {
    string Add();
    
    string Commit(string commitMessage);

    string Push();

    string Pull();

    string Clone(string repositoryURL);
  }
}
