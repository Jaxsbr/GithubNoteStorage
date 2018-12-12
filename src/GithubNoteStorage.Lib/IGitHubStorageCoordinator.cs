using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
  public interface IGitHubStorageCoordinator
  {    
    void CloneOrPull(Action<string> logInfo);

    void ExecuteGitCommand(string[] commands, string workingDirectory);
  }
}
