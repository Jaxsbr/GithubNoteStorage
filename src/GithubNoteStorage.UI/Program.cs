using GithubNoteStorage.Lib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.UI
{
  class Program
  {
    private string _repositoryURL;
    private string _localDirectory;
    private string _repositoryName;    
    private IGitHubStorageCoordinator _gitHubStorageCoordinator;

    static void Main(string[] args)
    {
      var p = new Program();

      p.InitConfig();

      p.InitGit();

      p._gitHubStorageCoordinator.CloneOrPull(Console.WriteLine);      

      Console.Read();
    }

    private void InitConfig()
    {
      _repositoryURL = ConfigurationManager.AppSettings.Get("repositoryURL");

      _localDirectory = ConfigurationManager.AppSettings.Get("localDirectory");

      _repositoryName = ConfigurationManager.AppSettings.Get("repositoryName");
    }

    private void InitGit()
    {
      var gitCommands = new GitCommands();

      var gitRepository = new GitRepository(_repositoryURL, _localDirectory, _repositoryName);

      var repositoryManager = new RepositoryManager(gitCommands, gitRepository);

      _gitHubStorageCoordinator = new GitHubStorageCoordinator(gitCommands, gitRepository, repositoryManager);
    }
  }
}
