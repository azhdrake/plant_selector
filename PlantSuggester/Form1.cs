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

    HousePlantInfo plantInfo = new HousePlantInfo();

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

      string suggestedPlant = plantInfo.GenerateSuggestion(homeTemp, southFacingWindow);
      lblPlantSuggest.Text = suggestedPlant;
    }

    

    

    private void lnkplant411_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      // Navigates to a website.
      string url;
      if (lblPlantSuggest.Text == "Plant Suggestion")
      {
        url = plantInfo.makeUrl();
      }
      else
      {
        url = plantInfo.makeUrl(lblPlantSuggest.Text);
      }
      System.Diagnostics.Process.Start(url);
    }
  }
}
