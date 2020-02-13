using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantSuggester
{
  public partial class Form1 : Form
  {
    readonly int MinTemp = 50;
    readonly int MaxTemp = 90;

    bool showMinWarning = false;
    bool showMaxWarning = false;
    public Form1()
    {
      InitializeComponent();
      this.trkDegrees.Scroll += new System.EventHandler(this.houseConditionsChange);
      this.trkDegrees.Minimum = MinTemp;
      this.trkDegrees.Maximum = MaxTemp;
    }

    private void trkDegrees_Scroll(object sender, EventArgs e)
    {
      txtDegrees.Text = trkDegrees.Value.ToString() + " °F";
    }

    private void houseConditionsChange(object sender, EventArgs e)
    {
      // gets the user's input.
      int homeTemp = trkDegrees.Value;
      bool southFacingWindow = cbSouthWindow.Checked;

      // checks if it should be showing the temperature warning
      if(homeTemp == MinTemp && showMinWarning == false)
      {
        MessageBox.Show(text: "Your house may be to cold for most houseplants.", caption: "Information");
        showMinWarning = true;
      }
      else if (homeTemp == MaxTemp && showMaxWarning == false)
      {
        MessageBox.Show(text: "Your house may be to warm for most houseplants.", caption: "Information");
        showMaxWarning = true;
      }

      string suggestedPlant = GenerateSuggestion(homeTemp, southFacingWindow);
      lblPlantSuggest.Text = suggestedPlant;
    }

    private string GenerateSuggestion(int temp, bool southFacing)
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

    private string makeUrl(string plantName = null)
    {
      //generates a url based on the plant name parameter.
      string url = "https://www.houseplant411.com";

      url = url + "/houseplant?hpq=" + plantName;

      return url;
    }

    private void lnkplant411_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      // Navigates to a website.
      string url;
      if (lblPlantSuggest.Text == "Plant Suggestion")
      {
        url = makeUrl();
      }
      else
      {
        url = makeUrl(lblPlantSuggest.Text);
      }
      System.Diagnostics.Process.Start(url);
    }
  }
}
