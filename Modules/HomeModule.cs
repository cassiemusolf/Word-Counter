using Nancy;
using WordCounterApp.Objects;
using System.Collections.Generic;

namespace WordCounterApp.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        string userString = Request.Form["user-string"];
        string findWord = Request.Form["find-word"];
        // RepeatCounter newUserString = new RepeatCounter(userString);
        // RepeatCounter newFindWord = new RepeatCounter(findWord);
        RepeatCounter newCounter = new RepeatCounter(userString, findWord);
        int result = newCounter.CountRepeats();
        return View["results.cshtml", result];
      };

      Post["/new"] = _ => {
        return View["index.cshtml"];
      };

    }
  }
}
