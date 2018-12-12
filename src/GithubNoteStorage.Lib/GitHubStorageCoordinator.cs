using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
  public class GitHubStorageCoordinator : IGitHubStorageCoordinator
  {    
    private IGitCommands _gitCommands;
    private IGitRepository _gitRepository;    
    private IRepositoryManager _repositoryManager;


    public GitHubStorageCoordinator(IGitCommands gitCommands, IGitRepository gitRepository, IRepositoryManager repositoryManager)
    {
      _gitCommands = gitCommands;

      _gitRepository = gitRepository;

      _repositoryManager = repositoryManager;      
    }


    public void CloneOrPull(Action<string> logInfo)
    {
      var fullDirectory = Path.Combine(_gitRepository.LocalDirectory, _gitRepository.RepositoryName);

      if (Directory.Exists(fullDirectory))
      {
        _repositoryManager.Pull(ExecuteGitCommand);
        
        logInfo("Pull executed");
      }
      else
      {
        _repositoryManager.Clone(ExecuteGitCommand);

        logInfo("Clone executed");
      }
    }

    public void ExecuteGitCommand(string[] commands, string workingDirectory)
    {
      using (var powerShell = PowerShell.Create())
      {
        powerShell.AddScript($"cd {workingDirectory}");

        commands.ToList().ForEach(c => powerShell.AddScript(c));

        var results = powerShell.Invoke();
      }
    }
  }
}
