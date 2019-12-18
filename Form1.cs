using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jukebox
{
    public partial class Form1 : Form
    {
        Stack spindle;
        string docPath = "c:/temp";
        const int MAX_STACK_SIZE = 9; //-1 for 0 based index

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
            if (spindle.Count() == MAX_STACK_SIZE)
            {
                MessageBox.Show("Max CD's on spindle", "Message", MessageBoxButtons.OK);
                try
                {
                    throw new Exception("Max CD's on Spindle");
                }
                catch (Exception ex)
                {
                    // Write the string array to a new file named "ErrorLog.txt".
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "ErrorLog.txt")))
                    {
                        outputFile.WriteLine(ex.Message);
                    }
                }

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

        private bool txtBox_TrackRemoveIndex_IsValid()
        {
            int i;
            if (string.IsNullOrEmpty(txtBox_RemoveIndex.Text)) return false;
            if (!Int32.TryParse(txtBox_RemoveIndex.Text, out i)) return false;
            if (i > spindle.Count() || i < 0) return false;
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
            txtBox_Output.AppendText(spindle.List());
        }

        private void Btn_LstArtists_Click(object sender, EventArgs e)
        {
            txtBox_Output.AppendText(spindle.List("Artist"));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtBox_TrackRemoveIndex_IsValid())
            {
                var index = Int32.Parse(txtBox_RemoveIndex.Text);
                spindle.RemoveAtIndex(index);
                txtBox_Output.AppendText($"Removed index {index} from stack"+Environment.NewLine);
            }
            else
            {
                errorProvider1.SetError(txtBox_RemoveIndex,
                    "Removal index must be a valid int less that the total stack size" + Environment.NewLine);
            }
        }
    }
}
