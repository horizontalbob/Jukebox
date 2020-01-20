namespace Jukebox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_Peek = new System.Windows.Forms.Button();
            this.txtBox_Output = new System.Windows.Forms.TextBox();
            this.txtBox_Artist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Album = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Duration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Tracks = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_LstArtists = new System.Windows.Forms.Button();
            this.btn_RemoveAtIndex = new System.Windows.Forms.Button();
            this.txtBox_RemoveIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(647, 382);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(141, 33);
            this.btn_Remove.TabIndex = 0;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(719, 248);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(141, 33);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Location = new System.Drawing.Point(444, 382);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(141, 33);
            this.btn_Info.TabIndex = 2;
            this.btn_Info.Text = "Info";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_Peek
            // 
            this.btn_Peek.Location = new System.Drawing.Point(228, 382);
            this.btn_Peek.Name = "btn_Peek";
            this.btn_Peek.Size = new System.Drawing.Size(141, 33);
            this.btn_Peek.TabIndex = 3;
            this.btn_Peek.Text = "Peek";
            this.btn_Peek.UseVisualStyleBackColor = true;
            this.btn_Peek.Click += new System.EventHandler(this.btn_Peek_Click);
            // 
            // txtBox_Output
            // 
            this.txtBox_Output.Location = new System.Drawing.Point(22, 13);
            this.txtBox_Output.Multiline = true;
            this.txtBox_Output.Name = "txtBox_Output";
            this.txtBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Output.Size = new System.Drawing.Size(451, 268);
            this.txtBox_Output.TabIndex = 4;
            // 
            // txtBox_Artist
            // 
            this.txtBox_Artist.Location = new System.Drawing.Point(647, 13);
            this.txtBox_Artist.Name = "txtBox_Artist";
            this.txtBox_Artist.Size = new System.Drawing.Size(213, 20);
            this.txtBox_Artist.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Album";
            // 
            // txtBox_Album
            // 
            this.txtBox_Album.Location = new System.Drawing.Point(647, 63);
            this.txtBox_Album.Name = "txtBox_Album";
            this.txtBox_Album.Size = new System.Drawing.Size(213, 20);
            this.txtBox_Album.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Playback duration";
            // 
            // txtBox_Duration
            // 
            this.txtBox_Duration.Location = new System.Drawing.Point(647, 118);
            this.txtBox_Duration.Name = "txtBox_Duration";
            this.txtBox_Duration.Size = new System.Drawing.Size(213, 20);
            this.txtBox_Duration.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "No. of tracks";
            // 
            // txtBox_Tracks
            // 
            this.txtBox_Tracks.Location = new System.Drawing.Point(647, 172);
            this.txtBox_Tracks.Name = "txtBox_Tracks";
            this.txtBox_Tracks.Size = new System.Drawing.Size(213, 20);
            this.txtBox_Tracks.TabIndex = 11;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(492, 248);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(141, 33);
            this.btn_Next.TabIndex = 13;
            this.btn_Next.Text = "Play/Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // btn_List
            // 
            this.btn_List.Location = new System.Drawing.Point(22, 382);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(141, 33);
            this.btn_List.TabIndex = 14;
            this.btn_List.Text = "List";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.Btn_List_Click);
            // 
            // btn_LstArtists
            // 
            this.btn_LstArtists.Location = new System.Drawing.Point(22, 316);
            this.btn_LstArtists.Name = "btn_LstArtists";
            this.btn_LstArtists.Size = new System.Drawing.Size(141, 33);
            this.btn_LstArtists.TabIndex = 15;
            this.btn_LstArtists.Text = "List Artists";
            this.btn_LstArtists.UseVisualStyleBackColor = true;
            this.btn_LstArtists.Click += new System.EventHandler(this.Btn_LstArtists_Click);
            // 
            // btn_RemoveAtIndex
            // 
            this.btn_RemoveAtIndex.Location = new System.Drawing.Point(492, 316);
            this.btn_RemoveAtIndex.Name = "btn_RemoveAtIndex";
            this.btn_RemoveAtIndex.Size = new System.Drawing.Size(141, 33);
            this.btn_RemoveAtIndex.TabIndex = 16;
            this.btn_RemoveAtIndex.Text = "Remove at index:";
            this.btn_RemoveAtIndex.UseVisualStyleBackColor = true;
            this.btn_RemoveAtIndex.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBox_RemoveIndex
            // 
            this.txtBox_RemoveIndex.Location = new System.Drawing.Point(664, 323);
            this.txtBox_RemoveIndex.Name = "txtBox_RemoveIndex";
            this.txtBox_RemoveIndex.Size = new System.Drawing.Size(213, 20);
            this.txtBox_RemoveIndex.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.txtBox_RemoveIndex);
            this.Controls.Add(this.btn_RemoveAtIndex);
            this.Controls.Add(this.btn_LstArtists);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Tracks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_Duration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Album);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Artist);
            this.Controls.Add(this.txtBox_Output);
            this.Controls.Add(this.btn_Peek);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Remove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Peek;
        private System.Windows.Forms.TextBox txtBox_Output;
        private System.Windows.Forms.TextBox txtBox_Artist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Album;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Tracks;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_LstArtists;
        private System.Windows.Forms.Button btn_RemoveAtIndex;
        private System.Windows.Forms.TextBox txtBox_RemoveIndex;
    }
}

