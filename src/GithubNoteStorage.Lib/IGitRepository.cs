using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
  public interface IGitRepository
  {
    string URL { get; }
    string LocalDirectory { get; }
    string RepositoryName { get; }
  }
}
