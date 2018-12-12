using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
  public class RepositoryManager : IRepositoryManager
  {
    private IGitCommands _gitCommands;
    private IGitRepository _gitRepository;

    public RepositoryManager(IGitCommands gitCommands, IGitRepository gitRepository)
    {
      _gitCommands = gitCommands;

      _gitRepository = gitRepository;
    }

    public void Pull(Action<string[], string> executeAction)
    {
      var command = _gitCommands.Pull();

      if (executeAction != null)
      {
        var workingDirectory = System.IO.Path.Combine(_gitRepository.LocalDirectory, _gitRepository.RepositoryName);

        executeAction(new string[] { command }, workingDirectory);        
      }
    }

    public void Clone(Action<string[], string> executeAction)
    {
      var command = _gitCommands.Clone(_gitRepository.URL);

      if (executeAction != null)
      {
        var workingDirectory = System.IO.Path.Combine(_gitRepository.LocalDirectory, _gitRepository.RepositoryName);

        executeAction(new string[] { command }, _gitRepository.LocalDirectory);
      }
    }
  }
}
