using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSuggester
{
  class HousePlantInfo
  {
    public string GenerateSuggestion(int temp, bool southFacing)
    {
      // generates a houseplant based on given parameters.
      if (southFacing)
      {
        if (temp > 65)
        {
          return "Peace Lily";
        }
        else
        {
          return "Spider Plant";
        }
      }
      else
      {
        if (temp > 65)
        {
          return "Dragon Tree";
        }
        else
        {
          return "Ivy";
        }
      }
    }

    public string makeUrl(string plantName = null)
    {
      //generates a url based on the plant name parameter.
      string url = "https://www.houseplant411.com";

      url = url + "/houseplant?hpq=" + plantName;

      return url;
    }
  }
}
