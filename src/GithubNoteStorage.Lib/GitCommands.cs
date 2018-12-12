using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
  public class GitCommands : IGitCommands
  {
    public string Add()
    {
      var command = "git add .";

      return command;
    }

    public string Commit(string commitMessage)
    {
      var command = $"git commit -m '{commitMessage}'";

      return command;
    }

    public string Pull()
    {
      var command = "git pull";

      return command;
    }

    public string Push()
    {
      var command = "git push";

      return command;
    }

    public string Clone(string repositoryURL)
    {
      var command = $"git clone {repositoryURL}";

      return command;
    }
  }
}
