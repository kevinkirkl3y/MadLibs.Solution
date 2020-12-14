using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
      [Route("/madlib")]
      public ActionResult MadLib(string verb, string pluralnoun, string adjective, string food, string noun, string exclamation, string name, string verbreaction, string location) 
      {
        MadlibVariable madLib = new MadlibVariable(); 
        madLib.Verb = verb;
        madLib.PluralNoun = pluralnoun;
        madLib.Adjective = adjective;
        madLib.Food = food;
        madLib.Noun = noun;
        madLib.Exclamation = exclamation;
        madLib.Name = name;
        madLib.VerbReaction = verbreaction;
        madLib.Location = location;
        return View(madLib);
      }
      [Route("/madlibtwo")]
      public ActionResult MadLibTwo(string verb, string pluralnoun, string adjective, string food, string noun, string exclamation, string name, string verbreaction, string location) 
      {
        MadlibVariable madLib = new MadlibVariable(); 
        madLib.Verb = verb;
        madLib.PluralNoun = pluralnoun;
        madLib.Adjective = adjective;
        madLib.Food = food;
        madLib.Noun = noun;
        madLib.Exclamation = exclamation;
        madLib.Name = name;
        madLib.VerbReaction = verbreaction;
        madLib.Location = location;
        return View(madLib);
      }

      [Route("/form")]
      public ActionResult Form() { return View(); }
    }

}