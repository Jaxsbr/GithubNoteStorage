using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubNoteStorage.Lib
{
  public interface IRepositoryManager
  {
    void Clone(Action<string[], string> executeAction);

    void Pull(Action<string[], string> executeAction);
  }
}
