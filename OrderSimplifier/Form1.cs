using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSimplifier
{
  public partial class Form1 : Form
  {
    private SoundPlayer s1 = new SoundPlayer(Properties.Resources.button_16);
    private SoundPlayer s2 = new SoundPlayer(Properties.Resources.button_50);

    public Form1()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      AutoCopy();
      Simplify();
    }

    private void Simplify()
    {
      int n = Convert.ToInt32(num.Value);
      txtOutput.Text = Simplify1(textBox1.Text, n);
      SelectOutputText();
    }

    private string Simplify1(string text, int units)
    {
      var averagePremium = chkAverage.Checked;
      var commands = new[] { "LF", "SF", "LC", "LP", "SC", "SP" };
      string[] t = text.Split('\n');
      var list = new Dictionary<string, Item>(256);
      string key;

      for (int i = 0; i < t.Length; i++)
      {
        var line = t[i].Trim().ToUpper();
        if (line.StartsWith("@")) continue;
        if (line.Length < 2) continue;
        if (!commands.Contains(line.Substring(0, 2))) continue;

        if (string.IsNullOrWhiteSpace(line)) continue;

        string[] data = line.Split(' ');
        if (data.Length < 1) continue;

        var item = new Item();

        if (data[0] == "LF" || data[0] == "SF")
        {
          // LF @1107.1 x 2
          if (data.Length < 4) continue;
          item.Name = data[0];
          item.Strike = 0;
          item.Price = Convert.ToDouble(data[1].Substring(1));
          item.Volume = Convert.ToInt32(data[3]) * units;
        }
        else
        {
          // LP 1075 @1.2 x 5
          if (data.Length < 5) continue;
          item.Name = data[0];
          item.Strike = Convert.ToInt32(data[1]);
          item.Price = Convert.ToDouble(data[2].Substring(1));
          item.Volume = Convert.ToInt32(data[4]) * units;
        }

        if (averagePremium)
        {
          key = $"{item.Name[1]}{item.Name[0]} {item.Strike} {item.Price:000.0}";
        }
        else
        {
          key = $"{item.Name[1]}{item.Name[0]} {item.Strike} {item.Price:000.0}";
        }

        if (list.ContainsKey(key)) list[key].Volume += item.Volume;
        else list.Add(key, item);
      }

      if (averagePremium)
      {
        var q = from item in list
                orderby item.Value.Strike, item.Key
                group item.Value by new { item.Value.Strike, item.Value.Name } into g
                select new Item
                {
                  Name = g.FirstOrDefault()?.Name,
                  Strike = g.FirstOrDefault()?.Strike ?? 0,
                  Price = g.Sum(x => x.Price * x.Volume) / g.Sum(x => x.Volume),
                  Volume = g.Sum(x => x.Volume)
                };

        var items = q.ToList();
        return string.Join(Environment.NewLine, q);
      }
      else
      {
        var q = from item in list
                orderby item.Value.Strike, item.Value.Name, item.Value.Price
                select item.Value.ToString();
        return string.Join(Environment.NewLine, q);
      }
    }

    private void TextBox1_Enter(object sender, EventArgs e)
    {
      if (chkAutoSelectText.Checked)
        textBox1.SelectAll();
    }

    private void TextBox2_MouseClick(object sender, MouseEventArgs e)
    {
      SelectOutputText();
      AutoCopy();
    }

    private void AutoCopy()
    {
      try
      {
        if (string.IsNullOrWhiteSpace(txtOutput.Text)) return;

        if (chkAutoCopy.Checked)
        {
          Clipboard.SetText(txtOutput.Text);

          s2.Play();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void SelectOutputText()
    {
      if (string.IsNullOrWhiteSpace(txtOutput.Text)) return;

      lblLines.Text = $"Lines: {txtOutput.Lines.Length}";

      if (chkAutoSelectText.Checked)
      {
        txtOutput.Focus();
        txtOutput.SelectAll();
      }
    }

    private void TextBox1_MouseClick(object sender, MouseEventArgs e)
    {
      if (chkAutoSelectText.Checked)
        textBox1.SelectAll();
    }

    private void Num_ValueChanged(object sender, EventArgs e)
    {
      Simplify();
    }

    private void UpdateLFSF()
    {
      if (tabControl1.SelectedIndex != 1) return;

      string fu = rdLF.Checked ? "LF" : "SF";
      var start = numStartIndex.Value;
      var vol = numVolume.Value;
      var step = numSteps.Value * (rdLF.Checked ? 1 : -1);
      var count = numCount.Value;

      var s = $"@. {fu} Simulation{Environment.NewLine}";

      for (int i = 0; i < count; i++)
      {
        s += $"@index {start:0.0}{Environment.NewLine}";
        s += $"x {fu} @{start:0.0} x {vol}{Environment.NewLine}";
        start += step;
      }

      txtOutput.Text = s;
      SelectOutputText();
      //TextBox2_MouseClick(this, null);
    }

    #region Tab LF SF
    private void NumStartIndex_ValueChanged(object sender, EventArgs e)
    {
      UpdateLFSF();
    }

    private void NumSteps_ValueChanged(object sender, EventArgs e)
    {
      UpdateLFSF();
    }

    private void NumCount_ValueChanged(object sender, EventArgs e)
    {
      UpdateLFSF();

    }

    private void RdLF_CheckedChanged(object sender, EventArgs e)
    {
      UpdateLFSF();
    }

    private void RdSF_CheckedChanged(object sender, EventArgs e)
    {
      UpdateLFSF();
    }

    private void NumVolume_ValueChanged(object sender, EventArgs e)
    {
      UpdateLFSF();

    }
    #endregion

    private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (tabControl1.SelectedIndex)
      {
        case 0: Simplify(); break;
        case 1: UpdateLFSF(); break;
        case 2: ConfirmationNotes(); break;
      }
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://optionsgo.net");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.Save();
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      if (!Properties.Settings.Default.SimulationLF)
        rdSF.Checked = true;

      tabControl1.SelectedIndex = 0;

      string version = "";
      if (ApplicationDeployment.IsNetworkDeployed)
      {
        version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
      }

      Text = Application.ProductName + " " + version;
      Simplify();
    }

    private void ChkAverage_CheckedChanged(object sender, EventArgs e)
    {
      Simplify();
    }

    private void TxtOutput_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnBrokerOrders_Click(object sender, EventArgs e)
    {
      ConfirmationNotes();
    }

    private void ConfirmationNotes()
    {
      var lines = txtBrokerOrders.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
      var sb = new StringBuilder();

      try
      {
        foreach (var line in lines)
        {
          var data = line.Trim().Split(' ');
          var symbol = data[0];
          var side = data[2];
          var volume = int.Parse(data[4]);
          var price = double.Parse(data[5].Replace(",", ""));

          if (symbol.Length > 6)
          {
            var strike = symbol[6] + " " + symbol.Substring(7);
            var text = $"{side}{strike} @{price:0.0} x {volume}";
            sb.AppendLine(text);
          }
          else if (symbol.Length == 6)
          {
            var text = $"{side}F @{price:0.0} x {volume}";
            sb.AppendLine(text);
          }
        }

        txtOutput.Text = sb.ToString();
      }
      catch (Exception)
      {
        MessageBox.Show("Incorrect text");
        txtBrokerOrders.SelectAll();
        txtBrokerOrders.Focus();
        txtOutput.Text = "";
      }

      lblLines.Text = $"Lines: {txtOutput.Lines.Length}";
    }

    private void txtBrokerOrders_Enter(object sender, EventArgs e)
    {
      txtBrokerOrders.Focus();
      txtBrokerOrders.SelectAll();
    }

    private void txtBrokerOrders_MouseClick(object sender, MouseEventArgs e)
    {
      txtBrokerOrders.Focus();
      txtBrokerOrders.SelectAll();
    }
  }
}

// GOH20 BU-20200325-20100 L Open 1 1,611.00 0.00 84.11 5.89 0.00 90.00
// GOH20 SE-20200325-20101 S Close 1 1,616.80 0.00 84.11 5.89 0.00 90.00
// GOH20 BU-20200325-20102 L Open 1 1,620.00 0.00 84.11 5.89 0.00 90.00
// S50H20C775 SH-20200325-20135 S Open 3 4.00 2,400.00 53.28 3.73 0.00 57.01
