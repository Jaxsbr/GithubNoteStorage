using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
  public class GitHubAccess : IGitHubAccess
  {
    private string _userName;
    private string _password;


    public GitHubAccess(string userName, string password)
    {
      _userName = userName;

      _password = password;
    }


    public string UserName { get { return _userName; } }

    public string Password { get { return _password; } }

    public string BasicAuthValue
    {
      get
      {
        var pair = $"{UserName}:{Password}";

        var bytes = Encoding.ASCII.GetBytes(pair);

        var base64 = Convert.ToBase64String(bytes);

        var basicAuthValue = $"Basic {base64}";

        return basicAuthValue;
      }
    }
  }
}
