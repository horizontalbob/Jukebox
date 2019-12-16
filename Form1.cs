using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jukebox
{
    public partial class Form1 : Form
    {
        Stack spindle;
        public Form1()
        {
            InitializeComponent();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider
            {
                DataMember = null
            };

            spindle = new Stack();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            errorProvider1.ContainerControl = this;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (spindle.Count() == 9)
            {
                MessageBox.Show("Max CD's on spindle", "Message", MessageBoxButtons.OK);
                ClearFields();
            }
            else
            {
                if (IsAddValid())
                {
                    var cd = new CDNode
                    {
                        Name = txtBox_Album.Text,
                        Artist = txtBox_Artist.Text,
                        PlaybackLength = txtBox_Duration.Text,
                        NumberOfTracks = Int32.Parse(txtBox_Tracks.Text)
                    };
                    spindle.Push(cd);
                    txtBox_Output.AppendText($@"CD added. Number in spindle is {spindle.Count()}.
");
                    ClearFields();
                }
            }
        }

        private void btn_Peek_Click(object sender, EventArgs e)
        {
            txtBox_Output.AppendText($"Next on spindle {spindle.Info(spindle.Peek())}");
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            txtBox_Output.AppendText(spindle.Info(spindle.Pop()));
        }

        #region IsValid checks

        private bool txtBox_Artist_IsValid()
        {
            return (!string.IsNullOrEmpty(txtBox_Artist.Text));
        }

        private bool txtBox_Album_IsValid()
        {
            return (!string.IsNullOrEmpty(txtBox_Album.Text));
        }

        private bool txtBox_Duration_IsValid()
        {
            if(string.IsNullOrEmpty(txtBox_Duration.Text)) return false;
            //if (!new Regex("@[\\d]+:[0-5][0-9]$").Match(txtBox_Duration.Text).Success) return false;
            return true;
        }

        private bool txtBox_Tracks_IsValid()
        {
            if (string.IsNullOrEmpty(txtBox_Tracks.Text)) return false;
            if (!Int32.TryParse(txtBox_Tracks.Text, out _)) return false;
            return true;
        }

        private bool AllValid()
        {
            return txtBox_Artist_IsValid() &&
                   txtBox_Album_IsValid() &&
                   txtBox_Duration_IsValid() &&
                   txtBox_Tracks_IsValid();
        }

        private bool IsAddValid()
        {
            if (!txtBox_Artist_IsValid())
            {
                errorProvider1.SetError(txtBox_Artist, "Artist required.");
            }
            if (!txtBox_Album_IsValid())
            {
                errorProvider1.SetError(txtBox_Album, "Album required.");
            }
            if (!txtBox_Duration_IsValid())
            {
                errorProvider1.SetError(txtBox_Duration, "Duration required in 00:00 format.");
            }
            if (!txtBox_Tracks_IsValid())
            {
                errorProvider1.SetError(txtBox_Tracks, "Tracks required in int format.");
            }
            return AllValid();
        }

        private void ClearFields()
        {
            txtBox_Artist.Text = "";
            txtBox_Album.Text = "";
            txtBox_Duration.Text = "";
            txtBox_Tracks.Text = "";
        }

        #endregion

        private void Btn_Next_Click(object sender, EventArgs e)
        {

        }

        private void Btn_List_Click(object sender, EventArgs e)
        {
            txtBox_Artist.AppendText(spindle.List());
        }
    }
}
