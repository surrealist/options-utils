using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
      Simplify();
    }

    private void Simplify()
    {
      int n = Convert.ToInt32(num.Value);
      txtOutput.Text = Simplify1(textBox1.Text, n);
      TextBox2_MouseClick(this, null);
    }

    private string Simplify1(string text, int units)
    {
      var commands = new[] { "LF", "SF", "LC", "LP", "SC", "SP" };
      string[] t = text.Split('\n');
      var list = new Dictionary<string, Item>(256);

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

        var key = $"{item.Name} {item.Strike} {item.Price:n1}";
        if (list.ContainsKey(key)) list[key].Volume += item.Volume;
        else list.Add(key, item);
      }

      var q = from item in list
              orderby item.Value.Strike, item.Value.Name, item.Value.Price
              select item.Value.ToString();
      return string.Join(Environment.NewLine, q);
    }

    private void TextBox1_Enter(object sender, EventArgs e)
    {
      if (chkAutoSelectText.Checked)
        textBox1.SelectAll();
    }

    private void TextBox2_MouseClick(object sender, MouseEventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtOutput.Text)) return;

      lblLines.Text = $"Lines: {txtOutput.Lines.Length}";

      txtOutput.Focus();
      txtOutput.SelectAll();
      try
      {
        Clipboard.SetText(txtOutput.Text);

        s2.Play();
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
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
      TextBox2_MouseClick(this, null);
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
    }
  }
}
