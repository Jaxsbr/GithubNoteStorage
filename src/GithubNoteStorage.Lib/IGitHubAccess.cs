using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
    public interface IGitHubAccess
    {
        string UserName { get; }
        string Password { get; }  
        string BasicAuthValue { get; }
    }
}
